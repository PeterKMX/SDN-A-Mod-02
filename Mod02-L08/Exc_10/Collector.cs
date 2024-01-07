using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_10
{
  public class Collector
  {
    private Dictionary<int,int> _memory = null;
    public Collector() 
    { 
      _memory = new Dictionary<int,int>();  
    }

    public void Add(int n) 
    { 
      if (!_memory.ContainsKey(n)) 
      { 
        _memory.Add(n, 0); // we use only keys
      }
    }
    public bool Find(int n)
    {
      if (_memory.ContainsKey(n)) return true;
      return false; 
    }

  }
}
