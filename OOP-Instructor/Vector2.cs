struct Vector2
{
    public int X, Y;

    public static readonly Vector2 Zero = new Vector2(0, 0);

    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);
    }

    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X - b.X, a.Y - b.Y);
    }

    public static bool operator ==(Vector2 a, Vector2 b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Vector2 a, Vector2 b)
    {
        return (a == b) == false;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}