using System;

namespace RayTracer.Models;

public class MyTuple
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float W { get; set; }

    public MyTuple(float x, float y, float z, float w)
    {
        X = x;
        Y = y;
        Z = z;
        W = w;
    }

    public void Multiply(float scalarValue)
    {
        X *= scalarValue;
        Y *= scalarValue;
        Z *= scalarValue;
        W *= scalarValue;
    }
    
    public void Divide(float scalarValue)
    {
        X = X == 0 ? 0 : X / scalarValue;
        Y = Y == 0 ? 0 : Y / scalarValue;
        Z = Z == 0 ? 0 : Z / scalarValue;
        W = W == 0 ? 0 : W / scalarValue;
    }

    public bool IsAPoint => W.EqualsTo(1);
    public bool IsAVector => W.EqualsTo(0);
    
    public static MyTuple operator +(MyTuple a, MyTuple b) => new (a.X+b.X, a.Y+b.Y, a.Z+b.Z, a.W+b.W );
    
    public static MyTuple operator -(MyTuple a, MyTuple b) => new (a.X-b.X, a.Y-b.Y, a.Z-b.Z, Math.Abs(a.W-b.W) );
    
    public static MyTuple operator -(MyTuple a) => new (-a.X, -a.Y, -a.Z, -a.W);
    
    public override bool Equals(object obj)
    {
        var tuple = obj as MyTuple;

        if (tuple == null)
            return false;

        return X.EqualsTo(tuple.X) && Y.EqualsTo(tuple.Y) && Z.EqualsTo(tuple.Z) && W.EqualsTo(tuple.W);
    }
    
    public override int GetHashCode() => (X, Y, Z).GetHashCode();
}