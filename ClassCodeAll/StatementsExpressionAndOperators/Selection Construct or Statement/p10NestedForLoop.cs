using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p10NestedForLoop
    {
        static void Main()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Hello");
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Hey");
                }
            }
        }
    }
}
