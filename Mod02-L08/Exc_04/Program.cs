/*
4. Napisz program, który po podaniu liczby całkowitej wyświetli 
piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
1             size = 1, start = 1
2 3           2                 2 = 1 + 1
4 5 6         3                 4 = 2 + 2
7 8 9 10      4                 7 = 4 + 3
-------------------------------------------------------------------------


------------------------------------------------------------------
DATE TESTED: 2024.01.07
STATUS: OK

*/




namespace Exc_04
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Excercise 04: pyramid");

      while (true) {

        try {

        } catch (Exception ex) {
          Console.WriteLine("An error occured:\r\n" + ex.ToString());
          Console.WriteLine("Stopping application");
          break;

        } finally { }

        int maxValue = UserDataInput.GetNumber();
        Console.WriteLine(); 

        int i = 1;
        int len = 0;
        List<int> buffer = new List<int>();
        while (i <= maxValue) {
          len += 1;
          buffer = Collect(ref i, len, maxValue);
          foreach (int item in buffer) {
            Console.Write(item.ToString("D3") + " ");
          }
          Console.WriteLine();
        }

        Console.WriteLine("Try again ? (y/n)");
        string x = Console.ReadLine();
        if (x == "y") { continue; } else break;
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to exit ...");
      string s = Console.ReadLine();
    }

    private static List<int> Collect(ref int i, int len, int maxValue)
    {
      // collects current buffer of length l
      int currBufferMax = i + len - 1; 
      List<int> buffer = new List<int>(); 
      while (i <= currBufferMax && i <= maxValue) 
      { 
        buffer.Add(i);
        i += 1; 
      }
      return buffer;  
    }
  }
}
