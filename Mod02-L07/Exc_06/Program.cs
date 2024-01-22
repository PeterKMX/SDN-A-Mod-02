/*
6. Napisz program w C#, który pobierze wzrost użytkownika 
i przypisze mu wymyśloną kategorię wzrostu. 
Dane testowe : 140 
Rezultat w terminalu : Jesteś krasnoludem

Designing this function:
Height Category

Invalid input ....         < 40 // handle in user input
You are a dwarf             40 - 140
You are a short person     141 - 160
You are a normal person    161 - 180
You are a tall person      181 - 200
You are a very tall person 201 - 220 
You are a giant            221 - 300
Invalid input ....         > 281 // handle in user input

Command Prompts
Please enter your body height in cm 
Invalid input - must be between (40 cm and 280 cm)
You are ...

-----------------------
TESTED: 01.01.2024
STATUS: OK  

*/

namespace Exc_06
{

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 06: Classify person height");


      while (true) {
        try {
          // get input in cm and assign to category range
          int heightCm = UserDataInput.GetPersonHeightInCm();
          HeightCategory hc = RangeMapper.AssignToRange(heightCm);

          // display category
          VerbalMapper verbalMapper = new VerbalMapper();
          OutputView.DisplayResult(hc,verbalMapper);

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
