
/*
 
3. Napisz program, który zaimplementuje ciąg Fibonacciego 
i wyświetli go na ekranie.

---------------------------------------------------------------------------
Analysis
Fibonacci series
https://en.wikipedia.org/wiki/Fibonacci_sequence
The Fibonacci numbers are defined by recurrence
F(0) = 0 , F(1) = 1 ,
and
F(n) = F (n – 1) + F( n – 2)
for n > 1. Or n >=2
 
Remark
- we set nMax sequence limit to 40 
since the values may exceed the size of long in C# 
thus wrapping to negative numbers

The limit to 40 avoids this problem 
- we need to look for a better solution like 
BigInteger 

---------------------
DATE TESTED: 2024.01.07
STATUS: OK
*/

namespace Exc_03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 03: Fibonacci series ...");

      Console.WriteLine("To start, enter (y):");
      string s = Console.ReadLine();
      if (s != "y") { return; }

      FibonacciGenerator fg = new FibonacciGenerator();
      while (true) {
        int nMax = UserDataInput.GetIntegerNumberToTest();
        List<long> l = FibonacciGenerator.GenerateNumbers(nMax);

        // display
        Console.WriteLine("Fibonacci numbers:");
        foreach (int i in l) {
          Console.Write(i + " "); 
        }

        Console.WriteLine();
        Console.WriteLine("Try again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string sx = Console.ReadLine();
    }
  }
}
