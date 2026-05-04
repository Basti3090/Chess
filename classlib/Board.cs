namespace classlib;

public class Board
{
    private Piece?[,] _fields = new Piece?[8, 8];

    public Board()
    {
        Setup();
    }

    public Piece? GetPiece(int row, int col) => _fields[row, col];
    public void SetPiece(int row, int col, Piece? piece) => _fields[row, col] = piece;

    private void Setup()
    {
        //Weiße Bauern
        for (int col = 0; col < 8; col++)
            _fields[1, col] = new Piece(PieceType.Pawn, PieceColor.White);

        //Schwarze Bauern
        for (int col = 0; col < 8; col++)
            _fields[6, col] = new Piece(PieceType.Pawn, PieceColor.Black);

        // Weiße Grundlinie (Reihe 0)
        _fields[0, 0] = new Piece(PieceType.Rook,   PieceColor.White);
        _fields[0, 1] = new Piece(PieceType.Knight, PieceColor.White);
        _fields[0, 2] = new Piece(PieceType.Bishop, PieceColor.White);
        _fields[0, 3] = new Piece(PieceType.Queen,  PieceColor.White);
        _fields[0, 4] = new Piece(PieceType.King,   PieceColor.White);
        _fields[0, 5] = new Piece(PieceType.Bishop, PieceColor.White);
        _fields[0, 6] = new Piece(PieceType.Knight, PieceColor.White);
        _fields[0, 7] = new Piece(PieceType.Rook,   PieceColor.White);

        // Schwarze Grundlinie (Reihe 7)
        _fields[7, 0] = new Piece(PieceType.Rook,   PieceColor.Black);
        _fields[7, 1] = new Piece(PieceType.Knight, PieceColor.Black);
        _fields[7, 2] = new Piece(PieceType.Bishop, PieceColor.Black);
        _fields[7, 3] = new Piece(PieceType.Queen,  PieceColor.Black);
        _fields[7, 4] = new Piece(PieceType.King,   PieceColor.Black);
        _fields[7, 5] = new Piece(PieceType.Bishop, PieceColor.Black);
        _fields[7, 6] = new Piece(PieceType.Knight, PieceColor.Black);
        _fields[7, 7] = new Piece(PieceType.Rook,   PieceColor.Black);
    }

    // Zug ausführen 
    public void Move(int fromRow, int fromCol, int toRow, int toCol)
    {
        _fields[toRow, toCol] = _fields[fromRow, fromCol];
        _fields[fromRow, fromCol] = null;
    }

    // Brett als Text ausgeben
    public void Print()
    {
        Console.WriteLine("  a b c d e f g h");
        for (int row = 7; row >= 0; row--)
        {
            Console.Write($"{row + 1} ");
            for (int col = 0; col < 8; col++)
            {
                var piece = _fields[row, col];
                Console.Write(piece == null ? ". " : $"{piece} ");
            }
            Console.WriteLine($"{row + 1}");
        }
        Console.WriteLine("  a b c d e f g h");
    }
}
