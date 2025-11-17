using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p5NestedSwitch
    {
        static void Main()
        {
            Console.WriteLine("Enter your pizza flavour...");
            string? pizza = Console.ReadLine();

            switch (pizza)
            {
                case "fajita":
                    Console.WriteLine("you are selected fajita pizza...");
                    break;

                case "suprem":
                    Console.WriteLine("you are selected suprem pizza...");
                    break;

                case "cheese":
                    Console.WriteLine("you are selected cheese pizza...");
                    break;

                case "vegitable":
                    Console.WriteLine("Enter your vegitable...");
                    string? veg = Console.ReadLine();

                    switch(veg)
                    {
                        case "Tomato":
                        Console.WriteLine("Take this Tomato flavour...");
                            break;

                        case "onion":
                            Console.WriteLine("Take this onion flavour...");
                            break;

                        case "olivas":
                            Console.WriteLine("Take this olivas flavour...");
                            break;

                        default:
                            Console.WriteLine("come outs this is not aviable.....");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Choose another flavour Not Abilable");
                    break;
            }

        }
    }
}
