﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookstore
{
  public class MainMenuItem
  {
    public int Id { get; set; }
    public string Text { get; set; }

    //---------------------------
    public MainMenuItem() { }

    //-------------------------------------------
    public MainMenuItem(int id, string text) 
    { 
      Id = id;  
      Text = text;  
    }  
    //---------------------------
    public string GetString() 
    {
      return $"({Id}) {Text}";
    }
  }
}
