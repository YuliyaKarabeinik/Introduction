using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Input
    {
        public int a;
        public int b;
        public int numberSum()
        {

            Console.WriteLine("Enter first number.");
            a = inputNumber();
            Console.WriteLine("Enter second number.");
            b = inputNumber();
            return (a + b);

        }

        public int inputNumber()
        {
            string s;
           
            int numb = 0;
            s = Console.ReadLine();
            
                try
                {
                    numb = Convert.ToInt32(s);
               
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error!Bad Format");
               
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error!Overflow");
                }
           
            return numb;
        }

    }
}
