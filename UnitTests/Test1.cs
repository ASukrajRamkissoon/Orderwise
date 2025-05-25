using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderwiseTest;
using System;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]


namespace UnitTests
{
  [TestClass]
  public sealed class Test1
  {
    [TestMethod]
    public void TestAddition()
    {
      var calc = new Calculator();
      calc.SetNumber(5);
      calc.SetOperation("+");
      calc.SetNumber(3);
      var result = calc.Calculate();

      Assert.AreEqual(8, result);

    }

    [TestMethod]
    public void TestSubtraction()
    {
      var calc = new Calculator();
      calc.SetNumber(10);
      calc.SetOperation("-");
      calc.SetNumber(4);
      var result = calc.Calculate();

      Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestMultiplication()
    {
      var calc = new Calculator();
      calc.SetNumber(2);
      calc.SetOperation("*");
      calc.SetNumber(6);
      var result = calc.Calculate();

      Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void TestDivision()
    {
      var calc = new Calculator();
      calc.SetNumber(20);
      calc.SetOperation("/");
      calc.SetNumber(4);
      var result = calc.Calculate();

      Assert.AreEqual(5, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestDivideByZero()
    {
      var calc = new Calculator();
      calc.SetNumber(10);
      calc.SetOperation("/");
      calc.SetNumber(0);
      calc.Calculate();
    }
  }
}
