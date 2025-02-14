using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Projects
{
	public partial class StartMenu : Form
	{
		private static readonly string filePath = @".\score.dat";
		private GameUI? gameForm;
		private Settings? settingsForm;
		private int Row { get; set; }
		private int Column { get; set; }
		private int BestScore { get; set; }

		public StartMenu()
		{
			InitializeComponent();
			Row = Column = 4;

			using FileStream stream = File.Open(filePath, FileMode.OpenOrCreate);
			using BinaryReader reader = new(stream);
			if (stream.Length > 0)
				BestScore = reader.ReadInt32();
		}

		/// <summary>
		/// 将最高分写入到本地文件中
		/// </summary>
		private void SaveBestScore()
		{
			using FileStream stream = File.Open(filePath, FileMode.Open);
			using BinaryWriter writer = new(stream);
			writer.Write(BestScore);
		}

		private void StartGameButton_Click(object sender, EventArgs e)
		{
			if (gameForm is null || gameForm.IsDisposed)
			{
				gameForm = new(Row, Column)
				{
					updateBestScoreHandler = bestScore => BestScore = bestScore,
					BestScore = BestScore
				};
				gameForm.Show();
			}
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			if (settingsForm is null || settingsForm.IsDisposed)
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
			SaveBestScore();
			Dispose();
		}

		private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveBestScore();
			Dispose();
		}
	}
}
