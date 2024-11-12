namespace RayTracer.Models;

public class Color : TupleBase
{
    public Color(float red, float green, float blue)
        : base(red, green, blue, 1.0f)
    {
        
    }
    
    public float Red
    {
        get => Values.Item1;
        set => SetItem1(value);
    }

    public float Green
    {
        get => Values.Item2;
        set => SetItem2(value);
    }
    
    public float Blue
    {
        get => Values.Item3;
        set => SetItem3(value);
    }
}