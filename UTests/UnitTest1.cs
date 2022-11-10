using Xunit;
using Geometry;

namespace UTests;

public class UnitTest1
{
    double a, b, c, r;
    [Fact]
    public void TestIsRectangularTrue()
    {
        a = 3; b = 4; c = 5;
        bool expected = true;
        var triangle = new Triangle(a, b, c);
        bool isRectangular = triangle.IsRectangular;
        Assert.Equal(expected, isRectangular);
    }
    [Fact]
    public void TestIsRectangularFaulse()
    {
        a = 6; b = 4; c = 5;
        bool expected = false;
        var triangle = new Triangle(a, b, c);
        bool isRectangular = triangle.IsRectangular;
        Assert.Equal(expected, isRectangular);
    }
    [Fact]
    public void TestSquare1()
    {
        a = 3; b = 4; c = 5;
        double expected = 6;
        var triangle = new Triangle(a, b, c);
        double S = triangle.Square();
        Assert.Equal(expected, S);
    }
    [Fact]
    public void TestSquare2()
    {
        a = 6; b = 4; c = 5;
        double expected = 9.921567416492215;
        var triangle = new Triangle(a, b, c);
        double S = triangle.Square();
        Assert.Equal(expected, S);
    }
    [Fact]
    public void TestSquare3()
    {
        r = 5;
        double expected = 78.53981633974483;
        var circle = new Circle(r);
        double S = circle.Square();
        Assert.Equal(expected, S);
    }
}