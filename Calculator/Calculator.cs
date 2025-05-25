using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderwiseTest
{

  //Internal logic inside a calc class (Encapsulation)
  public class Calculator
  {
    private Operation operation;
    public double FirstNumber { get; private set; } = 0;
    public double SecondNumber { get; private set; } = 0;
    public bool OperationSet { get; private set; } = false;

    //Form uses Calculator.SetNumber so we are not changign the numbers directly (Abstraction)
    public void SetNumber(double number)
    {
      if (!OperationSet)
      {
        FirstNumber = number;
      }
      else
      {
        SecondNumber = number;
      }
    }

    public void SetOperation(string op)
    {
      if (OperationSet && operation != null)
      {
        FirstNumber = operation.Execute(FirstNumber, SecondNumber);
        SecondNumber = 0;
      }

      switch (op)
      {
        case "+":
          operation = new Addition();
          break;
        case "-":
          operation = new Subtraction();
          break;
        case "*":
          operation = new Multiplication();
          break;
        case "/":
          operation = new Division();
          break;
        default:
          throw new InvalidOperationException("Unknown operation");
      }

      OperationSet = true;
    }

    public double Calculate()
    {
      if (operation == null)
        return FirstNumber;

      double result = operation.Execute(FirstNumber, SecondNumber);
      FirstNumber = result;
      SecondNumber = 0;
      OperationSet = false; 
      operation = null;
      return result;
    }

    public void Clear()
    {
      FirstNumber = 0;
      SecondNumber = 0;
      operation = null;
      OperationSet = false;
    }

    public bool IsOperationSet() => OperationSet;
  }
}
