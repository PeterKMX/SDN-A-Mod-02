using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
  public class ParserResult
  {
    public List<int> NumbersList { get; set; }  
    public bool Error { get; set; }  

    public ParserResult() 
    { 
      this.NumbersList = new List<int>(); 
    } 
  }
}
