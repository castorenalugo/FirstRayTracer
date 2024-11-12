using System;

namespace RayTracer.Models;

public class MyTuple : TupleBase
{
    public MyTuple(float x, float y, float z, float w) : base(x, y, z, w)
    { }

    public float X
    {
        get => Values.Item1;
        set => SetItem1(value);
    }

    public float Y
    {
        get => Values.Item2;
        set => SetItem2(value);
    }

    public float Z
    {
        get => Values.Item3;
        set => SetItem3(value);
    }

    public float W
    {
        get => Values.Item4;
        set => SetItem4(value);
    }
}
