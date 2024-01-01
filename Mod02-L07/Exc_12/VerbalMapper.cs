using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_12  
{

  public class VerbalMapper
  {
    private Dictionary<int, string> _verbalMap; 

    public VerbalMapper() 
    {
      _verbalMap = new Dictionary<int, string>();
      Initialize();
    }

    internal string GetTextByIndex(int i)
    {
      if (_verbalMap.ContainsKey(i)) {
        return _verbalMap[i];  
      } else {
        return "Unknown index";
      }
    }

    private void Initialize () 
    {
      _verbalMap.Add(7, "Niedziela");
      _verbalMap.Add(6, "Sobota");
      _verbalMap.Add(5, "Piatek");
      _verbalMap.Add(4, "Czwartek");
      _verbalMap.Add(3, "Sroda");
      _verbalMap.Add(2, "Wtorek");
      _verbalMap.Add(1, "Poniedzialek");
    }  
  }
}
