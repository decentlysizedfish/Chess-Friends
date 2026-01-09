namespace CsAndPChess.Game.Piece
{
    public sealed class Pawn : IPiece
    {
        public White IsWhite { get; }
        public static PieceType Type => PieceType.Pawn;

        public Tile Position { get; private set; }

        public Pawn(White isWhite, Tile startPosition)
        {
            IsWhite = isWhite;
            Position = startPosition;
        }

        public void MoveTo(Tile newPosition)
        {
            Position = newPosition;
        }

        // Move set for 2d array
        // Pawn can move one square forward, or two squares on its first move
        // [0, +1] (forward), [0, +2] (first move)
    }
}