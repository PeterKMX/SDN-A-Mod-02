using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_07
{
  public class DiamondCreator
  {

    public DiamondCreator() 
    { 
    
    }

    public int[,] CreateShape(int nDiagonal)
    {
      // creates a 2d array of 0 and 1
      // which is a model of the drawing area of size 
      // nDiagonal x nDiagonal

      int[,] arr2d = new int[nDiagonal, nDiagonal];

      int x0 = ((nDiagonal + 1) / 2) - 1;   
      int y0 = x0; 
      int imin = 0;
      int imax = 0; 

      // at each iteration through jy 
      // - the picture height coordinate (jy) is fixed
      // - and we decide what to put on each "line" : 0, or 1 

      for (int jy = 0; jy < nDiagonal; jy++) {

        for (int ix = 0; ix < nDiagonal; ix++) {
          arr2d[ix, jy] = 0;
        }

        imin = Math.Abs(x0 - jy); 
        imax = x0 + jy;
        if (imax >= nDiagonal - 1) {
          imax = x0 + nDiagonal - 1 - jy; 
        }
        // fill out the values marking the diamond 
        // on each horizontal line netween imin and imax
        for (int ix = imin; ix <= imax; ix++) {
          arr2d[ix, jy] = 1;
        }
      }
      return arr2d; 
    }

  }
}
