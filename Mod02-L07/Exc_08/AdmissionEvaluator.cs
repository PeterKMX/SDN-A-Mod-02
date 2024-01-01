using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/*
wg. Następujących kryteriów: 

Wynik z Matury z matematyki powyżej 70 
Wynik z fizyki powyżej 55 
Wynik z chemii powyżej 45 

Łączny wynik z 3 przedmiotów powyżej 180 

Albo
Wynik z matematyki i jednego przedmiotu powyżej 150 
*/
namespace Exc_08
{
  public class AdmissionEvaluator
  {

    public AdmissionEvaluator() { } 
    public static bool IsAdmitted(int math, int physics, int chemistry) 
    {
      bool isAdmitted = false;
      isAdmitted = ApplyMethod1(math, physics, chemistry); 
      if (!isAdmitted) {
        isAdmitted = ApplyMethod2(math, physics, chemistry);
      }

      return isAdmitted;
    }

    private static bool ApplyMethod1(int math, int physics, int chemistry)
    {
      /*
       wg. Następujących kryteriów: 

          Wynik z Matury z matematyki powyżej 70 
          Wynik z fizyki powyżej 55 
          Wynik z chemii powyżej 45 

          Łączny wynik z 3 przedmiotów powyżej 180 
      */
      bool admittedMethod1 = false;  

      bool mathAdmited = false;
      bool physicsAdmited = false;
      bool chemistryAdmited = false;

      if (math > 70) mathAdmited = true;
      if (physics > 55) physicsAdmited = true;
      if (chemistry > 45) chemistryAdmited = true;

      if (mathAdmited && physicsAdmited && chemistryAdmited) {
        // but sum must be above 180
        if ((math + physics + chemistry) > 180) admittedMethod1 = true;
      } 
      return admittedMethod1; 
    }

    private static bool ApplyMethod2(int math, int physics, int chemistry)
    {
      /*
          Albo
          Wynik z matematyki i jednego przedmiotu powyżej 150  
      */

      bool admittedMethod2 = false;

      // check math + physics
      if ((math + physics) > 150 ) admittedMethod2 = true;

      // check math + chemistry
      if ((math + chemistry) > 150) admittedMethod2 = true;

      return admittedMethod2; 
    }
  }
}
