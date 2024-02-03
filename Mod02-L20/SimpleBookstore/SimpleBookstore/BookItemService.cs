using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleBookstore.View;
using SimpleBookstore.Backend;

namespace SimpleBookstore
{
  public class BookItemService
  {
    private ViewActionsBookItem _viewActionsBookItem;

    //-----------------------------------------------------
    public BookItemService() 
    { 
      //_view_bookDataView = view_bookDataView;
      _viewActionsBookItem = new ViewActionsBookItem();  
    } 
    //------------------------------------------------------------
    public void ShowBooksList()
    {
      List<BookItem> booksList = BackendInMemoryStore.GetBooksList();
      _viewActionsBookItem.ShowBookList(booksList);
    }
    //---------------------------------------------------------
    internal void AddBook()
    {
      // create a new BookItem in View, no book ID is known yet 
      BookItem book = _viewActionsBookItem.CreateBook();

      // add to backend: generates unique book id
      BackendInMemoryStore.AddBook(book);

      Console.WriteLine("[DONE]");
    }
    //---------------------------------------------------------------------
    public void EditBook() 
    {
      // must know valid book ids 
      List<int> validBookIdsList = BackendInMemoryStore.GetValidBookIds();

      // which book ? - user selects book id 
      int bookToEditId = _viewActionsBookItem.RequestBookID(validBookIdsList);

      // gets book object  
      BookItem currentBook = BackendInMemoryStore.GetBookById(bookToEditId);
      
      // edit book in view 
      //BookItem editedBook = ViewActionsBookCreateEdit.EditBook(currentBook);
      BookItem editedBook = _viewActionsBookItem.EditBook(currentBook);

      //  replace in backend (use book Id)
      BackendInMemoryStore.ReplaceCurrentBook(currentBook, editedBook);

      Console.WriteLine("[DONE]");
    }
    //------------------------------------------------------------------------------
    public void RemoveBook()
    {
      // ask backend for valid book ids 
      List<int> validBookIdsList = BackendInMemoryStore.GetValidBookIds();

      // select book id to delete from list visible in view
      int bookToRemoveId = _viewActionsBookItem.RequestBookID(validBookIdsList);

      // remove book
      BackendInMemoryStore.RemoveBookById(bookToRemoveId);

      Console.WriteLine("[DONE]");
    }
    //-------------------------------------------------
    internal void AutogenBooksList()
    {
      Console.WriteLine("[Adding 3 books...]");
      // add 3 books to backend
      BookItem bookItem = null; 
      
      bookItem = new BookItem();
      bookItem.Title = "The C# Programming Language";
      bookItem.Authors = "Anders Hejlsberg";
      bookItem.Publisher = "Wiley";
      bookItem.Year = 2014;
      BackendInMemoryStore.AddBook(bookItem);

      bookItem = new BookItem();
      bookItem.Title = "Beginning gRPC with ASP.NET Core 6";
      bookItem.Authors = "Anthony Giretti";
      bookItem.Publisher = "Apress";
      bookItem.Year = 2022;
      BackendInMemoryStore.AddBook(bookItem);

      bookItem = new BookItem();
      bookItem.Title = "Learn PHP 8";
      bookItem.Authors = "Steve Prettyman";
      bookItem.Publisher = "Apress";
      bookItem.Year = 2020;
      BackendInMemoryStore.AddBook(bookItem);

      Console.WriteLine("[DONE]");
    }

    internal void ReadBookDetails()
    {
      // ask backend for valid book ids 
      List<int> validBookIdsList = BackendInMemoryStore.GetValidBookIds();

      // select book id to show from list visible in view
      int bookID= _viewActionsBookItem.RequestBookID(validBookIdsList);

      // get book to show from backend
      BookItem book = BackendInMemoryStore.GetBookById(bookID);

      // show book 
      _viewActionsBookItem.ShowBook(book);
    }


  }
}
