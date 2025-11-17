using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p1if_else
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 20;

            if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
            else
            {
                Console.WriteLine("a is not less than b");
            }

            Console.WriteLine("\n-------------Next Code------------------\n");

            string name = "Subhash";

            if (name == "Subhash")
            {
                Console.WriteLine("Yes you are Subhash");
            }
            else
            {
                Console.WriteLine("You are wrong person");
            }

            Console.WriteLine("\n-------------Next Code------------------\n");

            Console.Write("Enter Your Name: ");
            string? userName = Console.ReadLine();

            Console.Write("Enter your password: ");
            
            int password = Convert.ToInt32(Console.ReadLine());

            if (userName == "Raj" && password == 123)
            {
                Console.WriteLine("You are correct person.........");
            }
            else
            {
                Console.WriteLine("You are wrong guys..........");
            }

        }
    }
}
