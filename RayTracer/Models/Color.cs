using System;

namespace RayTracer.Models;

public class Color : TupleBase
{
    public Color(float red, float green, float blue)
        : base(red, green, blue, 0.0f) { }

    public float Red { get => Value1; set => Value1 = value; }

    public float Green { get => Value2; set => Value2 = value; }

    public float Blue { get => Value3; set => Value3 = value; }
    
    public (string red, string green, string blue) ToScaledIntStrings()
    {
        var r = (int)(Math.Clamp(Red * 255, 0, 255));
        var g = (int)(Math.Clamp(Green * 255, 0, 255));
        var b = (int)(Math.Clamp(Blue * 255, 0, 255));

        return (r.ToString(), g.ToString(), b.ToString());
    }
}