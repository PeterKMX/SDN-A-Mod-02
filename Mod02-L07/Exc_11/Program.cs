/*
11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
Ocena
Opis
6 Celujący
5 Bardzo dobry
4 Dobry
3 Dostateczny
2 Dopuszczający
1 Niedostateczny


-----------------------
TESTED: 01.01.2024
STATUS: OK 

 */

namespace Exc_11
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 11: Powiedz ocene ucznia ...");

      while (true)
      { 
        int score = UserDataInput.GetPersonScore();

        VerbalMapper mapper = new VerbalMapper(); 
        string scoreTxt = mapper.GetTextByIndex(score);

        Console.WriteLine($"Twoja ocena: {scoreTxt} ");

        Console.WriteLine("Try again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }





    }
  }
}
