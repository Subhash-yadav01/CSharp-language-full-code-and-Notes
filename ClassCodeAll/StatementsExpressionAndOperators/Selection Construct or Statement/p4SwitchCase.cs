using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p4SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("\n-------------Name print-----------\n");
            Console.Write("Please enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            switch (age)
            {
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("My Age is under the child....");
                    break;
                case 22:
                    Console.WriteLine("My Age is Younger.........");
                    break;
                default:
                    Console.WriteLine("This is out of the all code....");
                    break;
            }
            Console.ReadLine();
        }
    }
}
