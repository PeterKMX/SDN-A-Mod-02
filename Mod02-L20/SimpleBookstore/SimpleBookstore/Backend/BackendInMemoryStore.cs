using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace SimpleBookstore.Backend
{
  public static class BackendInMemoryStore 
  {
    private static BackendData? _backendData { get; set; }

    //------------------------------------------------------
    public static void Configure()
    {
        _backendData = new BackendData();
    }
    //-------------------------------------------------
    internal static List<BookItem> GetBooksList()
    {
      return _backendData.books;
    }
    //---------------------------------------------
    public static int GetBooksCount()
    {
      return _backendData.books.Count;
    }
    //-------------------------------------
    internal static void AddBook(BookItem book)
    {
      book.Id = GetNewId();
      _backendData.books.Add(book);  
    }
    //----------------------------------------------
    private static int GetNewId()
    {
      int highestCurrendtId = 0;
      
      List<int> idList = new List<int>(); 
      foreach (BookItem book in _backendData.books) 
      { 
        idList.Add(book.Id);
      }

      if (idList.Count > 0)
      {
        // sorts ascending
        idList.Sort();
        highestCurrendtId = idList[idList.Count - 1];
      }

      int newId = highestCurrendtId + 1;
      return newId;
    }
    //---------------------------------------------------------------------------------
    internal static void ReplaceCurrentBook(BookItem currentBook, BookItem editedBook)
    {
      // find index of the edited book in backend list
      int index = FindBookIndexById(editedBook.Id);

      // overwrite in list
      _backendData.books[index] = editedBook;  
    }
    //------------------------------------------------
    internal static BookItem GetBookById(int bookId)
    {
      BookItem? bookFound=null;
      foreach (BookItem bookx in _backendData.books)
      {
        if (bookx.Id == bookId) 
        {
          bookFound = bookx; 
          break; 
        }
      }

      if (bookFound == null) 
      { 
        throw new Exception($"Error: could not find book by Id {bookId}");  
      }
      return bookFound;
    }
    //----------------------------------------------------------------------
    internal static void RemoveBookById(int id)
    {
      int index = FindBookIndexById(id);  
      if (index != -1)
      {
        _backendData.books.RemoveAt(index);
      }
      else 
      {
        throw new Exception($"Error: Book {id} could not be removed");
      }
    }
    //-----------------------------------------------------------------
    private static int FindBookIndexById(int id)
    { 
      int index = -1; 
      for (int i = 0; i < _backendData?.books.Count; i++) 
      {
        if (_backendData.books[i].Id == id) 
        {
          index = i;
          break;
        }
      }

      return index; 
    }
    //-------------------------------------------------
    internal static List<int> GetValidBookIds()
    {
      
      List<int> bookIds = new List<int>();
      for (int i = 0; i < _backendData?.books.Count; i++)
      {
        bookIds.Add(_backendData.books[i].Id); 
      }

      return bookIds;
    }
  }
}
