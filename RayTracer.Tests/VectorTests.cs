using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class VectorTests
{
    [TestMethod]
    public void ShouldBeNegated_Properly()
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
    public void ShouldComputeMagnitude_Properly(float x, float y, float z, float magnitude)
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
    public void ShouldNormalizeItself_Properly(float vX, float vY, float vZ,
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
    public void ShouldGetDotProduct_Properly()
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
    public void ShouldGetCrossProduct_Properly()
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
    
    //Subtracting two vectors
    [TestMethod]
    public void ShouldSubtractTwoVectors_Properly()
    {
        //Arrange
        var v1 = new Vector(3.0f, 2.0f, 1.0f);
        var v2 = new Vector(5.0f, 6.0f, 7.0f);
        
        var expected = new Vector(-2, -4, -6);

        var result = v1 - v2;
        
        //Assert
        Assert.IsTrue(expected.Equals(result));
    }
}