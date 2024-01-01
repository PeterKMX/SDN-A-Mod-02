using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_06
{
  public class OutputView
  {
    public OutputView() { }

    internal static void DisplayResult(HeightCategory hc, VerbalMapper verbalMapper)
    {
      string categoryText = verbalMapper.GetTextByCategory(hc);
      Console.WriteLine(categoryText);  
    }
  }
}
