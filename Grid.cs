using MessagePack;

namespace CSharp_Projects
{
	[MessagePackObject(keyAsPropertyName: true, AllowPrivate = true)]
	public partial class Grid
	{
		public int Row { get; private set; }
		public int Column { get; private set; }
		private Tile[][] Tiles { get; set; }
		public int Count { get; private set; }

		public Grid() : this(4, 4) { }

		public Grid(int row, int col)
		{
			Row = row;
			Column = col;
			Tiles = new Tile[row][];
			Count = 0;

			for (int i = 0; i < row; i++)
			{
				Tiles[i] = new Tile[col];
				Tiles[i].Initialize();
			}
		}

		public Grid(Grid grid) : this(grid.Row, grid.Column)
		{
			grid.CopyTo(this);
		}

		[IgnoreMember]
		public Tile this[int row, int col]
		{
			get
			{
				return Tiles[row][col];
			}
			set
			{
				if (Tiles[row][col].IsEmpty && value != 0)
					Count++;
				if (!Tiles[row][col].IsEmpty && value == 0)
					Count--;

				Tiles[row][col] = value;
			}
		}

		/// <summary>
		/// 棋盘复制操作，将当前棋盘中的所有方块复制到目标棋盘
		/// </summary>
		/// <param name="newGrid">目标棋盘</param>
		public void CopyTo(Grid newGrid)
		{
			for (int i = 0; i < Row; i++)
				Array.Copy(Tiles[i], newGrid.Tiles[i], Column);
		}

		/// <summary>
		/// 在棋盘中遍历寻找方块或空白格子
		/// </summary>
		/// <param name="empty">是否查找空白区域</param>
		/// <returns>所有方块或空白格所在的坐标（行标、列标）的集合</returns>
		public IEnumerable<(int, int)> FindSpaces(bool empty = false)
		{
			for (int i = 0; i < Row; i++)
				for (int j = 0; j < Column; j++)
					if (empty ? Tiles[i][j].IsEmpty : !Tiles[i][j].IsEmpty)
						yield return (i, j);
		}
	}
}
