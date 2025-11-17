using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement.JumpStatement
{
    internal class p2Continue
    {
        static void Main()
        {
            for (int i = 0; i <= 12; i++)
            {
                // if (i % 2 == 0 ) odd number show
                if (i % 2 == 1 ) // even number show 
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.WriteLine("Loops terminates");
        }
    }
}
