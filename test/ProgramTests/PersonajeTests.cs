global using global::System;
namespace ProgramTests;


[TestFixture]
public class Personaje
{
    [Test]
    [TestCase("Salad", 5.99, true)]
    [TestCase("Burger", 8.99, false)]
    public void Constructor_WithValidParameters_SetsProperties(string name, double price, bool isVegetarian)
    {
        Dish dish = new Dish(name, price, isVegetarian);

        Assert.That(dish.Name, Is.EqualTo(name));
        Assert.That(dish.Price, Is.EqualTo(price));
        Assert.That(dish.IsVegetarian, Is.EqualTo(isVegetarian));
    }
}

public class TestFixtureAttribute : Attribute
{
}