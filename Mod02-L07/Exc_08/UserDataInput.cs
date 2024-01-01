using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_08
{
  public class UserDataInput
  {

    public static int GetMathScore() 
    {
      string commandText = "Please enter your math score:";
      return GetScore(commandText);
    }
    public static int GetPhysicScore()
    {
      string commandText = "Please enter your physics score:";
      return GetScore(commandText);
    }
    public static int GetChemistryScore()
    {
      string commandText = "Please enter your chemistry score:";
      return GetScore(commandText);
    }
    private static int GetScore(String commandText)
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
