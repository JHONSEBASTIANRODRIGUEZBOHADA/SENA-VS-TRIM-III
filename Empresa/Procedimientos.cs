using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Procedimientos
    {
        public void NotaFinal()
        {

            string[] nombre = { "Felipe", "Oscar", "Andrea", "kimberly" };
            double[] examenParcial = { 0, 6, 3, 7 };
            double[] examenOral = { 7, 1, 3, 4 };
            double[] examenFinal = { 8, 9, 1, 9 };
            double[] promedio = new double[4];

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nNOMBRE: {nombre[i]} \nEXAMEN PARCIAL: {examenParcial[i]} \nEXAMEN ORAL: {examenOral[i]} \nEXAMEN FINAL: {examenFinal[i]}");
            }
            
            for(int i = 0; i < nombre.Length; i++)
            {



            }

        }
    }
}
