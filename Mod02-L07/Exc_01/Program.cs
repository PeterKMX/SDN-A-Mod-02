/*
      
1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi 
czy są one równe czy nie. 
Dane testowe: 
a : 5 
b : 5 
Rezultat w terminalu : 5 i 5 są równe 

---------------------------------------------------------------------------
Analysis
no user input needed

-----------------------
TESTED: 01.01.2024
STATUS: OK 
 
*/


namespace Exc_01
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 01: variables equality");
      int a = 5;
      int b = 5;
      if (a == b) {
        Console.WriteLine($"Variables a={a},b={b} are equal."); 
      } else {
        Console.WriteLine($"Variables a={a},b={b} are not equal.");
      }

      Console.WriteLine();
      Console.WriteLine("Hit any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }
  }
}
