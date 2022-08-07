using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoPersona
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Persona datos = new Persona();
            Empleado dato = new Empleado();
            bool Error = false;

            Console.WriteLine("Ingrese su nombre");
            datos.Nombre = Console.ReadLine();
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Ingrese su edad");
                    datos.Edad = int.Parse(Console.ReadLine());

                    if(!Error)
                    {
                        Error = true;
                        if(datos.Edad < 0 || datos.Edad >= 130)
                        {
                            Console.WriteLine("Ingreso una edad incorrecta");
                            Error = false;
                        }
                    }
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Ingreso una edad muy larga");
                    Error = false;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("No ingreso un valor numerico");
                    Error = false;
                }
            }

            Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("Ingrese el sueldo");
                    dato.Sueldo = int.Parse(Console.ReadLine());

                    if(!Error)
                    {
                        Error = true;
                        if(dato.Sueldo < 0)
                        {
                            Console.WriteLine("Ingreso un valor negativo");
                            Error = false;
                        }
                        else
                        {
                            datos.Imprimir();
                            dato.ImprimirSueldo();
                            Error = true;
                        }
                    }
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Ingreso un sueldo muy larrgo");
                    Error = false;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("No ingreso un valor numerico");
                    Error = false;
                }
            }
        }
    }
}