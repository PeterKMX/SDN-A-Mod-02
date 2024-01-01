using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_12
{
  public class UserDataInput
  {
    public static int GetGetWeekDayNumber()
    {
      string commandText = "Podaj numer dnia tygodnia: ";
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
        if (number < 1 || number > 7) {
          error = true;
        }
      }

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
        if (!error) {
          // extra limitation
          if (number < 1 || number > 7) {
            error = true;
          }
        }
      }

      return number; // 0.0 means not provided 
    }

  }
}
