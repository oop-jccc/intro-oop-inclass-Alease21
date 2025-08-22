using intro_oop;

namespace intro_opp_tests;

internal class CircleTests
{
    [Test]
    public void Area_WithPositiveRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        const double expected = 78.5398; //note: using const to express intent
        Assert.That(circle.Area(), Is.EqualTo(expected).Within(1e-4));
    }

    [Test]
    public void Area_WithDecimalRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5.5);
        const double expected = Math.PI * 5.5 * 5.5;
        Assert.That(circle.Area(), Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void Area_WithZeroRadius_ReturnsZero()
    {
        var circle = new Circle(0);
        Assert.That(circle.Area(), Is.EqualTo(0).Within(1e-9));
    }

    [Test]
    public void Area_WithNegativeRadius_ReturnsNegativeArea()
    {
        var circle = new Circle(-5);
        const double expected = Math.PI * -5 * -5;
        Assert.That(circle.Area(), Is.EqualTo(expected).Within(1e-9)); // note: negative area address this in the future
    }
}