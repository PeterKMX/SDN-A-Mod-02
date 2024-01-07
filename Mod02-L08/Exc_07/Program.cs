/*

7. Napisz program, który dla liczby zadanej przez użytkownika 
narysuje diament o krótszej przekątnej o długości wprowadzonej 
przez użytkownika i wg wzoru:
np 9

    *
   ***
  ***** 
 ******* 
********* 
 ******* 
  ***** 
   *** 
    *

DATE TESTED: 2024.01.07
STATUS: OK
*/

namespace Exc_07
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 07: Draw a diamond");
      
      DiamondCreator diamondCreator = new DiamondCreator();
      DiamondViewer diamondViewer = new DiamondViewer(); 

      while (true) {

        try {

        } catch (Exception ex) {
          Console.WriteLine("An error occured:\r\n" + ex.ToString());
          Console.WriteLine("Stopping application");
          break;

        } finally { }

        int nSize = UserDataInput.GetDiagonalSize();

        int[,] arr = diamondCreator.CreateShape(nSize);
        diamondViewer.Show(arr,nSize);

        Console.WriteLine();
        Console.WriteLine("Try again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }
  }
}
