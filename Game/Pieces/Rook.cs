namespace CsAndPChess.Game.Piece
{
    public sealed class Rook : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.Rook;

        public Tile Position { get; private set; }

        public Rook(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

        // Move set for 2d array
        // Rook can move any number of squares along a rank or file
        // [+x, 0], [-x, 0], [0, +y], [0, -y]
    }
}