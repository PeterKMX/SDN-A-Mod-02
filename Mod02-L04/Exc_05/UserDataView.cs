using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_05
{
  public class UserDataView
  {
    public UserDataView()
    { }
    public static void ShowUserData(User user) 
    {
      Console.WriteLine($"First name: {user.FirstName}");
      Console.WriteLine($"Last name: {user.LastName}");
      Console.WriteLine($"Email: {user.Email}");
      Console.WriteLine($"Age: {user.Age}");
      Console.WriteLine($"Weight: {user.Weight:###.###}");
      Console.WriteLine($"Gender: {user.Gender}");
      Console.WriteLine($"PESEL: {user.Pesel}");
    }

  }
}
