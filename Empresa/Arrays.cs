using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Arrays
    {
        public void FinalGrade()
        {

            string[] name = { "Felipe", "Oscar", "Andrea", "kimberly" };
            int[] partialTest = { 0, 6, 4, 9 };
            int[] oralTest =    { 7, 1, 3, 4 };
            int[] finalTest =   { 8, 9, 1, 9 };
            float sum = 0;
            float average = 0;

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nNAME: {name[i]} \nPARTIAL TEST: {partialTest[i]} \nORAL TEST: {oralTest[i]} \nFINAL TEST: {finalTest[i]}");
            }
            
            for(int i = 0; i < name.Length; i++)
            {
                sum = partialTest[i] + oralTest[i] + finalTest[i];
                average = sum / 3;
                if (average >= 7)
                {
                    Console.WriteLine($"\nNAME: {name[i]} \nAVERAGE RATING: {average} APPROVED");
                }
                else
                {
                    Console.WriteLine($"\nNAME: {name[i]} \nAVERAGE RATING: {average} DID NOT APPROVE");
                }
            }
        }

        public void CustomerData()
        {
            string[] firstName = new string[5];
            string[] firstSurname = new string[5];
            int[] age = new int[5];
            string[] gender = new string[5];

            bool Error = false;
            while (!Error)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        Console.WriteLine($"\n{i}. Enter your name");
                        firstName[i] = Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        firstSurname[i] = Console.ReadLine();
                        Console.WriteLine("Enter your age");
                        age[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your gender");
                        gender[i] = Console.ReadLine();
                    }
                    catch(OverflowException e)
                    {
                        Console.WriteLine("ingreso un numero de identificacion muy largo");
                        Error = false;
                    }
                }
            }
        }

        public void SumPriceProducts()
        {
            string[] products = new string[5];
            double[] price = new double[5];

            Console.WriteLine("Enter 5 products with their price");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{i}. Enter product name");
                products[i] = Console.ReadLine();
                Console.WriteLine("Enter the price of the product");
                price[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nThe total price of your purchase is: {price.Sum()}");
        }
    }
}
