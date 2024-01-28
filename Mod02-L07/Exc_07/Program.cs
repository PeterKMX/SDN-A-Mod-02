/*
7. Napisz program w C#, który pobierze 3 liczby od użytkownika 
i sprawdzi, która jest największa 
Dane testowe: 25 63 79 
Rezultat w terminalu : 79 jest największa z podanych

-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_07
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 07: która liczba jest największa");


      while (true)
      {
        try
        {
          int number1 = UserDataInput.Get1stNumber();
          int number2 = UserDataInput.Get2ndNumber();
          int number3 = UserDataInput.Get3rdNumber();

          List<int> numberList = new List<int> { number1, number2, number3 };
          numberList.Sort(); // sorts ascending

          int highestNumber = numberList[2];
          Console.WriteLine(string.Format($"{highestNumber} jest największa z podanych"));

          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y")
          {
            continue;
          }
          else
          {
            break;
          }
        }
        catch (Exception ex)
        {
          string msg = "App error: " + ex.Message;
          Console.WriteLine(msg);
          Console.WriteLine("Stopping application");
          break;
        }
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
