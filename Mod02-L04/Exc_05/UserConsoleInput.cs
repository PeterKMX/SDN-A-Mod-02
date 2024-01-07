using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Exc_05
{
  public class UserConsoleInput
  {
    // age, wheight TShirtSize, gender, pesel
    public UserConsoleInput() { } 

    public static string GetFirstName() 
    {
      Console.WriteLine("Enter your first name:"); 
      return Console.ReadLine();
    }
    public static string GetLastName()
    {
      Console.WriteLine("Enter your last name:");
      return Console.ReadLine();
    }
    public static string GetEmail() 
    {
      Console.WriteLine("Enter your e-mail:");
      return Console.ReadLine();
    }

    public static int GetAge()
    {
      Console.WriteLine("Enter your age:");
      string tmp = Console.ReadLine();
      int age = 0; 
      bool error = !int.TryParse(tmp, out age);
      int errCount = 0;
      while (error) {
        errCount++; 
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }
        Console.WriteLine("Inorrect input, please enter your age:");
        tmp = Console.ReadLine();
        error = !int.TryParse(tmp, out age);
      }
      return age; // 0 means not provided
    }

    public static float GetWeight()
    {
      //Console.WriteLine("Enter your weight in kg (if needed use format xxx.xx) :");
      bool error = false;
      int errCount = 0;
      float weight = (float)0.0;

      // read into string
      Console.WriteLine("Enter your weight in kg (use decimal point . if needed)");
      string tmp = Console.ReadLine();

      // parse double
      CultureInfo invC = CultureInfo.InvariantCulture;
      error = !float.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out weight);

      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();
        // parse double
        error = !float.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out weight);
      }

      return weight; // 0.0 means not provided 
    }
    public static char GetGender()
    {
      Console.WriteLine("Enter your gender (M/F):");
      string tmp = Console.ReadLine();
      char gender = tmp[0];
      bool error = false;
      if (gender != 'M' && gender != 'F') {
        error = true;
      } else { error = false; }

      int errCount = 0; 
      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }
        Console.WriteLine("Inorrect input, please enter your our gender (M/F):");
        tmp = Console.ReadLine();
        gender = tmp[0];
        if (gender != 'M' && gender != 'F') {
          error = true;
        } else { error = false; }
      }
      return gender;  
    }
    public static bool ErrorInPesel(string pesel) 
    {
      // e.PESEL https://en.wikipedia.org/wiki/PESEL must be 11 digits
      //
      // simple error checking 
      // - only digits
      // - length = 11

      bool hasError = false;
      if (pesel.Length != 11) { hasError = true; }
      // check each char

      foreach(char x in pesel) { 
        if (!char.IsDigit(x)) { 
          hasError = true; 
          break; 
        }
      }
      return hasError;
    }
    public static string GetPesel()
    {
      Console.WriteLine("Enter your PESEL:");
      string pesel = Console.ReadLine();
      bool error = ErrorInPesel(pesel);

      int errCount = 0;
      string errMsg = "Too many errors on input...";
      while (error) {
        errCount++;
        if (errCount >= 3) {
          throw new Exception(errMsg);
        }
        Console.WriteLine("Inorrect input, please enter your PESEL:");
        pesel = Console.ReadLine();
        error = ErrorInPesel(pesel);
      }
      return pesel;  
    }
  }
}
