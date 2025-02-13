﻿using CSharp_Projects;
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

		private Game? game;
		public Action<int>? updateBestScoreHandler;
		public int Row { get; }
		public int Column { get; }
		public int BestScore { get; set; }

		public GameUI(int row, int column)
		{
			InitializeComponent();
			Size = new(100 + column * 75, 183 + row * 75);
			game = new(row, column);
			Row = row;
			Column = column;
		}

		private float GetFontSize(int number) => number switch
		{
			< 128 => 16.2F,
			>= 128 and < 1024 => 12F,
			>= 1024 => 9F,
		};

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

			if (game is not null)
			{
				foreach ((int row, int col) in game.Grid.FindSpaces())
				{
					Tile tile = game.Grid[row, col];
					Label label = RenderTile(tile);
					gridPanel.Controls.Add(label, col, row);
				}
			}

			splitContainer1.Panel2.Controls.Add(gridPanel);
			AlignGridToCenter();
		}

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

		private void UpdateScore()
		{
			if (game is not null)
			{
				BestScore = Math.Max(BestScore, game.Score);
				scoreLabel.Text = $"{game.Score}";
				bestScoreLabel.Text = $"{BestScore}";
			}
		}

		private void GameUI_KeyDown(object sender, KeyEventArgs e)
		{
			if (game is not null)
			{
				game.Swipe(e.KeyCode);
				RenderGrid();
				UpdateScore();

				if (game.IsOver(out bool complete))
				{
					if (complete)
						MessageBox.Show("成功通关!!", "恭喜!");
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

		private void GameUI_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (updateBestScoreHandler is not null)
				updateBestScoreHandler(BestScore);

			Dispose();
		}
	}
}
