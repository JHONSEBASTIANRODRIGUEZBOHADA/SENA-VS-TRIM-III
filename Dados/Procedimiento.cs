using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Procedimiento : GetterYSetter
    {
        public void PuntajeDados()
        {
            Random random = new Random();
            Dado11 = random.Next(1, 7);
            Dado21 = random.Next(1, 7);
            Dado31 = random.Next(1, 7);

            Console.WriteLine($"Primer dado: {Dado11} \nSegundo dado: {Dado21} \nTercer dado: {Dado31}");

            if(Dado11 == Dado21 && Dado11 == Dado31)
            {
                Console.WriteLine("\n¡USTED GANO!");
            }
            else
            {
                Console.WriteLine("\n¡USTED PERDIO!");
            }
        }
    }
}
