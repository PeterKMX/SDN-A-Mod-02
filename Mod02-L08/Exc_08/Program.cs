/*
8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. 
Np.
Testowe dane:
Abcdefg
Rezultat
Gfedcba

DATE TESTED: 2024.01.07
STATUS: OK

*/

namespace Exc_08
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 08: string reversal");
      while (true) {
        try {

          // read into string
          string commandText = "Please enter a line of text:";
          Console.WriteLine(commandText);
          string tmpx = Console.ReadLine();

          List<char> charLine = tmpx.ToCharArray().ToList<char>();
          charLine.Reverse();
          string charLineReversed = new string(charLine.ToArray());  
          Console.WriteLine("Reversed:");
          Console.WriteLine(charLineReversed);

          Console.WriteLine();
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
      string s = Console.ReadLine();
    }
  }
}
