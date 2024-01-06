/*
8. Napisz program, który sprawdzi, 
czy kandydat może ubiegać się o miejsce na studiach 

wg. Następujących kryteriów: 

Wynik z Matury z matematyki powyżej 70 
Wynik z fizyki powyżej 55 
Wynik z chemii powyżej 45 

Łączny wynik z 3 przedmiotów powyżej 180 

Albo
Wynik z matematyki i jednego przedmiotu powyżej 150 

Dane testowe: 
Matematyka 80 
Fizyka 71 
Chemia 0 
Rezultat w terminalu : 
Kandydat dopuszczony do rekrutacji

Enter maturity exam math score
Enter maturity exam physics score
Enter maturity exam chemistry score


Wynik z Matury z matematyki:
Wynik z Matury z fizyki:
Wynik z Matury z chemii:

-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_08
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(
        "Excercise 08: University candiate student selection admission"
      );

      while (true) {
        try {
          // get scores
          int mathScore = UserDataInput.GetMathScore();
          int physicsScore = UserDataInput.GetPhysicScore();
          int chemistryScore = UserDataInput.GetChemistryScore();

          // evaluate
          bool isAdmitted = AdmissionEvaluator.IsAdmitted(
            mathScore, physicsScore, chemistryScore);

          // display result
          if (isAdmitted) {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
          } else {
            Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
          }

          Console.WriteLine("Try again ? (y/n)");
          string x = Console.ReadLine();
          if (x == "y") { continue; } else break;

        } catch (Exception ex) {
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
