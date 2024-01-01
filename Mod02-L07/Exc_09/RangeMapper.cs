using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_09
{
/*
Temp < 0 – cholernie zimno 
Temp 0 – 10 – zimno
Temp 10 – 20 – chłodno
Temp 20 – 30 – w sam raz 
Temp 30 – 40 – zaczyna być słabo, bo gorąco
Temp >= 40 – a weź wyprowadzam się na Alaskę.
*/

  public enum TemperatureCategory
  {
    ExtremelyCold,
    Cold,
    ABitCool,
    Nice,
    Hot,
    SweatingHot
  }

  internal class RangeMapper
  {
    public RangeMapper() { }

    public static TemperatureCategory AssignToRange(int t) 
    {
      TemperatureCategory tc = TemperatureCategory.Nice;

      if (t < 0)                   { tc = TemperatureCategory.ExtremelyCold; } 
      else if (t > 0  && t <= 9 )  { tc = TemperatureCategory.Cold; } 
      else if (t > 10 && t <= 20)  { tc = TemperatureCategory.ABitCool; } 
      else if (t > 20 && t <= 30)  { tc = TemperatureCategory.Nice; } 
      else if (t > 30 && t <= 40)  { tc = TemperatureCategory.Hot; } 
      else if (t > 40)             { tc = TemperatureCategory.SweatingHot; }
      else                         { tc = TemperatureCategory.SweatingHot; }


      return tc; 
    }
  }
}
