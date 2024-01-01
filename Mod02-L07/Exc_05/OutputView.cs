using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_05
{
  public class OutputView
  {
    public OutputView() { }

    internal static void DisplayResult(int age, AgeMapper mapper)
    {
      string functions = mapper.GetMapping(age); 

      Console.WriteLine($"Możesz zostać: {functions}.");  
    }
  }
}
