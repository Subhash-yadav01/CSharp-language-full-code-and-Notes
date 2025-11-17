using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p3Nested_If
    {
        static void Main(string[] args)
        {
            int a = 5;

            if (a < 30)
            {
                if (a < 20)
                {
                    if (a < 10)
                    {
                        Console.WriteLine("a is less than 10");
                    }
                    else
                    {
                        Console.WriteLine("a is between 10 and 19");
                    }
                }
                else
                {
                    Console.WriteLine("a is between 20 and 29");
                }
            }
            else
            {
                Console.WriteLine("a is 30 or more");
            }

            // USER INPUT 
            Console.WriteLine("\n---------USER INPUT-----------\n");

            Console.Write("Please Enter userName: ");
            string? userName = Convert.ToString(Console.ReadLine());

            Console.Write("Please Enter password: ");
            string? password = Convert.ToString(Console.ReadLine());

            //string? username = "admin";
            //string? password = "admin123";

            if (userName == "admin")
            {
                if (password == "admin123") 
                {
                    Console.WriteLine("Login seccessful......");
                }
                else
                {
                    Console.WriteLine("Invalide user");
                }
            }
            else
            {
                Console.WriteLine("This is not match");
            }
        }
    }
}
