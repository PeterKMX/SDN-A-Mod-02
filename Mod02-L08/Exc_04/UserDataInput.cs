using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_04
{
  public class UserDataInput
  {

    /*

    */
    public static int GetNumber() 
    {
      string commandText = "Get a number (from 1 to 500):";
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
        if (number <= 0) { error = true; }
        if (number > 500) { error = true; }
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
          if (number <= 0) { error = true; }
          if (number > 500) { error = true; }
        }
      }

      return number; // 0.0 means not provided 
    }

  }
}
