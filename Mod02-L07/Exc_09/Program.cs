﻿/*

9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach 
Temp < 0 – cholernie zimno 
Temp 0 – 10 – zimno
Temp 10 – 20 – chłodno
Temp 20 – 30 – w sam raz 
Temp 30 – 40 – zaczyna być słabo, bo gorąco
Temp >= 40 – a weź wyprowadzam się na Alaskę.

-----------------------
TESTED: 01.01.2024
STATUS: OK 

*/

namespace Exc_09
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 09: Kategorie temperatury");
      VerbalMapper verbalMapper = new VerbalMapper();
      while (true)
      {
        try
        {
          // get input in cm and assign to category range
          int temperatureInCelsius = UserDataInput.GetTemperatureInCelsius();
          TemperatureCategory tc = RangeMapper.AssignToRange(temperatureInCelsius);

          // display category
          OutputView.DisplayResult(tc, verbalMapper);

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
