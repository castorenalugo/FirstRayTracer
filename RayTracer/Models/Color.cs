using System;

namespace RayTracer.Models;

public readonly struct Color
{
    public readonly float Red;
    public readonly float Green;
    public readonly float Blue;

    private readonly string _value;
    
    public Color(float red, float green, float blue)
    {
        Red = red;
        Green = green;
        Blue = blue;

        var r = (int)Math.Clamp(red * 255, 0, 255);
        var g = (int)Math.Clamp(green * 255, 0, 255);
        var b = (int)Math.Clamp(blue * 255, 0, 255);

        _value = $"{r} {g} {b}";
    }

    public Color() : this(0.0f, 0.0f, 0.0f)
    {
        
    }
    
    public Color GetMultipied(float scalarValue)
    {
        return new Color(Red * scalarValue, Green * scalarValue, Blue * scalarValue);
    }
    
    public static Color operator +(Color a, Color b)
        => new Color(a.Red + b.Red, a.Green + b.Green, a.Blue + b.Blue);

    public static Color operator -(Color a, Color b)
        => new Color(a.Red - b.Red, a.Green - b.Green, a.Blue - b.Blue);

    public static Color operator *(Color a, Color b)
        => new Color(a.Red * b.Red, a.Green * b.Green, a.Blue * b.Blue);

    public static Color operator -(Color a)
        => new Color(-a.Red, -a.Green, -a.Blue);


    public override string ToString()
    {
        return _value;
    }
}