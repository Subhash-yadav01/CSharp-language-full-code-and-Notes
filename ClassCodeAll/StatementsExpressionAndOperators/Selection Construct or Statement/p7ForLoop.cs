using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p7ForLoop
    {
        static void Main()
        {
            for (int i = 0; i <= 10; i++ )  // counter variable
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop ternminals");

            Console.WriteLine("Enter any integer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(number + " * " + i + " = " + number * i);

            Console.ReadLine();
        }
    }
}
