using RayTracer.Models;
using RayTracer.ProjectileExercise;

namespace RayTracer;

static class Program
{
    public static void Main(string[] args)
    {
        var startingPoint = new Point(0.0f, 1.0f, 0.0f);
        var startingVelocity = new Vector(2.0f, 1.5f, 0.0f);
        startingVelocity = startingVelocity.GetNormalized();
        startingVelocity *= 11.25f;
        
        var projectile = new Projectile(startingPoint, startingVelocity);

        var gravity = new Vector(0.0f, -0.07f, 0.0f);
        var wind = new Vector(-0.05f, 0.0f, 0.0f);
        var environment = new Environment(gravity, wind);

        var c = new Canvas(900, 550, new Color());
        var red = new Color(1.0f, 0.0f, 0.0f);

        while (projectile.Position.Y > 0)
        {
            c.SetPixel((int)projectile.Position.X, (int)projectile.Position.Y, red);
            projectile = Tick(environment, projectile);
        }
        
        c.GetFile("prueba.ppm");
    }

    private static Projectile Tick(Environment env, Projectile proj)
    {
        var position = proj.Position + proj.Velocity;
        var velocity = proj.Velocity + env.Gravity + env.Wind;
        return new Projectile(position, velocity);
    }
}