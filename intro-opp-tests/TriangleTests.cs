using intro_oop;

namespace intro_opp_tests;

internal class TriangleTests
{
    [Test]
    public void Area_WithPositiveBaseAndHeight_ReturnsCorrectArea()
    {
        var triangle = new Triangle(5, 10);
        const int expected = 25; //note: using const to express intent
        Assert.That(triangle.Area(), Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void Area_WithDecimalBaseAndHeight_ReturnsCorrectArea()
    {
        var triangle = new Triangle(5.5, 10.5);
        const double expected = 28.875;
        Assert.That(triangle.Area(), Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void Area_WithZeroBaseAndHeight_ReturnsZero()
    {
        var triangle = new Triangle(0, 0);
        Assert.That(triangle.Area(), Is.EqualTo(0).Within(1e-9));
    }

    [Test]
    public void Area_WithNegativeBaseAndHeight_ReturnsNegativeArea()
    {
        var triangle = new Triangle(-5, -10); // note: negative area address this in the future
        const int expected = 25;
        Assert.That(triangle.Area(), Is.EqualTo(expected).Within(1e-9));
    }
}