namespace classlib;

public struct Position
{
    public int Row;
    public int Col;

    public Position(int row, int col)
    {
        Row = row;
        Col = col;
    }

    public bool IsValid()
    {
        return Row >= 0 && Row < 8 && Col >= 0 && Col < 8;
    }

    public static Position FromAlgebraic(string notation)
    {
        int col = notation[0] - 'a';
        int row = notation[1] - '1';
        return new Position(row, col);
    }

    public string ToAlgebraic()
    {
        return "" + (char)('a' + Col) + (Row + 1);
    }

    public override string ToString()
    {
        return ToAlgebraic();
    }
}