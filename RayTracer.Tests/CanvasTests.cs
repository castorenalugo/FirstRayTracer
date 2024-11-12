using System;
using System.Linq;
using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class CanvasTests
{
    
    //Writing pixels to a canvas
    [TestMethod]
    public void Canvas_ShouldSetPixel_Properly()
    {
        //Arrange
        var c = new Canvas(10, 20);
        var red = new Color(1.0f, 0.0f, 0.0f);
        
        //Act
        c.SetPixel(2, 3, red);
        var result = c.GetPixel(2, 3);
        
        //Assert
        Assert.IsTrue(red.Equals(result));
    }
    
    //Constructing the PPM pixel data
    [TestMethod]
    public void Canvas_ShouldConstructPixelData_Properly()
    {
        //Arrange
        var c = new Canvas(5, 3);
        var c1 = new Color(1.5f, 0.0f, 0.0f);
        var c2 = new Color(0.0f, 0.5f, 0.0f);
        var c3 = new Color(-0.5f, 0.0f, 1.0f);
        var expected = 
            """
            P3
            5 3
            255
            255 0 0 0 0 0 0 0 0 0 0 0 0 0 0
            0 0 0 0 0 0 0 127 0 0 0 0 0 0 0
            0 0 0 0 0 0 0 0 0 0 0 0 0 0 255
            """;
        
        //Act
        c.SetPixel(0, 0, c1);
        c.SetPixel(2, 1, c2);
        c.SetPixel(4, 2, c3);
        var ppm = c.GetFileContent();
        
        //Assert
        Assert.AreEqual(expected, ppm);
    }
    
    //[TestMethod]
    public void CanvasFile_ShouldNotExceed70CharacterPerLine()
    {
        //Arrange
        var color = new Color(1.0f, 0.8f, 0.6f);
        var c = new Canvas(10, 2, color);
        var expected = 
            """
            P3
            10 2
            255
            255 204 153 255 204 153 255 204 153 255 204 153 255 204 153 255 204
            153 255 204 153 255 204 153 255 204 153 255 204 153
            255 204 153 255 204 153 255 204 153 255 204 153 255 204 153 255 204
            153 255 204 153 255 204 153 255 204 153 255 204 153
            """;
        
        //Act
        var ppm = c.GetFileContent();
        
        //Assert
        Assert.AreEqual(expected, ppm);
    }
    
}