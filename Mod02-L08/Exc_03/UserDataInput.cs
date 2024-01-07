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
    public static int GetIntegerNumberToTest() 
    {
      string commandText = "Enter sequence limit for Fibonacci series (from 2 to 40):";
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
      if (!error) {
        // extra limitation
        if (number < 2 || number > 40) {
          error = true;
        }
      }

      string errMsg = "Too many errors on input...";
      while (error) {
        errCount++;
        if (errCount >= 3) {
          throw new Exception(errMsg);
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        // parse
        error = !int.TryParse(tmp, out number);
        if (!error) {
          // extra limitation
          if (number < 2 || number > 40) {
            error = true;
          }
        }
      }

      return number; // 0.0 means not provided 
    }

  }
}
