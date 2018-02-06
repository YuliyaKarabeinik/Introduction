using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Check
    {
        public bool checkSwitch(int param)
        {
            if (param == 1 || param == 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please input correct number.");
                return false;
            }
        }

    }
}
