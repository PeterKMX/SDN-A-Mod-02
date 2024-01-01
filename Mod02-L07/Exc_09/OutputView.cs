using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_09
{
  public class OutputView
  {
    public OutputView() { }

    internal static void DisplayResult(TemperatureCategory tc, VerbalMapper verbalMapper)
    {
      string categoryText = verbalMapper.GetTextByCategory(tc);
      Console.WriteLine(categoryText);  
    }
  }
}
