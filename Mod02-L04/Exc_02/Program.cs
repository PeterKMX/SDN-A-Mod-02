/*
   2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie 
      wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.

      TESTED: 2023.12.27 
      TESTED: 2023.01.07 
      STATUS: OK 
*/

namespace Exc_02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 02: 3 variables ");

      char a = 'a';
      char b = 'b';
      char c = 'c';

      Console.WriteLine(string.Format($"{c},{b},{a}"));

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }
  }
}
