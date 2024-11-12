using System;

namespace RayTracer.Models;

public class Color : TupleBase
{
    public Color(float red, float green, float blue)
        : base(red, green, blue, 1.0f) { }

    public float Red { get => Value1; set => Value1 = value; }

    public float Green { get => Value2; set => Value2 = value; }

    public float Blue { get => Value3; set => Value3 = value; }
}