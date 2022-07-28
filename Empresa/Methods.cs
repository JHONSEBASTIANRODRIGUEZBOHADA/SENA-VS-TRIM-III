using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Methods
    {
        //U.S DOLLAR TO COLOMBIAN PESOS
        public void CurrencyConverter1()
        {
            const double cop = 4418;
            double usd;
            double conversion;

            Console.WriteLine("Enter the money (U.S dollar) to be converted into colombian pesos");
            usd = double.Parse(Console.ReadLine());

            conversion = usd * cop;

            Console.WriteLine($"United States dollar: {usd} ---> Colombian pesos {conversion}");
        }

        //NEW ZEALAND DOLLAR TO COLOMBIAN PESOS
        public void CurrencyConnverter2()
        {
            const double cop = 2736;
            double nzd;
            double conversion;

            Console.WriteLine("Enter the money (New Zealand dollar) to be converted into colombian pesos");
            nzd = double.Parse(Console.ReadLine());

            conversion = nzd * cop;

            Console.WriteLine($"New Zealand dollar: {nzd} ---> Colombian pesos {conversion}");
        }

        //SINGAPORE DOLLAR TO COLOMBIAN PESOS
        public void CurrencyConnverter3()
        {
            const double cop = 3176;
            double sgd;
            double conversion;

            Console.WriteLine("Enter the money (Singapore dollar) to be converted into colombian pesos");
            sgd = double.Parse(Console.ReadLine());

            conversion = sgd * cop;

            Console.WriteLine($"Singapore dollar: {sgd} ---> Colombian pesos {conversion}");
        }

        //EURO TO COLOMBIAN PESOS
        public void CurrencyConnverter4()
        {
            const double cop = 4461;
            double eur;
            double conversion;

            Console.WriteLine("Enter the money (Euro) to be converted into colombian pesos");
            eur = double.Parse(Console.ReadLine());

            conversion = eur * cop;

            Console.WriteLine($"Euro: {eur} ---> Colombian pesos {conversion}");
        }

        //PANAMANIAN BALBOA TO COLOMBIAN PESOS
        public void CurrencyConnverter5()
        {
            const double cop = 4406;
            double pab_b;
            double conversion;

            Console.WriteLine("Enter the money (Panamanian balboa) to be converted into colombian pesos");
            pab_b = double.Parse(Console.ReadLine());

            conversion = pab_b * cop;

            Console.WriteLine($"Panamanian balboa: {pab_b} ---> Colombian pesos {conversion}");
        }

        public void AreaRectangle()
        {
            double height;
            double base_;
            double totalAreaRectangle;

            Console.WriteLine("Enter the numbre for the height of the rectangle");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbre for the base of the rectangle");
            base_ = double.Parse(Console.ReadLine());

            totalAreaRectangle = (base_ * height);

            Console.WriteLine($"The total area of the rectangle is: {totalAreaRectangle}");
        }

        public void AgeEntered()
        {
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

            if(age == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (age <= 17)
                {
                    Console.WriteLine("You are a minor");
                }
                else
                {
                    if (age >= 18 && age <= 60)
                    {
                        Console.WriteLine("You are an adult");
                    }
                    else
                    {
                        if(age >= 60 && age <= 130)
                        {
                            Console.WriteLine("You are an older adult");
                        }
                        else
                        {
                            Console.WriteLine("You entered a false age");
                        }
                    }
                }
            }
        }

        public void MultiplicationTable(int x)
        {
            Console.WriteLine("Enter the number for the multiplication table");
            x = int.Parse(Console.ReadLine());
            int i;
            
            for (i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{x} * {i} = {x*i}");
            }
        }
    }
}
// por que cuando pongo estatico en el metodo no me deja llamarlo en el main
// cuando hay que usar getter y setter
// es buena practica dejar metodos vacios
// por que en el main principal me obliga a inicializar la varioable opciones