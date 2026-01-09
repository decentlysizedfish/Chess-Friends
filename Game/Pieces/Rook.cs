namespace CsAndPChess.Game.Piece
{
    public sealed class Piece : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.Rook;

        public Tile Position { get; private set; }

        public Piece(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        // Move set for 2d array
    }
}