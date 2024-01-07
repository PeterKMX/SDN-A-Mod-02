using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_01
{
  public class Person
  {
    //a.Imię
    public string FirstName { get; set; }
    //b.Nazwisko
    public string LastName { get; set; }
    //c.Wiek
    public int Age { get; set; }
    //d.Płeć (‘m’ albo ‘k’)
    public char Gender { get; set; }
    //e.PESEL https://en.wikipedia.org/wiki/PESEL must be 11 digits
    public string Pesel { get; set; }
    //f.Numer pracownika (np. 2509324094) 
    public long IdNumber { get; set; }
    
    public Person()
    { }
  }
}
