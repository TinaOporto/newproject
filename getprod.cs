using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace anotherpoj
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {


                Console.WriteLine("Enter two numbers: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int prod = 0;
                prod = num1 * num2;
                Console.WriteLine("The product is : " + prod);

                Console.WriteLine("Enter another number: ");
                int num3 = int.Parse(Console.ReadLine());

                int mod;
                mod = prod % num3;
                Console.WriteLine("The answer is: " + mod);

                Console.WriteLine("Do you want to continue? [Y/N]: ");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'Y' || ch == 'y');
            Console.WriteLine("Exit!");

            Console.ReadKey();

        }
    }
}
