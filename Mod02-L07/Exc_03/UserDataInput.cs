using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_03
{
  public class UserDataInput
  {

    /*

    */
    public static int GetNumberToTest() 
    {
      string commandText = "Podaj prosze liczbe calkowita:";
      return GetNumber(commandText);
    }

    private static int GetNumber(String commandText)
    {
      bool error = false;
      int errCount = 0;
      int number = 0;

      // read into string
      Console.WriteLine(commandText);

      string tmp = Console.ReadLine();

      // parse
      error = !int.TryParse(tmp, out number);

      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        // parse
        error = !int.TryParse(tmp, out number);
      }

      return number; // 0.0 means not provided 
    }

  }
}
