
namespace CSharp_Projects
{
	class Game
	{
		private Random Seed { get; }
		public Grid Grid { get; private set; }
		public int Row { get; private set; }
		public int Column { get; private set; }
		public int Score { get; private set; }
		public int MaxNumber { get; private set; }

		public Game(int row, int col)
		{
			Seed = new();
			Grid = new(row, col);
			Row = row;
			Column = col;
			Score = 0;
			MaxNumber = 0;
			InitializeGrid();
		}

		/// <summary>
		/// 棋盘初始化，随机选取两个位置生成方块
		/// </summary>
		private void InitializeGrid()
		{
			(int i, int j) = (Seed.Next(Row), Seed.Next(Column));
			Grid[i, j] = 2;

			(int m, int n) = (0, 0);
			//避免随机到重复位置
			while (i == m && j == n)
				(m, n) = (Seed.Next(Row), Seed.Next(Column));
			Grid[m, n] = 2;
		}

		/// <summary>
		/// 使棋盘中的方块往某个方向滑动
		/// </summary>
		/// <param name="key">用户按键</param>
		public void Swipe(Keys key)
		{
			bool canSwipe = key switch
			{
				Keys.W or Keys.Up => SwipeUp(),
				Keys.A or Keys.Left => SwipeLeft(),
				Keys.S or Keys.Down => SwipeDown(),
				Keys.D or Keys.Right => SwipeRight(),
				_ => false,
			};

			if (canSwipe)
				GenerateNewTile();
		}

		/// <summary>
		/// 向上滑动
		/// </summary>
		/// <returns>方块能否滑动</returns>
		private bool SwipeUp()
		{
			bool updated = false;

			for (int j = 0; j < Column; j++)
			{
				int k = 0;
				for (; k < Row && !Grid[k, j].IsEmpty; k++) ;

				bool merged = false;

				for (int m = 0, n = 0; k > n; n++)
				{
					if (m < Row - 1 && Grid[m, j] == Grid[m + 1, j] && !merged)
					{
						updated = true;

						(Grid[m, j], Grid[m + 1, j], Grid[n, j]) = (0, 0, Grid[m, j] * 2);
						ScoreFromNumber(Grid[n, j]);
						m += 2;
						k--;
						merged = true;
					}
					else
					{
						(Grid[m, j], Grid[n, j]) = (0, Grid[m, j]);
						m++;
						merged = false;
					}
				}

				for (int i = k + 1; i < Row; i++)
				{
					if (Grid[i, j].IsEmpty)
						continue;

					updated = true;

					if (k > 0 && Grid[k - 1, j] == Grid[i, j] && !merged)
					{
						ScoreFromNumber(Grid[k - 1, j] *= 2);
						merged = true;
					}
					else
					{
						Grid[k++, j] = Grid[i, j];
						merged = false;
					}

					Grid[i, j] = 0;
				}
			}

			return updated;
		}

		/// <summary>
		/// 向左滑动
		/// </summary>
		/// <returns>方块能否滑动</returns>
		private bool SwipeLeft()
		{
			bool updated = false;

			for (int i = 0; i < Row; i++)
			{
				int k = 0;
				for (; k < Column && !Grid[i, k].IsEmpty; k++) ;

				bool merged = false;

				for (int m = 0, n = 0; k > n; n++)
				{
					if (m < Column - 1 && Grid[i, m] == Grid[i, m + 1] && !merged)
					{
						updated = true;

						(Grid[i, m], Grid[i, m + 1], Grid[i, n]) = (0, 0, Grid[i, m] * 2);
						ScoreFromNumber(Grid[i, n]);
						m += 2;
						k--;
						merged = true;
					}
					else
					{
						(Grid[i, m], Grid[i, n]) = (0, Grid[i, m]);
						m++;
						merged = false;
					}
				}

				for (int j = k + 1; j < Column; j++)
				{
					if (Grid[i, j].IsEmpty)
						continue;

					updated = true;

					if (k > 0 && Grid[i, k - 1] == Grid[i, j] && !merged)
					{
						ScoreFromNumber(Grid[i, k - 1] *= 2);
						merged = true;
					}
					else
					{
						Grid[i, k++] = Grid[i, j];
						merged = false;
					}

					Grid[i, j] = 0;
				}
			}

			return updated;
		}

