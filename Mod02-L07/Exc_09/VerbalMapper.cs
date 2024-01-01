using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_09  
{

  public class VerbalMapper
  {
    private Dictionary<TemperatureCategory, string> _verbalMap; 

    public VerbalMapper() 
    {
      _verbalMap = new Dictionary<TemperatureCategory, string>();
      Initialize();
    }

    internal string GetTextByCategory(TemperatureCategory tc)
    {
      if (_verbalMap.ContainsKey(tc)) {
        return _verbalMap[tc];  
      } else {
        return "Unknown category";
      }
    }

    private void Initialize () 
    {
      _verbalMap.Add(TemperatureCategory.ExtremelyCold, "Cholernie zimno");
      _verbalMap.Add(TemperatureCategory.Cold, "Zimno");
      _verbalMap.Add(TemperatureCategory.ABitCool, "Chłodno");
      _verbalMap.Add(TemperatureCategory.Nice, "W sam raz");
      _verbalMap.Add(TemperatureCategory.Hot, "Zaczyna być słabo, bo gorąco");
      _verbalMap.Add(TemperatureCategory.SweatingHot, "A weź wyprowadzam się na Alaskę");

    }  
  }
}
