using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Library
{
    internal static class Factorial
    {


      public  static long CalculateFactorial(int number)
        {
            if( number > 0 )
            {
                int tempno = 1;
                for (int i = 1; i <= number; i++)
                {

                    tempno *= i;
                }
                return tempno;
            }

            return 0;
        }

    }
}
