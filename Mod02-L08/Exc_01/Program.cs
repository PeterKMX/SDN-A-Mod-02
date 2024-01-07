/*
      
1. Napisz program, który sprawdzi ile jest liczb pierwszych 
w zakresie 0 – 100.

---------------------------------------------------------------------------
Analysis
Prime number definition: For an integer to be prime it must be greater than 1, 
and the only integers that divide into it exactly are 1 
and itself such as 3 and 13, etc. 0 is less than 1 so can't be prime. 

The number "1" is not a prime number
https://en.wikipedia.org/wiki/List_of_prime_numbers
The lowest prime number is "2".
In the range 2-100 there are 25 prime numbers.

---------------------
DATE TESTED: 2024.01.07
STATUS: OK
 
*/


namespace Exc_01
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 01: count prime numbers in range 0 - 100");
      
      Console.WriteLine("To start, enter (y):");
      string s = Console.ReadLine();
      if (s != "y") { return; }

      int nmax = 100;
      while (true)
      {
        try {
          int iCounter = 0;
          for (int i = 2; i <= nmax; i++) 
          {
            if (PrimeNumberChecker.isPrime(i)) { 
              Console.Write(i.ToString() + " ");
              iCounter += 1;
            }
          }
          Console.WriteLine($"\r\nPrime numbers count is: {iCounter}");

          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y") { continue; } else break;    

        } catch (Exception ex) {
          Console.WriteLine("An error occured:\r\n" + ex.ToString());
          Console.WriteLine("Stopping application");
          break;

        } finally { }

      }
      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string sc = Console.ReadLine();
    }
  }
}
