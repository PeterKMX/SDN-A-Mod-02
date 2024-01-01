using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_06
{

  public class VerbalMapper
  {
    private Dictionary<HeightCategory, string> _verbalMap; 

    public VerbalMapper() 
    {
      _verbalMap = new Dictionary<HeightCategory, string>();
      Initialize();
    }

    internal string GetTextByCategory(HeightCategory hc)
    {
      if (_verbalMap.ContainsKey(hc)) {
        return _verbalMap[hc];  
      } else {
        return "Unknown category";
      }
    }

    private void Initialize () 
    {
      /*  public enum HeightCategory
          {
            // dataTooLow
            DataTooLow,
            // dwarf
            Dwarf,
            // short
            Short,
            // normal
            Normal,
            // tall
            Tall,
            // veryTall
            VeryTall,
            // giant
            Giant,
            // dataTooHigh
            DataTooHigh,
            // dataInvalid
            DataInvalid
          }*/

      _verbalMap.Add(HeightCategory.DataTooLow, "Height input data too low");
      _verbalMap.Add(HeightCategory.Dwarf, "You are a dwarf");
      _verbalMap.Add(HeightCategory.Short, "You are a short person");
      _verbalMap.Add(HeightCategory.Normal, "You are a person of normal height");
      _verbalMap.Add(HeightCategory.Tall, "You are a tall person");
      _verbalMap.Add(HeightCategory.VeryTall, "You are a very tall person");
      _verbalMap.Add(HeightCategory.Giant, "You are a giant person");
      _verbalMap.Add(HeightCategory.DataTooHigh, "Height input data too high");
      _verbalMap.Add(HeightCategory.DataInvalid, "Height input data is invalid");
    }  
  }
}
