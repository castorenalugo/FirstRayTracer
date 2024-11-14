using System;

namespace RayTracer.Models;

public class Color : TupleBase
{
    public float Red { get => Value1; set => Value1 = value; }
    public float Green { get => Value2; set => Value2 = value; }
    public float Blue { get => Value3; set => Value3 = value; }

    private string _red;
    private string _green;
    private string _blue;
    
    public Color(float red, float green, float blue) : base(red, green, blue, 0.0f)
    {
        _red = ((int)(Math.Clamp(red * 255, 0, 255))).ToString();
        _green = ((int)(Math.Clamp(green * 255, 0, 255))).ToString();
        _blue = ((int)(Math.Clamp(blue * 255, 0, 255))).ToString();
    }
    
    public static Color operator +(Color a, Color b)
        => new Color(a.Value1 + b.Value1, a.Value2 + b.Value2, a.Value3 + b.Value3);

    public static Color operator -(Color a, Color b)
        => new Color(a.Value1 - b.Value1, a.Value2 - b.Value2, a.Value3 - b.Value3);

    public static Color operator *(Color a, Color b)
        => new Color(a.Value1 * b.Value1, a.Value2 * b.Value2, a.Value3 * b.Value3);

    public static Color operator -(Color a)
        => new Color(-a.Value1, -a.Value2, -a.Value3);
    

    
    public string ToScaledIntStrings() => $"{_red} {_green} {_blue}";
}