namespace RayTracer.Models;

public class Vector : MyTuple
{
    public Vector(float x, float y, float z) : base(x, y, z, 0.0f)
    {
        X = x;
        Y = y;
        Z = z;
    }
}