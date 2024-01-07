/*
    5. Napisz program w którym poprosisz użytkownika o jego dane 
       personalne tj. Imię, nazwisko, numer telefonu, adres email, 
       wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej) 
       i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych 
       używając metody: 
        
        typDanych.Parse(odpowiedźOdUżytkownika).

      TESTED: 2023.12.27 
      TESTED: 2023.01.07 
      STATUS: OK 
*/

namespace Exc_05
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 05: Querying user data");

      while (true) { 
        try {
          Console.WriteLine("User data entry form:");
          User user = new User();
          user.FirstName = UserConsoleInput.GetFirstName();
          user.LastName = UserConsoleInput.GetLastName();
          user.Email = UserConsoleInput.GetEmail();
          user.Age = UserConsoleInput.GetAge();
          user.Weight = UserConsoleInput.GetWeight();
          user.Gender = UserConsoleInput.GetGender();
          user.Pesel = UserConsoleInput.GetPesel();

          Console.WriteLine("User data viewing");
          UserDataView.ShowUserData(user);

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
      ConsoleKeyInfo key = Console.ReadKey();
    }
  }
}
