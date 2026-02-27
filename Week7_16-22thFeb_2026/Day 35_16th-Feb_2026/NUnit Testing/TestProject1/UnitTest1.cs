using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorApp;

namespace TestProject1;

[TestFixture]
public class Tests
{

    private Calculator calc;


    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    
    public void Add_TwoNumbers_ReturnsSum()
    {
        int a = 5, b = 2;

        int result = calc.Add(a, b);

        Assert.That(result, Is.EqualTo(7));
    }

    [Test]

    public void Subtract_TwoNumbers_ReturnedDifference()
    {
        int a = 10, b = 4;

        int result = calc.Sub(a, b);

        Assert.That(result, Is.EqualTo(6));
    }

    [Test]

    public void Multiply_TwoNumbers_ReturnedProduct()
    {
        int a = 10, b = 4;

        int result = calc.Mul(a, b);

        Assert.That(result, Is.EqualTo(40));
    }

    [Test]

    public void Divide_TwoNumbers_ReturnedQuotient()
    {
        int a = 10, b = 5;

        int result = calc.div(a, b);

        Assert.That(result, Is.EqualTo(2));
    }
}
