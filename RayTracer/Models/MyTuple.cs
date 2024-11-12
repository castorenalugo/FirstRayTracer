using System;

namespace RayTracer.Models;

public class MyTuple : TupleBase
{
    public MyTuple(float x, float y, float z, float w) : base(x, y, z, w) { }

    public float X { get => Value1; set => Value1 = value; }
    public float Y { get => Value2; set => Value2 = value; }
    public float Z { get => Value3; set => Value3 = value; }
    public float W { get => Value4; set => Value4 = value; }
}