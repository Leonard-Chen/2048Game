using CSharp_Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Projects
{
	public partial class GameUI : Form
	{
		private static readonly Dictionary<int, Color> tileColors = new Dictionary<int, Color>
		{
			[2] = Color.FromArgb(238, 228, 218),
			[4] = Color.FromArgb(237, 224, 200),
			[8] = Color.FromArgb(242, 177, 121),
			[16] = Color.FromArgb(245, 149, 99),
			[32] = Color.FromArgb(246, 124, 95),
			[64] = Color.FromArgb(246, 94, 59),
			[128] = Color.FromArgb(237, 207, 114),
			[256] = Color.FromArgb(237, 204, 97),
			[512] = Color.FromArgb(237, 200, 80),
			[1024] = Color.FromArgb(237, 197, 63),
			[2048] = Color.FromArgb(237, 193, 46)
		};

		public Action<int>? updateBestScoreHandler;
		public Action<Game?>? saveGameHandler;
		public Game Game { get; }
		public int Row { get; }
		public int Column { get; }
		public int BestScore { get; set; }

		public GameUI(Game game) : this(game.Row, game.Column)
		{
			Game = new(game);
		}

		public GameUI(int row, int column)
		{
			InitializeComponent();
			Size = new(100 + column * 75, 183 + row * 75);
			Game = new(row, column);
			Row = row;
			Column = column;
		}

		/// <summary>
		/// 根据数字大小调整字体大小，避免出现数字显示问题
		/// </summary>
		/// <param name="number">方块中的数字</param>
		/// <returns></returns>
		private float GetFontSize(int number) => number switch
		{
			< 128 => 16.2F,
			>= 128 and < 1024 => 12F,
			>= 1024 => 9F,
		};

		/// <summary>
		/// 渲染方块
		/// </summary>
		/// <param name="number">方块中的数字</param>
		/// <returns>渲染后得到的Label控件</returns>
		private Label RenderTile(int number)
		{
			Label tile = new();
			tile.BackColor = tileColors[number];
			tile.ForeColor = number < 8 ? Color.FromArgb(119, 110, 101) : Color.FromArgb(249, 246, 242);
			tile.BorderStyle = BorderStyle.FixedSingle;
			tile.Dock = DockStyle.Fill;
			tile.Font = new Font("Microsoft YaHei UI", GetFontSize(number), FontStyle.Bold, GraphicsUnit.Point, 134);
			tile.Margin = new Padding(10);
			tile.Size = new Size(53, 53);
			tile.Text = $"{number}";
			tile.TextAlign = ContentAlignment.MiddleCenter;
			return tile;
		}

		/// <summary>
		/// 渲染棋盘
		/// </summary>
		private void RenderGrid()
		{
			splitContainer1.Panel2.Controls.Remove(gridPanel);

			gridPanel = new();
			gridPanel.Anchor = AnchorStyles.None;
			gridPanel.BackColor = Color.FromArgb(205, 193, 180);
			gridPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			gridPanel.RowCount = Row;
			gridPanel.ColumnCount = Column;

			for (int i = 0; i < Row; i++)
				gridPanel.RowStyles.Add(new(SizeType.Percent, 100F / Row));

			for (int j = 0; j < Column; j++)
				gridPanel.ColumnStyles.Add(new(SizeType.Percent, 100F / Column));

			gridPanel.Size = new(75 * Column, 75 * Row);

			if (Game is not null)
			{
				foreach ((int row, int col) in Game.Grid.FindSpaces())
				{
					Tile tile = Game.Grid[row, col];
					Label label = RenderTile(tile);
					gridPanel.Controls.Add(label, col, row);
				}
			}

			splitContainer1.Panel2.Controls.Add(gridPanel);
			AlignGridToCenter();
		}

		/// <summary>
		/// 棋盘居中
		/// </summary>
		private void AlignGridToCenter()
		{
			var panelSize = splitContainer1.Panel2.ClientSize;
			(int panelWidth, int panelHeight) = (panelSize.Width, panelSize.Height);
			(int gridWidth, int gridHeight) = (gridPanel.Width, gridPanel.Height);
			gridPanel.Location = new Point
			{
				X = (panelWidth - gridWidth) / 2,
				Y = (panelHeight - gridHeight) / 2
			};
		}

		/// <summary>
		/// 更新游戏当前分数、最高分
		/// </summary>
		private void UpdateScore()
		{
			if (Game is not null)
			{
				BestScore = Math.Max(BestScore, Game.Score);
				scoreLabel.Text = $"{Game.Score}";
				bestScoreLabel.Text = $"{BestScore}";
			}

			if (updateBestScoreHandler is not null)
				updateBestScoreHandler(BestScore);
		}

		private void GameUI_KeyDown(object sender, KeyEventArgs e)
		{
			if (Game is not null)
			{
				Game.Swipe(e.KeyCode);
				RenderGrid();
				UpdateScore();

				if (Game.IsOver(out bool complete))
				{
					if (complete)
					{
						DialogResult result = MessageBox.Show("你已经成功通关!! 是否继续游戏?", "恭喜!", MessageBoxButtons.YesNo);
						if (result == DialogResult.Yes)
							return;
					}
					else
						MessageBox.Show("游戏结束!", "失败!");

					if (updateBestScoreHandler is not null)
						updateBestScoreHandler(BestScore);

					Dispose();
				}
			}
		}

		private void GameUI_Load(object sender, EventArgs e)
		{
			RenderGrid();
			UpdateScore();
		}

		private void GameUI_SizeChanged(object sender, EventArgs e)
		{
			AlignGridToCenter();
		}

		private void GameUI_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("游戏正在进行, 是否退出并保存游戏?", "提示", MessageBoxButtons.YesNoCancel);

			switch (result)
			{
				case DialogResult.Yes:
					if (saveGameHandler is not null)
						saveGameHandler(Game);
					e.Cancel = false;
					break;

				case DialogResult.No:
					e.Cancel = false;
					break;

				case DialogResult.Cancel:
					e.Cancel = true;
					break;

				default:
					throw new InvalidEnumArgumentException("未知错误.");
			}
		}
	}
}
