using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookstore
{
  public class MainMenuService
  {
    private List<MainMenuItem> _menuItemsList;

    //------------------------------------------
    public MainMenuService() 
    {
      _menuItemsList = new List<MainMenuItem>();
    }
    //-----------------------------------------------------
    public void Configure() 
    {
      /*
        AddBook,
        ReadDetails,
        EditBook,
        RemoveBook,
        ViewBooksList,
        AutogenBooksList,
        Exit
      */

      _menuItemsList.Add(new MainMenuItem(1, "Add book to list"));
      _menuItemsList.Add(new MainMenuItem(2, "Read boek details"));
      _menuItemsList.Add(new MainMenuItem(3, "Edit book"));
      _menuItemsList.Add(new MainMenuItem(4, "Remove book from List"));
      _menuItemsList.Add(new MainMenuItem(5, "View book list"));
      _menuItemsList.Add(new MainMenuItem(6, "Autogenerate book list"));
      _menuItemsList.Add(new MainMenuItem(7, "Exit application"));
    }
    //----------------------------------------------------------------------
    public string GetMenuAsText()
    {
      StringBuilder sbMenuItems = new StringBuilder();
      sbMenuItems.AppendLine("Book Menu:");
      foreach (MainMenuItem item in _menuItemsList)
      {
        sbMenuItems.AppendLine($"{item.GetString()}");
      }
      return sbMenuItems.ToString(); 
    }
    //-------------------------------------------
    internal List<int> GetExistingMenuIdList()
    {
      List<int> ints = new List<int>();
      foreach (MainMenuItem item in _menuItemsList) 
      { 
        ints.Add(item.Id); 
      }  

      return ints;  
    }
  }
}
