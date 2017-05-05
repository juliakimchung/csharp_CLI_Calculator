using System;
namespace Calculator
{
  class Program
  {
    static void Main()
    {
      
      Console.WriteLine("Select operation");
      Console.WriteLine("1. Add");
      Console.WriteLine("2. Subtract");
      Console.WriteLine("3. Multiply");
      Console.WriteLine("4. Divide");

      var choice = Console.ReadLine();

      Console.WriteLine("Enter first number");

      var num1 = Console.ReadLine();

      Console.WriteLine("Enter second number");

      var num2 = Console.ReadLine();
      
      Console.Write("Answer: ");
      
      if(choice == "1")
      {
        Console.WriteLine(double.Parse(num1) + double.Parse(num2));

      }
      else if(choice == "2")
      {
        
        Console.WriteLine(double.Parse(num1) - double.Parse(num2));
      }
      else if(choice == "3")
      {
        
        Console.WriteLine(double.Parse(num1) * double.Parse(num2));
      }
      else if(choice == "4")
      {
        Console.WriteLine(double.Parse(num1) / double.Parse(num2));
      }
      else
      {
        Console.WriteLine("Invalid input");
        
      }
      Console.WriteLine("Good Bye");
    }
  }
}
