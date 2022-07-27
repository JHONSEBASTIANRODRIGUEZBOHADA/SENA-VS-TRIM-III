using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Arrays
    {
        public  void NotaFinal()
        {

            string[] nombre = { "Felipe", "Oscar", "Andrea", "kimberly" };
            float[] examenParcial = { 0, 6, 4, 9 };
            float[] examenOral =    { 7, 1, 3, 4 };
            float[] examenFinal =   { 8, 9, 1, 9 };
            float suma = 0;
            float promedio = 0;

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nNOMBRE: {nombre[i]} \nEXAMEN PARCIAL: {examenParcial[i]} \nEXAMEN ORAL: {examenOral[i]} \nEXAMEN FINAL: {examenFinal[i]}");
            }
            
            for(int i = 0; i < nombre.Length; i++)
            {
                suma = examenParcial[i] + examenOral[i] + examenFinal[i];
                promedio = suma / 3;
                if (promedio >= 7)
                {
                    Console.WriteLine($"\nNOMBRE: {nombre[i]} \nNOTA PROMEDIO: {promedio} APROBO");
                }
                else
                {
                    Console.WriteLine($"\nNOMBRE: {nombre[i]} \nNOTA PROMEDIO: {promedio} NO APROBO");
                }
            }
        }

        public void DatosClientes()
        {
            string[] nombre = new string[5];
            string[] apellido = new string[5];
            int[] edad = new int[5];
            string[] sexo = new string[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su apellido");
                apellido[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su sexo");
                sexo[i] = Console.ReadLine();

                //Console.WriteLine($"\nNombre: {nombre[i]} \nApellido: {apellido[i]} \nedad: {edad[i]} \nsexo: {sexo[i]}");
            }
        }

        public void SumaPrecioProductos()
        {
            //FLATA HACER EL PUNTO 3 DE ARRAYS
        }


    }
}
