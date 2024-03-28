using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Task 1.");

            Console.WriteLine("\tIt's easy to win forgiveness for being wrong;\n\tbeing right is what gets you into real trouble.\n\tBjarne Stroustrup");

            Console.WriteLine();

            Console.WriteLine("Task 2.");

            Console.WriteLine();

            Console.WriteLine("Input 5 numbers :");

            int sum = 0;
            int min = int.MaxValue; 
            int max = int.MinValue; 
            int product = 1;

            for (int i = 0; i < 5; i++)
            {
                int numberTask2 = int.Parse(Console.ReadLine());

                if (numberTask2 < min)
                {
                    min = numberTask2;
                }

                if (numberTask2 > max)
                {
                    max = numberTask2;
                }

                sum += numberTask2;
                product *= numberTask2;
            }

            Console.WriteLine($"Sum.: {sum}");
            Console.WriteLine($"Min.: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Multipl.: {product}");

            Console.WriteLine();

            Console.WriteLine("Task 3.");
            Console.WriteLine();

            Console.WriteLine("Enter  5-digit number:");

            int numberTask3 = int.Parse(Console.ReadLine());

            while (numberTask3 > 0)
            {
                int digit = numberTask3 % 10;
                Console.Write(digit);
                numberTask3 /= 10;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 4.");
            Console.WriteLine();

            Console.WriteLine("enter number - end :");

            int end = int.Parse(Console.ReadLine());

            int temp = 0;
            int temp1 = 0;
            int temp2 = 1;

            Console.Write(0 +" ");

            while (end > temp2)
            {
                Console.Write((temp1 + temp2) + "  ");
            
                temp = temp2;
                temp2 = temp1 + temp2;
                temp1 = temp;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 5.");
            Console.WriteLine();

            Console.WriteLine("Enter number 1:");

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2 (num2 > num1):");

            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Task 6.");

            Console.WriteLine();

            Console.WriteLine("Enter nuber of symbols :");
            int numSymbols = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol:");
            string Symb = Console.ReadLine();

            Console.WriteLine("If line must be horizontal enter 1, else 0 :");
            int numOrientation = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numSymbols; i++)
            {
                if (numOrientation == 1)
                {
                    Console.Write(Symb);
                }
                else
                {
                    Console.WriteLine(Symb);
                }
            }


            Console.ReadLine();

        }
    }
}
