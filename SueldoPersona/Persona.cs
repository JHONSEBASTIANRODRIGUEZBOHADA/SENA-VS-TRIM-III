using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoPersona
{
    internal class Persona
    {
        string nombre;
        int edad;

        public Persona() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public void Imprimir()
        {
            Console.WriteLine("\nDATOS DE LA PERSONA");
            Console.WriteLine($"\nNombre: {Nombre} \nEdad: {Edad}");
        }
    }
}
