using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p9Do_WhileLoop
    {
        static void Main()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 20);

            Console.ReadLine();
        }
    }
}
