using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    static class Round
    {
        static public double Get_l(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double Get_s(double r)
        {
            return Math.PI * r * r;
        }
        static public bool Get_isIn(double r, double x,double y)
        {
            double l = Math.Sqrt(x*x+y*y);
            if (l>r) return false;
            else return true;
        }

    }
}
