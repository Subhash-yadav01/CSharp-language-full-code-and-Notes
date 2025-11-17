using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Operators
{
    internal class p5ternaryOpe
    {
        static void Main(string[] args)
        {
            int a = 20;
            string b = (a % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
