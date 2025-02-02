using RayTracer.Models;

namespace RayTracer.Tests;

//[TestClass]
public class VectorTests
{
    //vector() creates tuples with w=0
    [TestMethod]
    public void Vector_ShouldSetW_Properly()
    {
        //Arrange
        var vector = new Vector(1.1f, 2.1f, 3.1f);
        
        var expected = new MyTuple(1.1f, 2.1f, 3.1f, 0.0f);
        
        //Assert
        Assert.IsTrue(expected.Equals(vector));
    }
    
    //Negating a tuple
    [TestMethod]
    public void Vector_ShouldBeNegated_Properly()
    {
        //Arrange
        var v = new Vector(1.0f, -2.0f, 3.0f);
        
        var expected = new Vector(-1.0f, 2.0f, -3.0f);

        var result = -v;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
    
    //Computing the magnitude of vectors
    [DataTestMethod]
    [DataRow(1.0f, 0.0f, 0.0f, 1.0f)]
    [DataRow(0.0f, 1.0f, 0.0f, 1.0f)]
    [DataRow(0.0f, 0.0f, 1.0f, 1.0f)]
    [DataRow(1.0f, 2.0f, 3.0f, 3.741657386f)]
    [DataRow(-1.0f, -2.0f, -3.0f, 3.741657386f)]
    public void Vector_ShouldComputeMagnitude_Properly(float x, float y, float z, float magnitude)
    {
        //Arrange
        var vector = new Vector(x, y, z);
        
        //Assert
        Assert.IsTrue(magnitude.Equals(vector.Magnitude));
    }
    
    //Normalizing a vector
    [DataTestMethod]
    [DataRow(4.0f, 0.0f, 0.0f,  1.0f, 0.0f, 0.0f)]
    [DataRow(1.0f, 2.0f, 3.0f,  0.26726f, 0.53452f, 0.80178f)]
    public void Vector_ShouldNormalizeItself_Properly(float vX, float vY, float vZ,
        float expectedX, float expectedY, float expectedZ)
    {
        //Arrange
        var vector = new Vector(vX, vY, vZ);
        var expectedNormalizedVector = new Vector(expectedX, expectedY, expectedZ);
        
        //Act
        var normalizedVector = vector.GetNormalized();
        
        //Assert
        Assert.IsTrue(expectedNormalizedVector.Equals(normalizedVector));
    }
    
    //The dot product of two tuples
    [DataTestMethod]
    public void Vector_ShouldGetDotProduct_Properly()
    {
        //Arrange
        var a = new Vector(1.0f, 2.0f, 3.0f);
        var b = new Vector(2.0f, 3.0f, 4.0f);
        var expected = 20.0f;
        
        //Act
        var dotProduct = a.GetDotProduct(b);
        
        //Assert
        Assert.AreEqual(expected, dotProduct);
    }
    
    //The cross product of two vectors
    [DataTestMethod]
    public void Vector_ShouldGetCrossProduct_Properly()
    {
        //Arrange
        var a = new Vector(1.0f, 2.0f, 3.0f);
        var b = new Vector(2.0f, 3.0f, 4.0f);
        var expectedCrossAB = new Vector(-1.0f, 2.0f, -1.0f);
        var expectedCrossBA = new Vector(1.0f, -2.0f, 1.0f);
        
        //Act
        var crossAB = a.GetCrossProduct(b);
        var crossBA = b.GetCrossProduct(a);
        
        //Assert
        Assert.IsTrue(expectedCrossAB.Equals(crossAB));
        Assert.IsTrue(expectedCrossBA.Equals(crossBA));
    }
}