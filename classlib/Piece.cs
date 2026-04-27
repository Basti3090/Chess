namespace classlib;

public class Piece
{
    public PieceType Type { get; }
    public PieceColor Color { get; }

    public Piece(PieceType type, PieceColor color)
    {
        Type = type;
        Color = color;
    }

    public char ToSymbol() => (Type, Color) switch
    {
        (PieceType.King,   PieceColor.White) => '♔',
        (PieceType.Queen,  PieceColor.White) => '♕',
        (PieceType.Rook,   PieceColor.White) => '♖',
        (PieceType.Bishop, PieceColor.White) => '♗',
        (PieceType.Knight, PieceColor.White) => '♘',
        (PieceType.Pawn,   PieceColor.White) => '♙',
        (PieceType.King,   PieceColor.Black) => '♚',
        (PieceType.Queen,  PieceColor.Black) => '♛',
        (PieceType.Rook,   PieceColor.Black) => '♜',
        (PieceType.Bishop, PieceColor.Black) => '♝',
        (PieceType.Knight, PieceColor.Black) => '♞',
        (PieceType.Pawn,   PieceColor.Black) => '♟',
        _ => '.'
    };

    public char ToAscii() => (Type, Color) switch
    {
        (PieceType.King,   PieceColor.White) => 'K',
        (PieceType.Queen,  PieceColor.White) => 'Q',
        (PieceType.Rook,   PieceColor.White) => 'R',
        (PieceType.Bishop, PieceColor.White) => 'B',
        (PieceType.Knight, PieceColor.White) => 'N',
        (PieceType.Pawn,   PieceColor.White) => 'P',
        (PieceType.King,   PieceColor.Black) => 'k',
        (PieceType.Queen,  PieceColor.Black) => 'q',
        (PieceType.Rook,   PieceColor.Black) => 'r',
        (PieceType.Bishop, PieceColor.Black) => 'b',
        (PieceType.Knight, PieceColor.Black) => 'n',
        (PieceType.Pawn,   PieceColor.Black) => 'p',
        _ => '.'
    };

    public override string ToString() => $"{Color} {Type}";
}
