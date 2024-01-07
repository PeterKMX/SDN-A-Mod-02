using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_01
{
  public class PrimeNumberChecker
  {
    public PrimeNumberChecker() { } 

    public static bool isPrime(int number)
    {
      bool isPrime = false;
      int icounter = 0; 
      for (int i = 2; i < number - 1; ++i){
        if (number % i == 0) icounter += 1; 
      }

      if (icounter == 0) { isPrime = true; }
      return isPrime;
    }
  }
}
