using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class OptionMenu
    {
        public void MainOptions()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Choose the option you want:" +
            "\n1.Arrays" +
            "\n2.methods" +
            "\n9.Salir");
        }

        public void Leave() { }

        public void ArrayOptions()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Choose the option you want:" +
            "\n1.Final grade" +
            "\n2.Customer data" +
            "\n3.Sum of product prices" +
            "\n4.Salir");
        }

        public void MethodsOptions()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Choose the option you want:" +
            "\n1.Currency Converter" +
            "\n2.Area Rectangle" +
            "\n3.Age Entered" +
            "\n4.Multiplication Table" +
            "\n5.Salir");
        }

        public void CurrencyConverterOptions()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Choose the option you want:" +
            "\n1.U.s dollar to colombian pesos" +
            "\n2.New zealand dollar to colombian pesos" +
            "\n3.Singapore dollar to colombian pesos" +
            "\n4.Euro to colombian pesos" +
            "\n5.Panamanian balboa to colombian pesos" +
            "\n6.Salir");
        }



    }
}
