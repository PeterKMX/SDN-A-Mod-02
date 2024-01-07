/*
9. Napisz program, który zamieni liczbę dziesiętną 
na liczbę binarną.

DATE TESTED: 2024.01.07
STATUS: OK
*/

using System.Collections;
using System.Security.Cryptography;

namespace Exc_09
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 09: convert base-10 to base-2");
      int inputVal = 0;
      string converted; 

      while (true) 
      {
        try {
          inputVal = UserDataInput.GetANumberToConvert();

          converted = Base10ToBinary.ConvertToString(inputVal);
          Console.WriteLine($"({converted})base-2");
          Console.WriteLine("");

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
