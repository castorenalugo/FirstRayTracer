using System;

namespace RayTracer.Models;

public readonly record struct Color
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
    
    public static Color operator +(Color a, Color b)
        => new Color(a.Red + b.Red, a.Green + b.Green, a.Blue + b.Blue);

    public static Color operator -(Color a, Color b)
        => new Color(a.Red - b.Red, a.Green - b.Green, a.Blue - b.Blue);

    public static Color operator *(Color a, Color b)
        => new Color(a.Red * b.Red, a.Green * b.Green, a.Blue * b.Blue);
    
    public static Color operator *(Color a, float b)
        => new Color(a.Red * b, a.Green * b, a.Blue * b);

    public static Color operator /(Color a, float b)
    {
        var red = a.Red == 0 ? 0 : a.Red / b;
        var green = a.Green == 0 ? 0 : a.Green / b;
        var blue = a.Blue == 0 ? 0 : a.Blue / b;

        return new Color(red, green, blue);
    }
    
    public static Color operator -(Color a)
        => new Color(-a.Red, -a.Green, -a.Blue);


    public override string ToString()
    {
        return _value;
    }
    
    public bool Equals(Color c)
    {
        return Red.EqualsTo(c.Red) && Green.EqualsTo(c.Green) && Blue.EqualsTo(c.Blue);
    }
    
    public override int GetHashCode() => (Red, Green, Blue).GetHashCode();
}