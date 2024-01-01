using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_05
{
  public class AgeMapper
  {
    private List<KeyValuePair<int, string>> _politicalRoles;  
    public AgeMapper() 
    {
      Initialize();
    }

    public void Initialize() 
    {
      _politicalRoles = new List<KeyValuePair<int, string>>(5);
      _politicalRoles.Add(new KeyValuePair<int, string>(21, "poslem"));
      _politicalRoles.Add(new KeyValuePair<int, string>(21, "premierem"));
      _politicalRoles.Add(new KeyValuePair<int, string>(30, "senatorem"));
      _politicalRoles.Add(new KeyValuePair<int, string>(35, "prezydentem"));
    }
    public string GetMapping(int age)
    {
      string list = "";

      foreach (KeyValuePair<int,string> kvp in _politicalRoles) { 
        if (kvp.Key <= age) {
          list += kvp.Value + " ";
        }
      }

      return list.Trim();
    }
  }
}
