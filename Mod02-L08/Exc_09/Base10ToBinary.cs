using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_09
{
  public class Base10ToBinary
  {


    public static string ConvertToString(int value) 
    {
      List<int> l = Convert(value);
      l.Reverse();  
      StringBuilder sb = new StringBuilder(); 
      foreach (int i in l) {
        sb.Append(i);
      }

      return sb.ToString();
    }
    
    private static List<int> Convert(int value) 
    {
      int quotient = value;
      int remainder = 0;
      List<int> base2list = new List<int>();  
      while (quotient != 0) {

        remainder = quotient % 2; 
        quotient = quotient / 2;
        //Console.WriteLine($"{quotient},{remainder}");
        base2list.Add(remainder);
      }

      return base2list; 
    }
  }
}
