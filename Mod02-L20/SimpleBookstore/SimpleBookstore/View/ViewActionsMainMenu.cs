using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookstore.View
{
  internal class ViewActionsMainMenu
  {
    private MainMenuService _menuService;

    //----------------------------------------------------------
    public ViewActionsMainMenu(MainMenuService menuService) 
    {
      _menuService = menuService;
    } 
    //-----------------------------------------
    public int RequestMenuID()
    {
      string menuLines = _menuService.GetMenuAsText();
      Console.Write(menuLines); 

      string commandText = "Enter your menu choice:";
      Console.WriteLine(commandText);

      // user types menu choice {1,2,3 ...7}
      return ReplyWithMenuID(commandText);
    }
    //-------------------------------------------------------------------------
    private int ReplyWithMenuID(String commandText)
    {
      List<int> allowedMenuIdList = this._menuService.GetExistingMenuIdList();  

      bool error = false;
      int errCount = 0;
      int number = 0;

      // read reply
      string tmp = Console.ReadLine();

      // parse
      error = !int.TryParse(tmp, out number);
      if (!error)
      {
        error = !allowedMenuIdList.Contains(number);
      }

      string errMsg = "Too many errors on input...";
      while (error)
      {
        errCount++;
        if (errCount >= 3)
        {
          throw new Exception(errMsg);
        }

        Console.WriteLine($"Incorrect input ({tmp}) Please correct your input:");
        tmp = Console.ReadLine();

        // parse
        error = !int.TryParse(tmp, out number);
        if (!error)
        {
          error = !allowedMenuIdList.Contains(number);
        }
      }

      return number; 
    }
  }
}
