using RayTracer.Models;

namespace RayTracer.ProjectileExercise;

public class Environment
{
    public Vector Gravity { get; set; }
    public Vector Wind { get; set; }

    public Environment(Vector gravity, Vector wind)
    {
        Gravity = gravity;
        Wind = wind;
    }
}