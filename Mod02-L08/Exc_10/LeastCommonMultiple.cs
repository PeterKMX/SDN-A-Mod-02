using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
  public class LeastCommonMultiple
  {
    private Collector _collector; 
    public LeastCommonMultiple() 
    { 
      _collector = new Collector(); 
    }  

    public int CalculateLCM(int a, int b) 
    {
      int nLower=0;
      int nHigher=0;

      List<int> list = new List<int>() { a, b };
      list.Sort();
      nLower = list[0];
      nHigher = list[1];

      int lcm = IterateAndSearch(nLower, nHigher);

      return lcm; 
    }

    private int IterateAndSearch(int nLower, int nHigher)
    {
      bool found = false;
      int imult = 0;
      int iter = 0;
      int xLower = 0;
      int xHigher = 0;

      Console.WriteLine("\r\nIterating:");
      _collector = new Collector(); // reset collector
      while (!found && iter++ <= 10000) {
        imult++;
        xLower = imult * nLower;
        xHigher = imult * nHigher;
        _collector.Add(xHigher);
        found = _collector.Find(xLower);
      }
      Console.WriteLine("...");

      if (imult > 10000) {
        Console.WriteLine($"Maxium number of iterations reached: {imult}\r\n");
      } else {  
        Console.WriteLine($"Iterations: {imult}\r\n");
      }

      return xLower;
    }
  }
}
