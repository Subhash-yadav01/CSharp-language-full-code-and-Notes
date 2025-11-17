using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p8WhileLoop
    {
        static void Main()
        {
            Console.Write("Enter any integers number which table you wants: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
                i++;
            }
        }
    }
}
