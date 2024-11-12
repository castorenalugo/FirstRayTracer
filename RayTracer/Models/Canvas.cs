using System;

namespace RayTracer.Models;

public class Canvas
{
    private readonly Color[][] _pixels;
    private readonly int _width;
    private readonly int _height;

    public Canvas(int width, int height, Color color = null)
    {
        _width = width;
        _height = height;
        color ??= new Color(0.0f, 0.0f, 0.0f);

        _pixels = new Color[width][];

        for (var i = 0; i < width; i++)
            _pixels[i] = new Color[height];

        for (var x = 0; x < width; x++)
            for (var y = 0; y < height; y++)
                _pixels[x][y] = color;
    }

    public Color GetPixel(int x, int y) => _pixels[x][y];

    public void SetPixel(int x, int y, Color color) => _pixels[x][y] = color;

    public string GetFileContent()
    {
        var result =
            $"""
             P3
             {_width} {_height}
             255
             
             """;
        
        var currentLineLength = 0;
        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < _width; x++)
            {
                var (r, g, b) = _pixels[x][y].ToScaledIntStrings();
                AddColorToLine(ref currentLineLength, ref result, r);
                AddColorToLine(ref currentLineLength, ref result, g);
                AddColorToLine(ref currentLineLength, ref result, b);
            }
        }

        result = result.Substring(0, result.Length);
        return result;
    }
    
    private void AddColorToLine(ref int currentLineLength, ref string result, string colorValue)
    {
        if (currentLineLength + 20 >= 70)
        {
            result = result.Substring(0, result.Length - 1);
            result += "\r\n";
            currentLineLength = 0;
        }
        result += colorValue + " ";
        currentLineLength += colorValue.Length + 1;
    }
}
