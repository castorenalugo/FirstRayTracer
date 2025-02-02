using System;
using System.IO;
using System.Text;

namespace RayTracer.Models;

public readonly struct Canvas
{
    private readonly Color[,] _pixels;
    private readonly int _width;
    private readonly int _height;

    public Canvas(int width, int height, Color color)
    {
        _width = width;
        _height = height;

        _pixels = new Color[width,height];
        
        for (var x = 0; x < width; x++)
            for (var y = 0; y < height; y++)
                _pixels[x,y] = color;
    }

    public Color GetPixel(int x, int y) => _pixels[x,y];

    public void SetPixel(int x, int y, Color color)
    {
        if (x >= 0 && x < _width && y >= 0 && y < _height)
            _pixels[x,y] = color;
    }


    public string GetFileContent()
    {
        var sb = new StringBuilder();
        sb.Append($"""
                   P3
                   {_width} {_height}
                   255

                   """);
        var currentLineLength = 0;
        const int maxLineLength = 70;
        const int margin = 20;

        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < _width; x++)
            {
                var pixel = _pixels[x,y].ToString();
                sb.Append(pixel);
                currentLineLength += pixel.Length;

                if (currentLineLength + margin >= maxLineLength)
                {
                    sb.Append("\r\n");
                    currentLineLength = 0;
                }
                else
                {
                    sb.Append(' ');
                    currentLineLength += 1;
                }
            }
        }
        return sb.ToString();
    }

    public void GetFile(string filePath)
    {
        filePath ??= "output.ppm";

        var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        filePath = Path.Combine(rootDirectory, filePath);

        File.WriteAllText(filePath, GetFileContent());

        Console.WriteLine("Finished creating file: " + filePath);
    }
}
