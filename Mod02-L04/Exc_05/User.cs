using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_05
{
  public class User
  {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }  
    public char Gender { get; set; }
    //e.PESEL https://en.wikipedia.org/wiki/PESEL must be 11 digits
    public long Pesel { get; set; }

    public User()
    { }
  }
}
