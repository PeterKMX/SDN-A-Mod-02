/*
2. Napisz program w C#, który sprawdzi czy podana przez użytkownika 
liczba jest parzysta czy nieparzysta. 
Dane testowe : 15 
Rezultat w terminalu : 15 jest liczbą nieparzystą

---------------------------------------------------------------------------
Analysis
- user input needed

-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/


namespace Exc_02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 02: even or odd number");

      while (true) {
        try {
          int number = UserDataInput.GetNumberToTest();

          if (number % 2 == 0) {
            Console.WriteLine($"Number {number} is even");
          } else {
            Console.WriteLine($"Number {number} is odd");
          }

          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y") { continue; } else break;
        } catch (Exception ex) {
          string msg = "App error: " + ex.Message;
          Console.WriteLine(msg);
          Console.WriteLine("Stopping application");
          break;
        } finally { }
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
