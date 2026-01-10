namespace CsAndPChess.Game.Piece
{
    public sealed class Piece : IPiece
    {
        public White IsWhite { get; }
        public PieceType Type;


        public Piece(PieceType pType, bool isWhite, Tile startPosition)
        {
            Type = PieceType.pType;
            IsWhite = isWhite;
        }

    }
}