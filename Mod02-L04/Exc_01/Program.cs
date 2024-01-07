/*
      Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
      a. Imię,
      b. Nazwisko
      c. Wiek
      d. Płeć (‘m’ albo ‘k’)
      e. PESEL
      f. Numer pracownika (np. 2509324094)
      Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje 

      TESTED: 2023.12.27 
      TESTED: 2023.01.07 
      STATUS: OK 
 
*/


namespace Exc_01
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 01: variables declaration");
      Console.WriteLine("Declaring  ...");

      Person person = new Person() {
        FirstName = "Peter",
        LastName = "Kmxx",
        Age = 41,
        Gender = 'm',
        Pesel = "12345678901",
        IdNumber = 345354354
      };
      Console.WriteLine("DONE");

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }
  }
}
