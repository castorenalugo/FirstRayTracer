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