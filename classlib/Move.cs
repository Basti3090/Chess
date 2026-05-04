namespace classlib;

public class Move {
    public Position From {get;}
    public Position To {get;}
    public PieceType? Promotion {get;}
    public bool IsCastling {get; init;}
    public bool IsEnPassant {get; init;}

    public Move (Position from, Position to, PieceType? promotion = null) {
        From = from;
        To = to;
        Promotion =promotion;
    }

    public override string ToString() {
        string s = $"{From}{To}";
        if (Promotion.HasValue)
        s += Promotion.Value.ToString()[0].ToString().ToLower();
        return s;
    }
}