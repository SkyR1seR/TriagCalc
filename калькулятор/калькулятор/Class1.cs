using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор
{
    class Class1
    {
        public int Perimeter(int a, int b, int c) => a + b + c;

        public double Area(int a, int b, int c)
        {
            var P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
        public int Check(int a, int b, int c)
        {
            if (a > 0 & b > 0 & c > 0)
            {
                if ((b + c) > a & (a + c) > b & (a + b) > c)
                {
                    return Perimeter(a, b, c);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
