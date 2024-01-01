/*


12. Napisz program, który pobierze numer dnia tygodnia i wyświetli 
jego nazwę 
Dane testowe : 4
Rezultat w terminalu : Czwartek


-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_12
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 12: Powiedz dzien tygodnia");

      while (true) {
        int score = UserDataInput.GetGetWeekDayNumber();  

        VerbalMapper mapper = new VerbalMapper();
        string scoreTxt = mapper.GetTextByIndex(score);

        Console.WriteLine($"Dzien tygodnia: {scoreTxt} ");

        Console.WriteLine("Try again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }


    }
  }
}
