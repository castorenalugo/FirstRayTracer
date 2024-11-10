using System;

namespace RayTracer;

public static class Helpers
{
    private static float Epsilon = 0.0001f;
    
    public static bool EqualsTo(this float a, float b)
    {
        return Math.Abs(a - b) < Epsilon;
    }
}