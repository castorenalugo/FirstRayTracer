using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class PointTests
{
    //Subtracting a vector from a point
    [TestMethod]
    public void SubtractVector_Returns_Point()
    {
        //Arrange
        var p = new Point(3.0f, 2.0f, 1.0f);
        var v = new Vector(5.0f, 6.0f, 7.0f);
        
        var expected = new Point(-2, -4, -6);

        var result = p - v;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Subtracting two points
    [TestMethod]
    public void ShouldSubtractTwoPoints_Properly()
    {
        //Arrange
        var p1 = new Point(3.0f, 2.0f, 1.0f);
        var p2 = new Point(5.0f, 6.0f, 7.0f);
        
        var expected = new Vector(-2, -4, -6);

        var result = p1 - p2;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Adding two tuples
    [TestMethod]
    public void AddingVector_ReturnsPoint()
    {
        //Arrange
        var point = new Point(1.1f, 2.1f, 3.1f);
        var vector = new Vector(1.1f, 2.1f, 3.1f);
        
        var expected = new Point(2.2f, 4.2f, 6.2f);

        var sum = point + vector;
        
        //Assert
        Assert.IsTrue(expected.Equals(sum));
    }
}