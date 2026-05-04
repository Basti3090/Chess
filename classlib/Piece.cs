namespace classlib;

public enum PieceType { Pawn, Knight, Bishop, Rook, Queen, King }
public enum PieceColor { White, Black }

public class Piece
{
    public PieceType Type { get; set; }
    public PieceColor Color { get; set; }

    public Piece(PieceType type, PieceColor color)
    {
        Type = type;
        Color = color;
    }

    public override string ToString()
    {
        string symbol = Type switch
        {
            PieceType.King   => "K",
            PieceType.Queen  => "Q",
            PieceType.Rook   => "R",
            PieceType.Bishop => "B",
            PieceType.Knight => "N",
            PieceType.Pawn   => "P",
            _ => "?"
        };
        return Color == PieceColor.White ? symbol : symbol.ToLower();
    }
}