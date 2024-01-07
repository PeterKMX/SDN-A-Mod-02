/*
Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie 
liczby parzyste z zakresu 0 – 1000.

---------------------------------------------------------------------------
Analysis
- from online search we confirm that 0 % 2 = 0 
- zero is thus an even number

---------------------
DATE TESTED: 2024.01.07
STATUS: OK
*/


namespace Exc_02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 02: all even numbers 0-1000");
      
      Console.WriteLine("To start, enter (y):");
      string s = Console.ReadLine();
      if (s != "y") { return; }

      while (true) 
      {
        try {
          int itest = 0;
          do {
            if (itest % 2 == 0) {
              Console.WriteLine($"{itest} is an even number");
            } 
            ++itest;  
          } while (itest <= 1000);

          Console.WriteLine("Try again ? (y/n)"); 
          string x = Console.ReadLine();
          if (x == "y") { continue; }
          else break;

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
