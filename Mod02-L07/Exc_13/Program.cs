/*
13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) 
I będzie prostym kalkulatorem 

Podaj pierwszą liczbę: … 
Podaj drugą liczbę: … 
Podaj numer operacji do wykonania:
1. Dodawanie
2. Odejmowanie
3. Mnożenie
4. Dzielenie
…
Twój wynik to:

-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_13
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 13: Simple calculator");

      Calculator c = new Calculator();
      double d; 

      while (true) 
      {
        try 
        { 
          int arg1 = UserDataInput.Get1stNumber();
          int arg2 = UserDataInput.Get2ndNumber();
          int oper = UserDataInput.GetOperation();

          d = c.Calculate(arg1, arg2, oper); 
          Console.WriteLine($"Rezultat: {d:###.###}");

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
