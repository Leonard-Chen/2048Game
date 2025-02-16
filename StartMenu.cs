using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Projects
{
	public partial class StartMenu : Form
	{
		private static readonly string scoreFilePath = @".\score.dat";
		private static readonly string savedGameFilePath = @".\game.dat";

		private GameUI? gameForm;
		private Settings? settingsForm;
		private Game? savedGame;

		private int Row { get; set; }
		private int Column { get; set; }
		private int BestScore { get; set; }

		public StartMenu()
		{
			InitializeComponent();
			Row = Column = 4;

			LoadBestScore();
			LoadGameFile();
		}

		/// <summary>
		/// 关闭程序之前做一些工作
		/// </summary>
		private void BeforeExit()
		{
			if (!(gameForm is null || gameForm.IsDisposed))
			{
				DialogResult result = MessageBox.Show("当前游戏还在进行. 是否保存游戏?", "提示", MessageBoxButtons.YesNo);

				if (result is DialogResult.Yes)
					SaveGame();
			}

			SaveBestScore();
			SaveGame();
			Dispose();
		}

		/// <summary>
		/// 从本地读取最高分
		/// </summary>
		private void LoadBestScore()
		{
			using FileStream scoreFileStream = File.Open(scoreFilePath, FileMode.OpenOrCreate);
			using BinaryReader reader = new(scoreFileStream);
			if (scoreFileStream.Length > 0)
				BestScore = reader.ReadInt32();
		}

		/// <summary>
		/// 读取游戏存档
		/// </summary>
		private void LoadGameFile()
		{
			using FileStream stream = File.Open(savedGameFilePath, FileMode.OpenOrCreate);

			try
			{
				if (stream.Length > 0)
					savedGame = MessagePackSerializer.Deserialize<Game>(stream);
			}
			catch (SerializationException)
			{
				MessageBox.Show("读取存档时出现问题.", "错误");
			}
		}

		/// <summary>
		/// 将最高分写入到本地文件中
		/// </summary>
		private void SaveBestScore()
		{
			using FileStream stream = File.Open(scoreFilePath, FileMode.Open);
			using BinaryWriter writer = new(stream);
			writer.Write(BestScore);
		}

		/// <summary>
		/// 将游戏存档写入到本地文件中
		/// </summary>
		private void SaveGame()
		{
			if (savedGame is not null)
			{
				using FileStream stream = File.Open(savedGameFilePath, FileMode.OpenOrCreate);
				byte[] bytes = MessagePackSerializer.Serialize<Game>(savedGame);
				using BinaryWriter writer = new(stream);
				writer.Write(bytes);
			}
		}

		private void NewGameButton_Click(object sender, EventArgs e)
		{
			if (gameForm is null || gameForm.IsDisposed)
			{
				if (savedGame is not null)
				{
					DialogResult result = MessageBox.Show("上次游戏还在进行. 是否覆盖?", "提示", MessageBoxButtons.YesNo);
					switch (result)
					{
						case DialogResult.Yes:
							File.Create(savedGameFilePath);
							savedGame = null;
							break;
						case DialogResult.No:
							return;
						default:
							throw new InvalidEnumArgumentException("未知错误.");
					}
				}

				gameForm = new(Row, Column)
				{
					updateBestScoreHandler = bestScore => BestScore = bestScore,
					saveGameHandler = game => savedGame = game,
					BestScore = BestScore
				};

				gameForm.Show();
			}
		}

		private void ContinueButton_Click(object sender, EventArgs e)
		{
			if (savedGame is not null && (gameForm is null || gameForm.IsDisposed))
			{
				gameForm = new(savedGame)
				{
					updateBestScoreHandler = bestScore => BestScore = bestScore,
					saveGameHandler = game => savedGame = game,
					BestScore = BestScore
				};

				gameForm.Show();
			}
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			if ((gameForm is null || gameForm.IsDisposed) && (settingsForm is null || settingsForm.IsDisposed))
			{
				settingsForm = new()
				{
					Row = Row,
					Column = Column,
					setValueHandler = (row, column) =>
					{
						Row = row;
						Column = column;
					},
					clearBestScoreHandler = () => BestScore = 0,
					BestScore = BestScore
				};

				settingsForm.Show();
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			BeforeExit();
		}

		private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			BeforeExit();
		}

		private void StartMenu_Load(object sender, EventArgs e)
		{
			continueButton.Enabled = savedGame is not null;
		}

		private void StartMenu_Activated(object sender, EventArgs e)
		{
			continueButton.Enabled = savedGame is not null;
		}
	}
}
