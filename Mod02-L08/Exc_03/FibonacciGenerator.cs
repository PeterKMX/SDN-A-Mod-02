using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_03
{
  public class FibonacciGenerator
  {

    public FibonacciGenerator() 
    { 

    }
    public static List<long> GenerateNumbers(int nMax) 
    {
      List<long> items = new List<long>();
      items.Add(0);
      items.Add(1);
      for (int i = 2; i <= nMax; ++i) 
      {
        items.Add(items[i - 2] + items[i - 1]);
      }

      return items; 
    }
  }
}
