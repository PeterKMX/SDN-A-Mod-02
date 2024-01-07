
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
      double width = ReadWidth();
      double height = ReadHeight();

      double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
      //TESTED: double diag_check = Math.Sqrt(width*width + height*height);

      Console.WriteLine($"Dimensions are: width={width:##.###} cm, height={height:##.###} cm");
      Console.WriteLine($"Diagonal is: {diagonal:##.###} cm");

      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      ConsoleKeyInfo key = Console.ReadKey();
    }

    private static double ReadHeight()
    {
      bool error = false;
      int errCount = 0;
      double height = (double)0.0;

      // read into string
      Console.WriteLine("Enter height in cm (use decimal point . if needed)");
      string tmp = Console.ReadLine();

      // parse double
      CultureInfo invC = CultureInfo.InvariantCulture;
      error = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out height);

      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();
        // parse double
        error = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out height);
      }

      return height; // 0.0 means not provided 
    }

    private static double ReadWidth()
    {
      bool error = false;
      int errCount = 0;
      double width = (double)0.0;

      // read into string
      Console.WriteLine("Enter width in cm (use decimal point . if needed)");
      string tmp = Console.ReadLine();

      // parse double
      CultureInfo invC = CultureInfo.InvariantCulture;
      error = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out width);

      while (error) {
        errCount++;
        if (errCount >= 3) {
          Console.WriteLine("Too many errors on input, skipping this question ...");
          break;
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();
        // parse width
        error = !double.TryParse(tmp, NumberStyles.AllowDecimalPoint, invC, out width);
      }

      return width; // 0.0 means not provided 
    }
  }
}
