using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_07
{
  public class UserDataInput
  {

    public static int Get1stNumber() 
    {
      string commandText = "Podaj 1-sza liczbe:";
      return GetNumber(commandText);
    }
    public static int Get2ndNumber()
    {
      string commandText = "Podaj 2-ga liczbe:";
      return GetNumber(commandText);
    }
    public static int Get3rdNumber()
    {
      string commandText = "Podaj 3-cia liczbe:";
      return GetNumber(commandText);
    }
    private static int GetNumber(String commandText)
    {
      bool error = false;
      int errCount = 0;
      int score = 0;

      // read into string
      Console.WriteLine(commandText);

      string tmp = Console.ReadLine();

      // parse
      error = !int.TryParse(tmp, out score);

      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        // parse
        error = !int.TryParse(tmp, out score);
      }

      return score; // 0.0 means not provided 
    }

  }
}
