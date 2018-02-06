using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Calc
    {
       
        public int sum(int a, int b)
        {
            return (a + b);
        }
        public int substr(int a, int b)
        {
            return (a - b);
        }
        public int mult(int a, int b)
        {
            return (a * b);
        }
        public double div(int a, int b)
        {

            double a1;
            double b1;
            a1 = Convert.ToDouble(a);
            b1 = Convert.ToDouble(b);
            return (a1 / b1);
        }
    }
}
