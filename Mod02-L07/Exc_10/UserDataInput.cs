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

    public static List<int> GetTriangleData()
    {
      string commandText = "Enter 3 numbers (a b c) to check: ";

      return ParseList(commandText);
    }

    private static List<int> ParseList(String commandText)
    {
      bool error = false;
      int errCount = 0;
      int number = 0;

      Console.WriteLine(commandText);
      //
      string tmp = Console.ReadLine();
      ParserResult parserResult = SplitAndConvert(tmp); 

      while (parserResult.Error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        parserResult = SplitAndConvert(tmp);
      }
      return parserResult.NumbersList;   
    }

    private static ParserResult SplitAndConvert(string? tmp)
    {
      // must have 3 elements 
      // 40 55 65 
      ParserResult pr = new ParserResult();
      bool error = false;

      // check numbers and spaces
      foreach (char c in tmp) 
      {
        if (!char.IsDigit(c) && (c != ' ')) { 
          pr.Error = true;
          return pr;  // error ======>
        }
      }

      // here we have only digits and spaces
      // but do we have 3 valid numbers ? 
      List<string> elements = tmp.Split(' ').ToList<string>();
      List<string> validatedList = new List<string>();
      string x; 
      foreach (string element in elements) {
        x = element.Trim();
        if (!string.IsNullOrEmpty(x)) {
          validatedList.Add(x);
        }
      }

      if (validatedList.Count != 3) {
        pr.Error = true;
        return pr; // error ======>
      }

      // convert to List<int>
      List<int> numbers = new List<int>();
      int p; // current converted
      foreach (string element in validatedList) {
        if (int.TryParse(element, out p)) {
          numbers.Add(p);
        } else {
          // conversion error
          pr.Error = true;
          return pr; // error ======>
        }
      }

      pr.Error = false;
      pr.NumbersList.AddRange(numbers); 
      return pr;
    }











    public static int GetTemperatureInCelsius() 
    {
      string commandText = "Podaj temperature powietrza w stopniach Celsjusza: ";
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
