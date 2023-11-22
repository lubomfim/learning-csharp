using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("First number:");
      string firstInput = Console.ReadLine();
      Console.WriteLine("Second number:");
      string secondInput = Console.ReadLine();

      int first, second;

      if (int.TryParse(firstInput, out first) && int.TryParse(secondInput, out second))
      {
        Console.WriteLine($"Sum: {first + second}");
      }
      else
      {
        Console.WriteLine("Please, make sure you type only numbers.");
      }


    }
  }
}