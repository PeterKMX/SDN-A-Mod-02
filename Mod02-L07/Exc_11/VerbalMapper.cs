using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_11  
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
      _verbalMap.Add(6, "Celujący");
      _verbalMap.Add(5, "Bardzo dobry");
      _verbalMap.Add(4, "Dobry");
      _verbalMap.Add(3, "Dostateczny");
      _verbalMap.Add(2, "Dopuszczający");
      _verbalMap.Add(1, "Niedostateczny");
    }  
  }
}
