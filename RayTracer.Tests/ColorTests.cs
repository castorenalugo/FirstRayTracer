using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class ColorTests
{
    
    //Colors are (red, green, blue) tuples
    [TestMethod]
    public void ShouldSetValues_Properly()
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
    
    //Adding colors
    [TestMethod]
    public void ShouldAddValues_Properly()
    {
        //Arrange
        var c1 = new Color(0.9f, 0.6f, 0.75f);
        var c2 = new Color(0.7f, 0.1f, 0.25f);
        var expected = new Color(1.6f, 0.7f, 1.0f);
        
        //Act
        var result = c1 + c2;

        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Subtract colors
    [TestMethod]
    public void ShouldSubtractValues_Properly()
    {
        //Arrange
        var c1 = new Color(0.9f, 0.6f, 0.75f);
        var c2 = new Color(0.7f, 0.1f, 0.25f);
        var expected = new Color(1.6f, 0.7f, 1.0f);
        
        //Act
        var result = new Color(1.6f, 0.7f, 1.0f);

        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Multiplying a color by a scalar
    [TestMethod]
    public void ShouldMultiplyValues_Properly()
    {
        //Arrange
        var c = new Color(0.2f, 0.3f, 0.4f);
        var expected = new Color(0.4f, 0.6f, 0.8f);
        
        //Act
        c = c * 2.0f;
        
        //Assert
        Assert.IsTrue(expected.Equals(c));
    }
    
    //Multiplying colors
    [TestMethod]
    public void ShouldMultiplyWithOther_Properly()
    {
        //Arrange
        var c1 = new Color(1.0f, 0.2f, 0.4f);
        var c2 = new Color(0.9f, 1.0f, 0.1f);
        var expected = new Color(0.9f, 0.2f, 0.04f);
        
        //Act
        var result = c1 * c2;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Multiplying a tuple by a scalar
    [TestMethod]
    public void ShouldMultiplyByAScalar_Properly()
    {
        //Arrange
        var a = new Color(1.0f, -2.0f, 3.0f);
        
        var expected = new Color(3.5f, -7.0f, 10.5f);

        var result = a * 3.5f;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    [TestMethod]
    public void ShouldMultiplyFractions_Properly()
    {
        //Arrange
        var a = new Color(1.0f, -2.0f, 3.0f);
        
        var expected = new Color(0.5f, -1.0f, 1.5f);

        a = a * 0.5f;
        
        //Assert
        Assert.IsTrue(expected.Equals(a));
    }
    
    //Dividing a tuple by a scalar
    [TestMethod]
    public void ShouldDivide_Properly()
    {
        //Arrange
        var a = new Color(1.0f, -2.0f, 3.0f);
        
        var expected = new Color(0.5f, -1.0f, 1.5f);

        a = a / 2.0f;
        
        //Assert
        Assert.IsTrue(expected.Equals(a));
    }
}