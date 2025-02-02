using RayTracer.Models;

namespace RayTracer.Tests;

//[TestClass]
public class PointTests
{
    //point() creates tuples with w=1
    [TestMethod]
    public void Point_ShouldSetW_Properly()
    {
        //Arrange
        var point = new Point(1.1f, 2.1f, 3.1f);
        
        var expected = new MyTuple(1.1f, 2.1f, 3.1f, 1.0f);
        
        //Assert
        Assert.IsTrue(expected.Equals(point));
    }
}