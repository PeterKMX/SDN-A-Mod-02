using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_13
{
  public class UserDataInput
  {
    public static int Get1stNumber()
    {
      string commandText = "Podaj liczbe nr 1: ";
      return GetNumber(commandText);
    }
    public static int Get2ndNumber()
    {
      string commandText = "Podaj liczbe nr 2: ";
      return GetNumber(commandText);
    }
    public static int GetOperation()
    {
      string commandText = 
      "Podaj numer operacji do wykonania:" +
        "\r\n1 Dodawanie" +
        "\r\n2 Odejmowanie" +
        "\r\n3 Mnożenie" +
        "\r\n4 Dzielenie:"; 

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
      // no limitation

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
        // no limitation
      }

      return number; // 0.0 means not provided 
    }

    private static int GetOperation(String commandText)
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
        if (number < 1 || number > 4) {
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
          if (number < 1 || number > 4) {
            error = true;
          }
        }
      }

      return number; // 0.0 means not provided 
    }


  }
}
