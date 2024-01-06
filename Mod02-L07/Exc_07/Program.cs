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
 
     
      while (true) {
        try {
          int n1 = UserDataInput.Get1stNumber();
          int n2 = UserDataInput.Get2ndNumber();
          int n3 = UserDataInput.Get3rdNumber();

          List<int> list = new List<int> { n1, n2, n3 };
          list.Sort();

          Console.WriteLine(string.Format($"{list[2]} jest największa z podanych")); 
        
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
