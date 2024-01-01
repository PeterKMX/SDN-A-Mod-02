using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_13
{
  public class Calculator
  {
    public Calculator() { }

    public double Calculate(int arg1, int arg2, int operation) 
    { 
      double x = 0;
      switch (operation) { 
        case 1: x = arg1 + arg2; break;  
        case 2: x = arg1 - arg2; break;  
        case 3: x = arg1 * arg2; break;  
        case 4:
          if (arg2 == 0) throw new Exception("Divide by 0 is not allowed"); 
          x = (double)arg1 / (double)arg2; 
          break;  
        default:
        break; 
      }

      return x;
    }
  }
}
