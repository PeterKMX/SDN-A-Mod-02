/*
4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
jest rokiem przestępnym. 
Dane testowe : 2016 
Rezultat w terminalu : 2016 jest rokiem przestępnym
-------------------------------------------------------------------------
Analysis (1)
starts in 1584 
https://www.customcalendarmaker.com/leap-years



Rules according to wikipedia

Every year that is exactly divisible by four is a leap year, 
except for years that are exactly divisible by 100, 
but these centurial years are leap years 
if they are exactly divisible by 400. 
For example, the years 1700, 1800, and 1900 are not leap years, 
but the years 1600 and 2000 are.

Analysis (2)

steps
year % 400 == 0 : true --> done
year % 4 == 0 : 
  check if also year % 100 == 0 
          if true  --> in this case: not a leap year
          if false --> is a leap year 

------------------------------------------------------------------
-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_04
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 04: Rok przestepny / Leap Year / Schrikkeljaar");
      
      while (true) 
      {
        try {
          // read year
          int year = UserDataInput.GetYearToTest();
          if (year == 0) break; 
        
          // test leap year
          bool isLeapYear = LeapYearEvaluator.IsLeapYear(year);

          // view
          if (isLeapYear ) {
            Console.WriteLine($"{year} jest rokiem przestepnym");
          } else {
            Console.WriteLine($"{year} nie jest rokiem przestepnym");
          }
      
          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y") { continue; } else break;   
        } catch (Exception ex) {
          string msg = "App error: " + ex.Message;
          Console.WriteLine(msg);
          Console.WriteLine("Stopping application");
          break;
        }
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
