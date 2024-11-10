using RayTracer.Models;

namespace RayTracer.Tests;

[TestClass]
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
}