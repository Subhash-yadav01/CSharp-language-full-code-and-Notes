using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// How to create Students Marksheet Application in C# Programming...

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p6StudentMarkSheets
    {
        static void Main()
        {
            Console.Write("Enter Your Name: ");
            string? sname = Console.ReadLine();

            Console.Write("Enter Your Roll No: ");
            string? roll = Console.ReadLine();

            Console.Write("Enter Your Class: ");
            string? std = Console.ReadLine();

            Console.WriteLine("\n-----------SUBJECT DETAILS--------\n");

            Console.Write("Enter Your english marks: ");
            int english = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Enter Your math marks: ");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your chemistery marks: ");
            int che = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your physics marks: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your computer marks: ");
            int com = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your hindi marks: ");
            int Hindi = Convert.ToInt32(Console.ReadLine());

            int total = (english + math + che + physics + com + Hindi);
            int percentage = total * 100 / 600;

            Console.WriteLine("--------------Calculat the details------");

            Console.WriteLine("Your name is: {0}",  sname);
            Console.WriteLine("Your Roll No is: {0}",  roll);
            Console.WriteLine("Your class is: {0}", std);
            Console.WriteLine("Total number in all subject is: {0}",total);
            Console.WriteLine("Total percentage is: {0}",percentage );


            if(percentage >= 80)
            {
                Console.WriteLine("Grade: A-1");
            }
            else if(percentage >=70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Grade: E");
            }
            else if (percentage >= 33 )
            {
                Console.WriteLine("Grade: F ");
            }
            else
            {
                Console.WriteLine("Grade: G (fail)");
            }


            if (percentage >= 80)
            {
                Console.WriteLine("Remarks Excellent !!");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Remarks Good !!");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Remarks Average !!");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Remarks Do more Better !!");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Remarks More efforts !!");
            }
            else if (percentage >= 33)
            {
                Console.WriteLine("Remarks you are fail next time try again !!");
            }
            else
            {
                Console.WriteLine("Remarks pending more work hard !!");
            }

            int supply = 0;
            
            if (english < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in english..");
            }

            if (math < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in math..");
            }

            if (che < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in che..");
            }

            if (physics < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in physics..");
            }

            if (com < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in com..");
            }

            if (Hindi < 33)
            {
                //supply++;
                Console.WriteLine("You are failed in Hindi..");
            }

            //Console.WriteLine("You are failed in {0} subjects",supply);
        }
    }
}

