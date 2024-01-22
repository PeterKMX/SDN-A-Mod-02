using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exc_04
{
  public class LeapYearEvaluator
  {
    /*
    steps
      year % 400 == 0 : true --> done
      year % 4 == 0 : 
      check if also year % 100 == 0 
          if true  --> in this case: not a leap year
          if false --> is a leap year  
    */
    public static bool ConfirmLeapYear(int year)
    {
      if (year < 1582)
      {
        Console.WriteLine($"Any year before 1582 is not a leap year, because");
        Console.WriteLine($"the concept of a leap year was introduced in 1582.");
        return true;
      }
      else
      {
        if ((year % 400 == 0))
        {
          return true;
        } 
        else 
        {
          return (year % 4 == 0 && year % 100 != 0);
        }
      }
    }
  }
}
