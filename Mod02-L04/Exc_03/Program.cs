
/*
    3. Napisz program, który na podstawie podanej szerokości i długości 
       prostokąta wyliczy długość przekątnej. 
       (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) 

      TESTED 2023.12.27
      Issues: 
        not sure yet how to handle culture settings 
        to accept "," in input as decimal separator  
        so the input accepts now only "." and gives 
        an error when the user gives a ","

      TESTED: 2023.12.27 
      TESTED: 2023.01.07 
      TESTED: 2023.01.21 
      STATUS: OK 
*/

using System.Globalization;

namespace Exc_03
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 03: diagonal of a rectangle ");

      // in cm
      double widthInCm = ReadWidth();
      double heightInCm = ReadHeight();

      double diagonal = Math.Sqrt(Math.Pow(widthInCm, 2) + Math.Pow(heightInCm, 2));
      //TESTED: double diag_check = Math.Sqrt(width*width + height*height);

      Console.WriteLine($"Dimensions are: width={widthInCm:##.###} cm, height={heightInCm:##.###} cm");
      Console.WriteLine($"Diagonal is: {diagonal:##.###} cm");

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }

    private static double ReadHeight()
    {
      bool hasError = false;
      int errorCount = 0;
      double heightInCm = (double)0.0;

      // read into string
      Console.WriteLine("Enter height in cm (use decimal point . if needed)");
      string tmp = Console.ReadLine();

      // parse double
      CultureInfo invariantCulture = CultureInfo.InvariantCulture;
      hasError = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invariantCulture, out heightInCm);

      while (hasError)
      {
        errorCount++;
        if (errorCount >= 3)
        {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();
        // parse double
        hasError = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invariantCulture, out heightInCm);
      }

      return heightInCm; // 0.0 means not provided 
    }

    private static double ReadWidth()
    {
      bool hasError = false;
      int errorCount = 0;
      double widthInCm = (double)0.0;

      // read into string
      Console.WriteLine("Enter width in cm (use decimal point . if needed)");
      string tmp = Console.ReadLine();

      // parse double
      CultureInfo invariantCulture = CultureInfo.InvariantCulture;
      hasError = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invariantCulture, out widthInCm);

      while (hasError)
      {
        errorCount++;
        if (errorCount >= 3)
        {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();
        // parse double
        hasError = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invariantCulture, out widthInCm);
      }

      return widthInCm; // 0.0 means not provided 
    }
  }
}
