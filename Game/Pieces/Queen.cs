namespace CsAndPChess.Game.Piece
{
    public sealed class Queen : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.Queen;

        public Tile Position { get; private set; }

        public Queen(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

        // Move set for 2d array
        // Queen can move any number of squares along a rank, file, or diagonal
        // [+x, 0], [-x, 0], [0, +y], [0, -y], [+x, +y], [+x, -y], [-x, +y], [-x, -y]
    }
}