using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_07
{
  public class DiamondViewer
  {

    public DiamondViewer() { }

    public void Show(int[,] arr2d, int nDiagonal) 
    {
      // display all elements of the canvas
      for (int jy = 0; jy < nDiagonal; jy++) {

        for (int ix = 0; ix < nDiagonal; ix++) {
          if (arr2d[ix, jy] == 1) Console.Write("*");
          else Console.Write(" ");
        }
        Console.Write("\r\n");
      }

    }
  }
}
