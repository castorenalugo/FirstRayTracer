using System;

namespace RayTracer.Models;

public class Vector : MyTuple
{
    public Vector(float x, float y, float z) : base(x, y, z, 0.0f)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Normalize()
    {
        // Calculate magnitude once and store it in a local variable
        var magnitude = Magnitude;

        // Avoid division by zero
        if (magnitude == 0) 
            return;
        
        X = X / magnitude;
        Y = Y / magnitude;
        Z = Z / magnitude;
        W = W / magnitude;
    }

    public float GetDotProduct(Vector v) => (X * v.X) + (Y * v.Y) + (Z * v.Z) + (W * v.W);

    public Vector GetCrossProduct(Vector v)
    {
        var x = Y * v.Z - Z * v.Y;
        var y = Z * v.X - X * v.Z;
        var z = X * v.Y - Y * v.X;

        return new Vector(x, y, z);
    }
    
    public float Magnitude => (float)Math.Sqrt(Square(X) + Square(Y) + Square(Z) + Square(W));

    private float Square(float value) => value * value;
}