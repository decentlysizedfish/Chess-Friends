
namespace CsAndPChess.Game.Board
{
    public sealed class Board
    {
        public readonly Tile[,] _tiles = new Tile[8, 8];

        public bool isWhiteTurn = true;

        public

        // find piece at tile
        public Piece GetPieceAtTile(Tile tile)
        {
            return Piece;
        }
        public bool IsEmptyTile(Tile tile)
        {
            if (tile.GetPieceAtTile(tile) != null)
                return false;
            return true;
        }

        public void PlacePieceAtTile(Tile tile, Piece piece)
        {
            _tiles[tile.Rank, tile.File] = piece;
        }

        public void FreshBoard()
        {
            for (int file = 0; file < 8; file++)
            {
                for (int rank = 0; rank < 8; rank++)
                {
                    PlacePieceAtTile(_tiles[rank, 2], new Piece(PieceType.Pawn, true));
                    PlacePieceAtTile(_tiles[rank, 7], new Piece(PieceType.Pawn, false));
                }
            }
        }

    }
}