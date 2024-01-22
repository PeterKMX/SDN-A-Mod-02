using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exc_11  
{

  public class ScoreMapper
  {

    public ScoreMapper() 
    {

    }

    internal string GetTextByIndex(int i)
    {
      string scoreText = string.Empty;

      switch (i) 
      {
        case 1:
          scoreText = "Niedostateczny";
          break;
        case 2:
          scoreText = "Dopuszczający";
          break;
        case 3:
          scoreText = "Dostateczny";
          break;
        case 4:
          scoreText = "Dobry";
          break;
        case 5:
          scoreText = "Bardzo dobry";
          break;
        case 6:
          scoreText = "Celujący";
          break;
        default:
          scoreText = "Unknown score: " + i;
          break;
      }

      return scoreText; 
    }
  }
}
