using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_06
{
  /*
Invalid input ....         < 40 // handle in user input
You are a dwarf             40 - 140
You are a short person     141 - 160
You are a normal person    161 - 180
You are a tall person      181 - 200
You are a very tall person 201 - 220 
You are a giant            221 - 280
Invalid input ....         > 281 // handle in user input 
  */

  public enum HeightCategory
  { 
      // dataTooLow
      DataTooLow,
      // dwarf
      Dwarf,
      // short
      Short,
      // normal
      Normal,
      // tall
      Tall,
      // veryTall
      VeryTall,
      // giant
      Giant,
      // dataTooHigh
      DataTooHigh,
      // dataInvalid
      DataInvalid
  }

  internal class RangeMapper
  {
    public RangeMapper() { }

    public static HeightCategory AssignToRange(int age) 
    {
      HeightCategory heightCategory = HeightCategory.Normal;

      if (age <= 40)                     { heightCategory = HeightCategory.DataTooLow; } 
      else if (age > 41  && age <= 140 ) { heightCategory = HeightCategory.Dwarf; } 
      else if (age > 141 && age <= 160)  { heightCategory = HeightCategory.Short; } 
      else if (age > 161 && age <= 180)  { heightCategory = HeightCategory.Normal; } 
      else if (age > 181 && age <= 200)  { heightCategory = HeightCategory.Tall; } 
      else if (age > 201 && age <= 220)  { heightCategory = HeightCategory.VeryTall; } 
      else if (age > 221 && age <= 280)  { heightCategory = HeightCategory.Giant; }
      else if (age > 281)                { heightCategory = HeightCategory.DataTooHigh; }
      else                               { heightCategory = HeightCategory.DataInvalid; }


      return heightCategory; 
    }
  }
}
