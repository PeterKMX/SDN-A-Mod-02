using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBookstore.View;

namespace SimpleBookstore
{
  public class MainMenu
  {
    private MainMenuService _menuService;
    private ViewActionsMainMenu _viewActionsMainMenu;

    //--------------------------------------------------
    private MainMenu() { }

    //-------------------------------------------------------
    public MainMenu(MainMenuService menuService) 
    { 
      _viewActionsMainMenu = new ViewActionsMainMenu(menuService);
    }
    //-----------------------------------------------------------
    public ActionTypes SelectFromActionsMenu()
    {
      int mainMenuID = _viewActionsMainMenu.RequestMenuID(); 
      ActionTypes actionType = ConvertToActionType(mainMenuID);
      
      return actionType; 
    }
    //-----------------------------------------------------------------
    private ActionTypes ConvertToActionType(int menuId)
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
      switch (menuId) 
      {
        case 1: return ActionTypes.AddBook;
        case 2: return ActionTypes.ReadDetails; 
        case 3: return ActionTypes.EditBook; 
        case 4: return ActionTypes.RemoveBook;
        case 5: return ActionTypes.ViewBooksList;
        case 6: return ActionTypes.AutogenBooksList;
        case 7: return ActionTypes.Exit; 
        default: throw new Exception("Unknown menu item Id"); 
      } 
    }
  }
}
