/*

10. Napisz program, który znajdzie 
najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

LCM - Least Common Multiple: Analysis of online resources
--------------------------------------------------------------
https://www.cuemath.com/numbers/lcm-least-common-multiple/
https://byjus.com/maths/lcm-of-24-and-56/

The method of multiplies is the esiest to implement to find LCM
example

Multiples of 24    Multiples of 56
24                  56
48                  112
72                  168 *
...                 ...
168 *               392

here we can define a simple algorithm
- iterate over multiples 
- at each iteration check if the multiple of the lower number
  is present among the multiples of the higher number
- stop when multiple of the lower number is found among 
  multiples of the higher number
- start at multipler = 1 to include the case as 15 and 45
  wher 45 is also an LCM

DATE TESTED: 2024.01.07
STATUS: OK

*/


namespace Exc_10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      
      LeastCommonMultiple lcm = new LeastCommonMultiple();  
      Console.WriteLine("Excercise 10: Least Common Multiple");

      while (true) 
      {
        try { 
          int a = UserDataInput.GetFirstIntegerNumber();  
          int b = UserDataInput.GetSecondIntegerNumber(); 

          int nLcm = lcm.CalculateLCM(a, b);

          Console.WriteLine($"Least Common Multiple is: {nLcm}");

          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y") { continue; } else break;

        } catch (Exception ex) {
          Console.WriteLine("An error occured:\r\n" + ex.ToString());
          Console.WriteLine("Stopping application");
          break;
        } finally { }
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
