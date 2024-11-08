using System;

namespace RayTracer;

public class MyTuple
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float W { get; set; }

    public bool IsAPoint => Math.Abs(W - 1) < Values.Epsilon;
    public bool IsAVector => Math.Abs(W) < Values.Epsilon;
}