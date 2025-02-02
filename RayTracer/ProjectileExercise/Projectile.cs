using System;
using RayTracer.Models;

namespace RayTracer.ProjectileExercise;

public struct Projectile
{
    public Point Position { get; set; }
    public Vector Velocity { get; set; }

    public Projectile(Point position, Vector velocity)
    {
        Position = position;
        Velocity = velocity;
    }
    
    
    public void PrintPosition()
    {
        Console.WriteLine($"X:{Position.X}       Y:{Position.Y}       Z:{Position.Z}\n");
    }
}