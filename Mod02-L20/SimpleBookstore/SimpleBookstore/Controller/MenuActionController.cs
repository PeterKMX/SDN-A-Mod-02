using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookstore.Controllers
{
  internal class MenuActionController
  {
    private BookItemService _bookItemService;

    //--------------------------------------------------
    public MenuActionController() 
    {
      _bookItemService = new BookItemService();
    } 
    //----------------------------------------------------------
    public void ProcessUserAction(ActionTypes userActionType) 
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
      switch (userActionType)
      {
        case ActionTypes.AddBook:
          _bookItemService.AddBook();
          break;
        case ActionTypes.ReadDetails:
          _bookItemService.ReadBookDetails();
          break;
        case ActionTypes.EditBook:
          _bookItemService.EditBook();
          break;
        case ActionTypes.RemoveBook:
          _bookItemService.RemoveBook();
          break;
        case ActionTypes.ViewBooksList:
          _bookItemService.ShowBooksList();
          break;
        case ActionTypes.AutogenBooksList:
          _bookItemService.AutogenBooksList();
          break;
        default:
          throw new Exception("Error: unknown book action");
      }
    }
  }
}
