using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_06
{
  public class UserDataInput
  {

    /*
Invalid input ....         < 40 // handle in user input
You are a dwarf             40 - 140
You are a short person     141 - 160
You are a normal person    161 - 180
You are a tall person      181 - 200
You are a very tall person 201 - 220 
You are a giant            221 - 300
Invalid input ....         > 281 // handle in user input    
     
    */
    public static int GetPersonHeightInCm() 
    {
      string commandText = "Please enter your height in centimeters: ";
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
