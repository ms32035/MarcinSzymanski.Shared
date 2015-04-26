using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarcinSzymanski.Shared.Classess
{
    public static class Validators
    {

       public static bool NumericRange(string txtValue, float minValue, float maxValue)
        {

            float TestValue;

            try
            {
                TestValue = float.Parse(txtValue);
            }
            catch
            {
                return false;
            }


            if (TestValue < minValue || TestValue > maxValue)
                return false;

            return true;
        }

       public static bool NumericRangeOpen(string txtValue, float minValue, float maxValue)
       {

           float TestValue;

           try
           {
               TestValue = float.Parse(txtValue);
           }
           catch
           {
               return false;
           }


           if (TestValue <= minValue || TestValue >= maxValue)
               return false;

           return true;
       }

       public static bool Numeric(string txtValue)
       {

           float TestValue;

           try
           {
               TestValue = float.Parse(txtValue);
           }
           catch
           {
               return false;
           }

           return true;
       }

       public static bool Integer(string txtValue)
       {

           int TestValue;

           try
           {
               TestValue = int.Parse(txtValue);
           }
           catch
           {
               return false;
           }

           return true;
       }

    }


}
