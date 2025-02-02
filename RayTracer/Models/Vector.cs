using System;

namespace RayTracer.Models;

public readonly struct Vector
{
    public readonly float X;
    public readonly float Y;
    public readonly float Z;

    public readonly float Magnitude;
    
    public Vector(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;

        Magnitude = (float)Math.Sqrt(Square(X) + Square(Y) + Square(Z));
    }
    
    public Vector GetNormalized()
    {
        if (Magnitude == 0) 
            return this;

        var x = X / Magnitude;
        var y = Y / Magnitude;
        var z = Z / Magnitude;

        return new Vector(x, y, z);
    }

    public float GetDotProduct(Vector v) => (X * v.X) + (Y * v.Y) + (Z * v.Z) ;

    public Vector GetCrossProduct(Vector v)
    {
        var x = Y * v.Z - Z * v.Y;
        var y = Z * v.X - X * v.Z;
        var z = X * v.Y - Y * v.X;

        return new Vector(x, y, z);
    }
    
    private float Square(float value) => value * value;
    
    public static Vector operator +(Vector a, Vector b)
        => new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static Vector operator -(Vector a, Vector b)
        => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector operator *(Vector a, Vector b)
        => new Vector(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

    public static Vector operator -(Vector a)
        => new Vector(-a.X, -a.Y, -a.Z);
    
    public static Vector operator *(Vector a, float scalarValue)
        => new Vector(a.X * scalarValue, a.Y * scalarValue, a.Z * scalarValue);
}