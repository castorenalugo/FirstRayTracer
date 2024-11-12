using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class ColorTests
{
    
    //Colors are (red, green, blue) tuples
    [TestMethod]
    public void Color_ShouldSetValues_Properly()
    {
        //Arrange
        const float red = -0.5f;
        const float green = -0.5f;
        const float blue = -0.5f;
        
        var color = new Color(red, green, blue);
        
        //Assert
        Assert.AreEqual(red, color.Red);
        Assert.AreEqual(green, color.Green);
        Assert.AreEqual(blue, color.Blue);
    }
    
}