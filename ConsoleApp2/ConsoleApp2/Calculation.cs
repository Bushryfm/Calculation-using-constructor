using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculation
    {
       

        internal int value1, value2;
        internal Calculation(int a, int b)
        {
            value1 = a;
            value2 = b;

        }
        internal int Addition()
        {
            return value1 + value2;
        }

        internal int Subtraction()
        {
            return value1 - value2;
        }

        internal int Multiplication()
        {
        return value1 - value2;
        }

        internal int Division()
        { 
        return value1 -value2;


        }
    }
}