		/// <summary>
		/// 向下滑动
		/// </summary>
		/// <returns>方块能否滑动</returns>
		private bool SwipeDown()
		{
			bool updated = false;

			for (int j = 0; j < Column; j++)
			{
				int k = Row - 1;
				for (; k >= 0 && !Grid[k, j].IsEmpty; k--) ;

				bool merged = false;

				for (int m = Row - 1, n = Row - 1; k < n; n--)
				{
					if (m > 0 && Grid[m - 1, j] == Grid[m, j] && !merged)
					{
						updated = true;

						(Grid[m, j], Grid[m - 1, j], Grid[n, j]) = (0, 0, Grid[m, j] * 2);
						ScoreFromNumber(Grid[n, j]);
						m -= 2;
						k++;
						merged = true;
					}
					else
					{
						(Grid[m, j], Grid[n, j]) = (0, Grid[m, j]);
						m--;
						merged = false;
					}
				}

				for (int i = k - 1; i >= 0; i--)
				{
					if (Grid[i, j].IsEmpty)
						continue;

					updated = true;

					if (k < Column - 1 && Grid[k + 1, j] == Grid[i, j] && !merged)
					{
						ScoreFromNumber(Grid[k + 1, j] *= 2);
						merged = true;
					}
					else
					{
						Grid[k--, j] = Grid[i, j];
						merged = false;
					}

					Grid[i, j] = 0;
				}
			}

			return updated;
		}

		/// <summary>
		/// 向右滑动
		/// </summary>
		/// <returns>方块能否滑动</returns>
		private bool SwipeRight()
		{
			bool updated = false;

			for (int i = 0; i < Row; i++)
			{
				int k = Column - 1;
				for (; k >= 0 && !Grid[i, k].IsEmpty; k--) ;

				bool merged = false;

				for (int m = Column - 1, n = Column - 1; k < n; n--)
				{
					if (m > 0 && Grid[i, m - 1] == Grid[i, m] && !merged)
					{
						updated = true;

						(Grid[i, m], Grid[i, m - 1], Grid[i, n]) = (0, 0, Grid[i, m] * 2);
						ScoreFromNumber(Grid[i, n]);
						m -= 2;
						k++;
						merged = true;
					}
					else
					{
						(Grid[i, m], Grid[i, n]) = (0, Grid[i, m]);
						m--;
						merged = false;
					}
				}

				for (int j = k - 1; j >= 0; j--)
				{
					if (Grid[i, j].IsEmpty)
						continue;

					updated = true;

					if (k < Column - 1 && Grid[i, k + 1] == Grid[i, j] && !merged)
					{
						ScoreFromNumber(Grid[i, k + 1] *= 2);
						merged = true;
					}
					else
					{
						Grid[i, k--] = Grid[i, j];
						merged = false;
					}

					Grid[i, j] = 0;
				}
			}

			return updated;
		}

		/// <summary>
		/// 得分，更新最大数字
		/// </summary>
		/// <param name="number">两个相同方块合并得到的数字</param>
		private void ScoreFromNumber(int number)
		{
			MaxNumber = Math.Max(MaxNumber, number);
			Score += number;
		}

		/// <summary>
		/// 在剩余空白区域随机生成一个方块
		/// </summary>
		private void GenerateNewTile()
		{
			var positions = Grid.FindSpaces(true).ToArray();
			Seed.Shuffle(positions);
			(int i, int j) = positions[0];
			Grid[i, j] = 2;
		}

		/// <summary>
		/// 判断游戏是否结束
		/// </summary>
		/// <param name="success">游戏是否通关</param>
		/// <returns></returns>
		public bool IsOver(out bool success)
		{
			if (MaxNumber == 2048)
			{
				success = true;
				return true;
			}

			if (Grid.Count < Row * Column)
			{
				success = false;
				return false;
			}

			Game game = new(Row, Column);
			Grid.CopyTo(game.Grid);
			bool isOver = !game.SwipeUp() && !game.SwipeLeft() && !game.SwipeDown() && !game.SwipeRight();
			success = false;
			return isOver;
		}
	}
}
