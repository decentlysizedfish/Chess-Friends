// The interface for all chess pieces
// Move set may be stores in the peices eventually, but not right now

//using CsAndPChess.Game.Board;
namespace CsAndPChess.Game.Pieces
{
    public interface IPiece
    {
        public bool White { get; } // true for white, false for black
        public PieceType Type { get; }
        public Tile Position { get; set; }
    }
}