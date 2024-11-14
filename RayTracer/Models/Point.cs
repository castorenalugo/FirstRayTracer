using System;

namespace RayTracer.Models;

public class Point : MyTuple
{
    public Point(float x, float y, float z) : base(x, y, z, 1.0f)
    {
        
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
}