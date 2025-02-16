using MessagePack;

namespace CSharp_Projects
{
	[MessagePackObject(keyAsPropertyName: true)]
	public partial struct Tile
	{
		public int Number { get; private set; }
		public bool IsEmpty { get; private set; }

		public Tile()
		{
			Number = 0;
			IsEmpty = true;
		}

		public static Tile operator *(Tile tile, int n) => new Tile { Number = tile.Number * n, IsEmpty = false };

		public static bool operator ==(Tile t1, Tile t2) => t1.Number == t2.Number;

		public static bool operator !=(Tile t1, Tile t2) => t1.Number != t2.Number;

		public static implicit operator int(Tile tile) => tile.Number;

		public static implicit operator Tile(int number) => new Tile { Number = number, IsEmpty = number == 0 ? true : false };
	}
}
