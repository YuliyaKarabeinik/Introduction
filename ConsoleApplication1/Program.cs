using System;
using ClassLibrary1;
using System.Configuration;
using System.Collections.Specialized;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Check check = new ConsoleApplication1.Check();
            int config = 0;
            do
            {

                Console.WriteLine("Please input 1 to use data from file or 2 to input by yourself.");
                try
                {
                    config = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error!Bad Format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error!Overflow");
                }
            } while (check.checkSwitch(config) == false);
            switch (config)
            {
                case 1:
                    ConfigurationManager.AppSettings.Set("Input", "1"); //set value 1 to configuration file (read from file)

                    break;
                case 2:
                    ConfigurationManager.AppSettings.Set("Input", "2");//set value 2 to configuration file (read from console)
                    break;

            }

            string app = ConfigurationManager.AppSettings.Get("Input");

            switch (app)
            {
                case "1": //read from file


                    FromFile fromFile = new FromFile();
                    int[] array = new int[2];
                    array = fromFile.getNumb();
                    int a1 = array[0];
                    int b1 = array[1];
                    Calc calc1 = new Calc();
                    Console.WriteLine("Sum:" + calc1.sum(a1, b1));
                    Console.WriteLine("Substraction:" + calc1.substr(a1, b1));
                    Console.WriteLine("Multiplication:" + calc1.mult(a1, b1));

                    if (b1 != 0)
                    {
                        Console.WriteLine("Division:" + calc1.div(a1, b1));
                    }
                    else
                    {
                        Console.WriteLine("Cannot be divided into 0");
                    }

                    Console.ReadKey();
                    break;
                case "2": //read from console



                    int config1 = 0;
                    do
                    {
                        Console.WriteLine("Please input 1 to use library methods or 2 to use application method.");
                        try
                        {
                            config1 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error!Bad Format");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error!Overflow");
                        }
                    } while (check.checkSwitch(config1) == false);
                    switch (config1)
                    {
                        case 1:
                            ConfigurationManager.AppSettings.Set("Calculate", "1"); //set value 1 to configuration file (from library)

                            break;
                        case 2:
                            ConfigurationManager.AppSettings.Set("Calculate", "2");//set value 2 to configuration file (from app)
                            break;

                    }
                    string app1 = ConfigurationManager.AppSettings.Get("Calculate");

                    Input input = null;
                    int a, b;
                    switch (app1)
                    {


                        case "1":

                            input = new ConsoleApplication1.Input();
                            int sum;
                            sum = input.numberSum();
                            Console.WriteLine("The sum:" + sum);
                            Console.WriteLine("______________________");

                            Console.ReadKey();
                            break;

                        case "2":

                            Calc calc = new Calc();

                            if (input == null)
                            {
                                input = new ConsoleApplication1.Input();
                                Console.WriteLine("Enter first number.");
                                a = input.inputNumber();
                                Console.WriteLine("Enter second number.");
                                b = input.inputNumber();
                            }
                            else
                            {
                                a = input.a;
                                b = input.b;
                            }
                            Console.WriteLine("Sum:" + calc.sum(a, b));
                            Console.WriteLine("Substraction:" + calc.substr(a, b));
                            Console.WriteLine("Multiplication:" + calc.mult(a, b));

                            if (b != 0)
                            {
                                Console.WriteLine("Division:" + calc.div(a, b));
                            }
                            else
                            {
                                Console.WriteLine("Cannot be divided into 0");
                            }

                            Console.ReadKey();
                            break;
                    }

                    break;


            }
        }
    }
}

