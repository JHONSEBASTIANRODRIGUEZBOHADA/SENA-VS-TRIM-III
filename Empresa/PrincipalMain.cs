using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            int Options = 0;
            do
            {
                try
                {
                    OptionMenu options = new OptionMenu();
                    Arrays array = new Arrays();
                    Methods method = new Methods();
                    options.MainOptions();
                    Options = int.Parse(Console.ReadLine());
                    switch(Options)
                    {
                        case 1:
                            options.ArrayOptions();
                            Options = int.Parse(Console.ReadLine());
                            switch (Options)
                            {
                                case 1:
                                    Console.Clear();
                                    array.FinalGrade();
                                    break;

                                case 2:
                                    Console.Clear();
                                    array.CustomerData();
                                    break;

                                case 3:
                                    Console.Clear();
                                    array.SumPriceProducts();
                                    break;

                                case 4:
                                    options.Leave();
                                    break;

                                default:
                                    Console.WriteLine("You entered invalid data");
                                    break;
                            }
                            break;

                        case 2:
                            options.MethodsOptions();
                            Options = int.Parse(Console.ReadLine());
                            switch(Options)
                            {
                                case 1:
                                    Console.Clear();
                                    options.CurrencyConverterOptions();
                                    Options = int.Parse(Console.ReadLine());
                                    switch(Options)
                                    {
                                        case 1:
                                            Console.Clear();
                                            method.CurrencyConverter1();
                                            break;

                                        case 2:
                                            Console.Clear();
                                            method.CurrencyConnverter2();
                                            break;
                                        
                                        case 3:
                                            Console.Clear();
                                            method.CurrencyConnverter3();
                                            break;

                                        case 4:
                                            Console.Clear();
                                            method.CurrencyConnverter4();
                                            break;

                                        case 5:
                                            Console.Clear();
                                            method.CurrencyConnverter5();
                                            break;

                                        case 6:
                                            options.Leave();
                                            break;

                                        default:
                                            Console.WriteLine("You entered invalid data");
                                            break;
                                    }
                                    break;

                                case 2:
                                    Console.Clear();
                                    method.AreaRectangle();
                                    break;

                                case 3:
                                    Console.Clear();
                                    method.AgeEntered();
                                    break;

                                case 4:
                                    Console.Clear();
                                    method.MultiplicationTable(1);
                                    break;

                                case 5:
                                    options.Leave();
                                    break;

                                default:
                                    Console.WriteLine("You entered invalid data");
                                    break;
                            }
                            break;

                        case 9:
                            options.Leave();
                            break;

                        default:
                            Console.WriteLine("You entered invalid data");
                            break;
                    }
                }catch(FormatException e)
                {
                    Console.WriteLine("You entered invalid data");
                }
            } while (true && Options != 9); //Options != 3 && Options != 4 && Options != 5 && Options != 6
;       }
    }
}
