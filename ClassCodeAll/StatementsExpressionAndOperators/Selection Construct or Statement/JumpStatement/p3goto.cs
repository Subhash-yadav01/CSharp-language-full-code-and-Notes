using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement.JumpStatement
{
    internal class p3goto
    {
       static void Main()
        {
            for (int i = 1; i <= 14; i++ )
            {
                if (i == 6)
                {
                    goto stop;
                }
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Loop terminates..");

            stop:
            Console.WriteLine("Program Exits...");
        }
    }
}
