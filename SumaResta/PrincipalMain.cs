using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            int opciones = 0;
            bool Error;
            do
            {
                try
                {
                    Resta operaciones = new Resta();
                    Console.WriteLine("\nIngrese la operacion que desea realizar \n1.Suma \n2.Resta \n3.Salir");
                    opciones = int.Parse(Console.ReadLine());
                    switch (opciones)
                    {
                        case 1:
                            Error = false;
                            while (!Error)
                            {
                                try
                                {
                                    Console.WriteLine("\nSUMA");
                                    Console.WriteLine("\nIngrese un numero");
                                    operaciones.Valor1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el siguiente numero");
                                    operaciones.Valor2 = int.Parse(Console.ReadLine());

                                    if(!Error)
                                    {
                                        Error = true;
                                        if(operaciones.Valor1 < 0 || operaciones.Valor2 < 0)
                                        {
                                            Console.WriteLine("Ingreso un valor negativo");
                                            Error = false;
                                        }
                                        else
                                        {
                                            operaciones.Operar();
                                            Error = true;
                                        }
                                    }
                                }
                                catch(OverflowException ex)
                                {
                                    Console.WriteLine("Ingreso un valor muy largo");
                                    Error = false;
                                }
                                catch(FormatException ex)
                                {
                                    Console.WriteLine("No ingreso un valor numerico");
                                    Error = false;
                                }
                            }
                            break;

                        case 2:
                            Error = false;
                            while (!Error)
                            {
                                try
                                {
                                    Console.WriteLine("\nRESTA");
                                    Console.WriteLine("\nIngrese un numero");
                                    operaciones.Valor1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el siguiente numero");
                                    operaciones.Valor2 = int.Parse(Console.ReadLine());

                                    if (!Error)
                                    {
                                        Error = true;
                                        if (operaciones.Valor1 < 0 || operaciones.Valor2 < 0)
                                        {
                                            Console.WriteLine("Ingreso un valor negativo");
                                            Error = false;
                                        }
                                        else
                                        {
                                            operaciones.Operar2();
                                            Error = true;
                                        }
                                    }
                                }
                                catch(OverflowException ex)
                                {
                                    Console.WriteLine("Ingreso un valor muy largo");
                                }
                                catch(FormatException ex)
                                {
                                    Console.WriteLine("No ingreso un valor numerico");
                                }
                            }
                            break;

                        case 3:
                            operaciones.Salir();
                            break;

                        default:
                            Console.WriteLine("Ingreso un valor incorrecto");
                            break;
                    }
                }catch(FormatException ex)
                {
                    Console.WriteLine("Ingreso un valor incorrecto");
                }
            } while (opciones != 3);
        }
    }
}
