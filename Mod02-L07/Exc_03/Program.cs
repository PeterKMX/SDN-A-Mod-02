
/*
 
3. Napisz program w C#, który sprawdzi czy podana przez użytkownika 
liczba jest dodatnia czy ujemna. 
Dane testowe : 
14 Rezultat w terminalu : 
14 jest liczbą dodatnią

---------------------------------------------------------------------------
Analysis
0 is neither + nor - 


-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/


namespace Exc_03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 03: Is this number positive or negative ...");
      int aNumber = UserDataInput.GetNumberToTest();

      if (aNumber == 0) {
        Console.WriteLine($"Number {aNumber} is neither negative nor positive");
      } else if (aNumber > 0) {
        Console.WriteLine($"Number {aNumber} is positive");
      } else {
        //  number is negative
        Console.WriteLine($"Number {aNumber} is negative");
      }
      Console.WriteLine("Hit any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }

  }
}
