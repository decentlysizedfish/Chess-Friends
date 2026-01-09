namespace CsAndPChess.Game.Piece
{
    public sealed class Piece : IPiece
    {
        public White IsWhite { get; }
        public PieceType Type;

        public Tile Position { get; private set; }

        public Piece(PieceType pType, bool isWhite, Tile startPosition)
        {
            Type = PieceType.pType;
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

    }
}