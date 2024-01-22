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
    public static int GetYearToTest()
    {
      string commandText = "Podaj prosze rok do sprawdzenia (albo 0 zeby zakonczyc test):";
      return GetNumber(commandText);
    }

    private static int GetNumber(String commandText)
    {
      bool hasError = false;
      int errorCount = 0;
      int number = 0;

      // read into string
      Console.WriteLine(commandText);

      string tmp = Console.ReadLine();

      // parse
      hasError = !int.TryParse(tmp, out number);
      string errorMessage = "Too many errors on input...";
      while (hasError)
      {
        errorCount++;
        if (errorCount >= 3)
        {
          throw new Exception(errorMessage);
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        // parse
        hasError = !int.TryParse(tmp, out number);
      }

      return number; 
    }

  }
}
