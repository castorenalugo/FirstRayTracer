using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class MyTupleTests
{
    [DataTestMethod]
    [DataRow(1.0f, true)]
    [DataRow(1.00001f, true)]
    [DataRow(1.00009f, true)]
    [DataRow(1.0001f, false)]
    [DataRow(1.1f, false)]
    [DataRow(2f, false)]
    public void Tuple_IsAPoint(float w, bool isAPoint)
    {
        //Arrange
        var tuple = new MyTuple(4.3f, -4.2f, 3.1f, w);

        var point = new Point(4.3f, -4.2f, 3.1f);
        
        //Assert
        Assert.AreEqual(isAPoint, point.Equals(tuple));
    }
    
    [DataTestMethod]
    [DataRow(0.0f, true)]
    [DataRow(0.00001f, true)]
    [DataRow(0.00009f, true)]
    [DataRow(0.0001f, false)]
    [DataRow(0.1f, false)]
    [DataRow(1f, false)]
    public void Tuple_IsAVector(float w, bool isAVector)
    {
        //Arrange
        var tuple = new MyTuple(4.3f, -4.2f, 3.1f, w);
        var vector = new Vector(4.3f, -4.2f, 3.1f);
        
        //Assert
        Assert.AreEqual(isAVector, vector.Equals(tuple));
    }
    
    //Adding two tuples
    [TestMethod]
    public void Tuple_ShouldSum_Properly()
    {
        //Arrange
        var point = new Point(1.1f, 2.1f, 3.1f);
        var vector = new Vector(1.1f, 2.1f, 3.1f);
        
        var expected = new MyTuple(2.2f, 4.2f, 6.2f, 1.0f);

        var sum = point + vector;
        
        //Assert
        Assert.IsTrue(expected.Equals(sum));
    }
    
    //Subtracting two points
    [TestMethod]
    public void Tuple_ShouldSubtrackTwoPoints_Properly()
    {
        //Arrange
        var p1 = new Point(3.0f, 2.0f, 1.0f);
        var p2 = new Point(5.0f, 6.0f, 7.0f);
        
        var expected = new Vector(-2, -4, -6);

        var result = p1 - p2;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }

    //Subtracting a vector from a point
    [TestMethod]
    public void Tuple_ShouldSubtrackAVectorFromAPoint_Properly()
    {
        //Arrange
        var p = new Point(3.0f, 2.0f, 1.0f);
        var v = new Vector(5.0f, 6.0f, 7.0f);
        
        var expected = new Point(-2, -4, -6);

        var result = p - v;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Subtracting two vectors
    [TestMethod]
    public void Tuple_ShouldSubtrackTwoVectors_Properly()
    {
        //Arrange
        var v1 = new Vector(3.0f, 2.0f, 1.0f);
        var v2 = new Vector(5.0f, 6.0f, 7.0f);
        
        var expected = new Vector(-2, -4, -6);

        var result = v1 - v2;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Negating a tuple
    [TestMethod]
    public void Tuple_ShouldBeNegated_Properly()
    {
        //Arrange
        var a = new MyTuple(1.0f, -2.0f, 3.0f, -4.0f);
        
        var expected = new MyTuple(-1.0f, 2.0f, -3.0f, 4.0f);

        var result = -a;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Multiplying a tuple by a scalar
    [TestMethod]
    public void Tuple_ShouldMultiply_Properly()
    {
        //Arrange
        var a = new MyTuple(1.0f, -2.0f, 3.0f, -4.0f);
        
        var expected = new MyTuple(3.5f, -7.0f, 10.5f, -14.0f);

        a.Multiply(3.5f);
        
        //Assert
        Assert.IsTrue(expected.Equals(a));
    }

    //Multiplying a tuple by a fraction
    [TestMethod]
    public void Tuple_ShouldMultiplyFractions_Properly()
    {
        //Arrange
        var a = new MyTuple(1.0f, -2.0f, 3.0f, -4.0f);
        
        var expected = new MyTuple(0.5f, -1.0f, 1.5f, -2.0f);

        a.Multiply(0.5f);
        
        //Assert
        Assert.IsTrue(expected.Equals(a));
    }
    
    //Dividing a tuple by a scalar
    [TestMethod]
    public void Tuple_ShouldDivide_Properly()
    {
        //Arrange
        var a = new MyTuple(1.0f, -2.0f, 3.0f, -4.0f);
        
        var expected = new MyTuple(0.5f, -1.0f, 1.5f, -2.0f);

        a.Divide(2f);
        
        //Assert
        Assert.IsTrue(expected.Equals(a));
    }
}