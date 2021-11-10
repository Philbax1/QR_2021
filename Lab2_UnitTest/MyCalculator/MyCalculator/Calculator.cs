using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Divide(int dividend, int divisor)
        { 
            return dividend / divisor;
        }

        public int Method1(int var1, int var2, int var3)
        {
            return (var1 + var2) - var3;
        }
        public int Method2(int var1, int var2)
        {
            return var1 + var2;
        }
        public int Method3(int var1, int var2)
        {
            return var1 / var2;
        }
        public int Method4(int var1, int var2, int var3, int var4)
        {
            return ((var1 + var2) - var3 ) * var4;
        }
        public string Method5(string var1, int var2)
        {
            return var1 + var2.ToString();
        }

    }

    
}
