using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
  public class BuildTriangle
  {
    public BuildTriangle() { }
    public static bool ListIsSuitable(List<int> list) 
    {
      bool isSuitable = false;
      list.Sort();

      //check 
      if (list[0] + list[1] > list[2]) { 
        isSuitable = true;
      } else {
        isSuitable = false;
      }
      return isSuitable;  
    }
  }
}
