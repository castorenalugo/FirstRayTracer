using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
public class MatrixTests
{
    [TestMethod]
    public void ShouldCompareWithOtherMatrix()
    {
        // Arrange
        var m1 = new Matrix(
            1, 2, 3, 4,
            5, 6, 7, 8,
            9, 8, 7, 6,
            5, 4, 3, 2);
        
        var m2 = new Matrix(
            1, 2, 3, 4,
            5, 6, 7, 8,
            9, 8, 7, 6,
            5, 4, 3, 2);

        //Assert
        Assert.IsTrue(m1 == m2);
    }
    
    [TestMethod]
    public void ShouldMultiplyTwoMatrices()
    {
        // Arrange
        var a = new Matrix(
            1, 2, 3, 4,
            5, 6, 7, 8,
            9, 8, 7, 6,
            5, 4, 3, 2);

        var b = new Matrix(
            -2, 1, 2, 3,
            3, 2, 1, -1,
            4, 3, 6, 5,
            1, 2, 7, 8);

        var expectedResult = new Matrix(
            20, 22, 50, 48,
            44, 54, 114, 108,
            40, 58, 110, 102,
            16, 26, 46, 42);

        // Act
        var result = a * b;

        // Assert
        Assert.IsTrue(result == expectedResult);
    }
    
    [TestMethod]
    public void ShouldMultiplyMatrixByIdentityMatrix()
    {
        // Arrange
        var a = new Matrix(
            0, 1, 2, 4,
            1, 2, 4, 8,
            2, 4, 8, 16,
            4, 8, 16, 32);

        // Act
        var result = a * Matrix.Identity;

        // Assert
        Assert.IsTrue(result == a);
    }
    
    [TestMethod]
    public void ShouldTransposeMatrix()
    {
        // Arrange
        var a = new Matrix(
            0, 9, 3, 0,
            9, 8, 0, 8,
            1, 8, 5, 3,
            0, 0, 5, 8);

        var expectedTranspose = new Matrix(
            0, 9, 1, 0,
            9, 8, 8, 0,
            3, 0, 5, 5,
            0, 8, 3, 8);

        // Act
        var result = a.GetTranspose();

        // Assert
        Assert.IsTrue(result == expectedTranspose);
    }
    
    [TestMethod]
    public void ShouldTransposeIdentityMatrix()
    {
        // Arrange
        var transposedIdentity = Matrix.Identity.GetTranspose();

        // Assert
        Assert.IsTrue(Matrix.Identity == transposedIdentity);
    }
}