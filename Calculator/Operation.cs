using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderwiseTest
{
  public abstract class Operation
  {
    public abstract double Execute(double a, double b);
  }

  //Addition classes and other operators inherits from Operation (INHERITANCE)
  //Subclasses have their own implementation of the Execute method (POLYMORPHISM)
  //The power of OOP: New classes can be added here, like square root, % of etc. 
  public class Addition : Operation
  {
    public override double Execute(double a, double b) => a + b;
  }

  public class Subtraction : Operation
  {
    public override double Execute(double a, double b) => a - b;
  }

  public class Multiplication : Operation
  {
    public override double Execute(double a, double b) => a * b;
  }

  public class Division : Operation
  {
    public override double Execute(double a, double b)
    {
      if (b == 0)
        throw new DivideByZeroException("Cannot divide by zero.");
      return a / b;
    }
  }

}
