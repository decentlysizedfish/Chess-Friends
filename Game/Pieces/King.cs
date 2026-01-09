namespace CsAndPChess.Game.Piece
{
    public sealed class King : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.King;

        public Tile Position { get; private set; }

        public King(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

        // Move set for 2d array
        // King can move one square in any direction one time
        // [0, +1], [0, -1], [+1, 0], [-1, 0], [+1, +1], [+1, -1], [-1, +1], [-1, -1]
    }
}