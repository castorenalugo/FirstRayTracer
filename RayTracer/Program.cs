using System;
using RayTracer.Models;
using Environment = RayTracer.Models.Environment;

namespace RayTracer;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var startingPoint = new Point(0.0f, 1.0f, 0.0f);
        var startingVelocity = new Vector(1.0f, 1.0f, 0.0f);
        startingVelocity.Normalize();
        var p = new Projectile(startingPoint, startingVelocity);

        var gravity = new Vector(0.0f, -0.1f, 0.0f);
        var wind = new Vector(-0.1f, 0.0f, 0.0f);
        var environment = new Environment(gravity, wind);

        while (p.Position.Y > 0)
        {
            p = Tick(environment, p);
        }
    }

    private static Projectile Tick(Environment env, Projectile proj)
    {
        var position = (Point)(proj.Position + proj.Velocity);
        var velocity = (Vector)(proj.Velocity + env.Gravity + env.Wind);
        return new Projectile(position, velocity);
    }
}