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
        var tuple = new MyTuple()
        {
            X = 4.3f,
            Y = -4.2f,
            Z = 3.1f,
            W = w
        };
        
        //Assert
        Assert.AreEqual(isAPoint, tuple.IsAPoint);
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
        var tuple = new MyTuple()
        {
            X = 4.3f,
            Y = -4.2f,
            Z = 3.1f,
            W = w
        };
        
        //Assert
        Assert.AreEqual(isAVector, tuple.IsAVector);
    }

}