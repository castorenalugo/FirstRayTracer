

namespace RayTracer.Models;

public readonly struct Point
{
    public readonly float X;
    public readonly float Y;
    public readonly float Z;
    
    public Point(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public static Point operator +(Point a, Point b)
        => new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    
    public static Point operator *(Point a, Point b)
        => new Point(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

    public static Point operator -(Point a)
        => new Point(-a.X, -a.Y, -a.Z);
    
    public static Point operator +(Point a, Vector b)
        => new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    
    public static Point operator -(Point a, Vector b)
        => new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector operator -(Point a, Point b)
        => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    
    public bool Equals(Point v)
    {
        return X.EqualsTo(v.X) && Y.EqualsTo(v.Y) && Z.EqualsTo(v.Z);
    }
    
    public override int GetHashCode() => (X, Y, Z).GetHashCode();
}