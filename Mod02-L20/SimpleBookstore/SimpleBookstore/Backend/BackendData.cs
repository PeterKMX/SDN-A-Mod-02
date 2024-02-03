using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookstore.Backend
{
  public class BackendData
  {
    public List<BookItem> books { get; set; }

    //-----------------------------------------
    public BackendData() 
    {
      books = new List<BookItem>();
    }
  }
}
