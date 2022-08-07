using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoPersona
{
    internal class Empleado : Persona
    {
        double sueldo;

        public Empleado() { }

        public double Sueldo { get => sueldo; set => sueldo = value; }

        public void ImprimirSueldo()
        {
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
