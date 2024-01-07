/*
6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
1 + ½ + 1/3 + ¼ itd.

Remark: this series is divergent so there is no finite asymptotic value.

DATE TESTED: 2024.01.07
STATUS: OK

*/

namespace Exc_06
{

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 06: sum of a series up to 20");

      int nmax = 20;
      double rev = 0;
      double sum = 0.0; 

      for (int i = 1; i <= nmax; i++) {
        rev = (double)1.0/(double)i;
        sum += rev; 
      }

      Console.WriteLine($"result is {sum:##.####}");

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
