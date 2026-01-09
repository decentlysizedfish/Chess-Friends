namespace CsAndPChess.Game.Piece
{
    public sealed class Knight : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.Knight;

        public Tile Position { get; private set; }

        public Knight(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

        // Move set for 2d array
        // Knight moves in an L-shape: [±2, ±1] or [±1, ±2] one time
        // [2, 1], [2, -1], [-2, 1], [-2, -1], [1, 2], [1, -2], [-1, 2], [-1, -2]
    }
}