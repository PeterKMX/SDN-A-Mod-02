/*
5. Napisz program w C#, który sprawdzi czy podany 
przez użytkownika wiek uprawnia go do ubiegania się 
o stanowisko posła, premiera, senatora, prezydenta. 
Dane testowe : 21 
Rezultat w terminalu : Możesz zostać posłem

-----------------------------------------------------------
analysis: 
searching online for legal information 

poseł:    Obecnie stanowisko posła w Polsce może zajmować obywatel, który 
            ukończył 21 lat i ma czynne prawo wyborcze. Posłowie, podobnie 
            jak senatorowie, są przedstawicielami narodu i nie wiążą ich instrukcje 
            wyborców (art. 104 ust. 1 Konstytucji). 

premier:  W myśl art. 154 Konstytucji, Prezydent desygnuje Prezesa Rady Ministrów. 
            Jest to zazwyczaj osoba wskazana przez większość parlamentarną. 
            --> konkluzja : 21 lat tak jak posel

senator:  https://www.gazetaprawna.pl/wiadomosci/kraj/artykuly/9315090,kto-moze-byc-poslem-i-senatorem-wazny-wiek-doswiadczenie-i-pelnione.html
            W przypadku kandydowania na senatora, wymagania są nieco bardziej restrykcyjne. 
            Kandydat musi być obywatelem Polski i mieć co najmniej 30 lat. 
            Podobnie jak w przypadku posła, musi posiadać pełnię praw publicznych oraz 
            być zarejestrowanym jako wyborca w Polsce. Jednak dodatkowym wymogiem jest 
            posiadanie wykształcenia wyższego. 

prezydent: Na Prezydenta Rzeczypospolitej może być wybrany obywatel polski, 
            który najpóźniej w dniu wyborów kończy 35 lat i korzysta z pełni 
            praw wyborczych do Sejmu.

-----------------------
TESTED: 01.01.2024
STATUS: OK 
*/

namespace Exc_05
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 05: Stanowiska polityczne");


      while (true) {
        try {
          int age = UserDataInput.GetAge();

          AgeMapper mapper = new AgeMapper();
          OutputView.DisplayResult(age, mapper);

          Console.WriteLine();

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
