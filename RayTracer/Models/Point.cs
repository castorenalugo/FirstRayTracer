namespace RayTracer.Models;

public class Point : MyTuple
{
    
    public Point(float x, float y, float z) : base(x, y, z, 1.0f)
    {
        X = x;
        Y = y;
        Z = z;
    }
}