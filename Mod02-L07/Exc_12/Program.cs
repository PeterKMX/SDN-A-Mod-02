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

      VerbalMapper mapper = new VerbalMapper();
      int dayNr=1;
      string dayTxt=""; 

      while (true) 
      {
        try { 
          dayNr = UserDataInput.GetGetWeekDayNumber();         
          dayTxt = mapper.GetTextByIndex(dayNr);

          Console.WriteLine($"Dzien tygodnia: {dayTxt} ");

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
