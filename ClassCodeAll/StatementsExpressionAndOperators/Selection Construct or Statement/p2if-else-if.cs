using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeAll.StatementsExpressionAndOperators.Selection_Construct_or_Statement
{
    internal class p2if_else_if
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the student Data.....\n");

            Console.Write("Enter the marks obtained in subject 1: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks obtained in subject 2: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks obtained in subject 3: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3;
            float percentage = (totalMarks / 300.0f) * 100;

            Console.WriteLine("Total Marks: " + totalMarks);

            if (percentage >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.ReadLine();
        }
    }
}
