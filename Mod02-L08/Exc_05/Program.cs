/*
5. Napisz program, który dla liczb od 1 do 20 wyświetli 
na ekranie ich 3 potęgę.

DATE TESTED: 2024.01.07
STATUS: OK
*/

namespace Exc_05
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 05: numbers to 3rd power");

      while (true) {

        double xpower = 0;
        for (int i = 1;  i <= 20; i++) { 
          xpower = Math.Pow((double)i, (double)3);
          Console.WriteLine($"{i:##.##}:{xpower:####.##}");  
        }

        Console.WriteLine("Run again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
