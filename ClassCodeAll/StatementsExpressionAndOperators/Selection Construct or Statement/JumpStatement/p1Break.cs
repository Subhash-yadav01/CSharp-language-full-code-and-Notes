using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement.JumpStatement
{
    internal class p1Break
    {
        static void Main()
        {
            for (int i = 1; i <= 12; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);

            }

            Console.WriteLine("Loops terminates");
        }
    }
}
