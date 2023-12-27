/*
    4. Napisz program w którym stworzysz 2 zmienne liczbowe, 
       oraz jedną tekstową, a następnie przypiszesz im 
       następujące wartości:
        a. 10
        b. Szkoła Dotneta
        c. 12,5
       Pamiętaj o użyciu poprawnych typów danych.

      TESTED: 2023.12.27
      STATUS: OK 
*/

namespace Exc_04
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 04: number and text vars ");

      int a;
      string b;
      float c;

      a = 10;
      b = "Szkoła Dotneta";
      c = (float)12.50;

      Console.WriteLine($"a={a}");
      Console.WriteLine($"b={b}");
      Console.WriteLine($"c={c:##.###}");

      Console.WriteLine();
      Console.WriteLine("Hit any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }
  }
}
