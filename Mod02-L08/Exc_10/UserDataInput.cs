using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
  public class UserDataInput
  {
    /* User enters 2 integer numbers
    */
    public static int GetFirstIntegerNumber() 
    {
      string commandText = "Enter 1st integer number (from 2 up ...):";
      return GetNumber(commandText);
    }
    public static int GetSecondIntegerNumber()
    {
      string commandText = "Enter 2nd integer number (from 2 up ...):";
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
        if (number < 2) {
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
          if (number < 2) {
            error = true;
          }
        }
      }

      return number; // 0.0 means not provided 
    }

  }
}
