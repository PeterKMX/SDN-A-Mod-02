/*
10. Napisz program, który sprawdzi, czy z 3 podanych długości 
można stworzyć trójkąt 
Dane testowe : 
40 55 65 
Rezultat w terminalu : Można zbudować trójkąt

-----------------------
TESTED: 01.01.2024
STATUS: OK 

*/

namespace Exc_10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 10: Evaluate triangle data");

      while (true) 
      {
        try {

          List<int> abcList = UserDataInput.GetTriangleData();
          bool isSuitable = BuildTriangle.ListIsSuitable(abcList);

          if (isSuitable) {
            Console.WriteLine("Building triangle is possible");
          } else {
            Console.WriteLine("Building triangle is not possible");
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
