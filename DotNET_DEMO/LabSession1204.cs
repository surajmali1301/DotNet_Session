using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{
    public class LabSession1204
    {
        public static void MaxNumber()
        {
            int a, b , c ;
            Console.Write("Enter the 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a>= b && a>=c )
            {
                Console.Write(a+" is greater number");
            }
            else if(a>=b && a>=c )
            {
                Console.Write(b + " is greater number");
            }
            else
            {
                Console.Write(c + " is greater number");
            }
        }
        public static void MaxNumberUsingTernary()
        {
            int a, b, c;
            Console.Write("Enter the 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number:");
            c = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? ((a > c) ? a:c):((b > c)?b :c);
            Console.Write("The maximum number among 3 number is");
        }

        public static void DivisibleBy3And5()
        {
            for (int i = 1; i <= 50; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.Write(" Welcome to pune ");
                }
                else if(i%3==0)
                { 
                    Console.Write(" Pune ");
                }
                else if (i%5==0)
                {
                    Console.Write(" Welcome ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void PercentageAndGrade()
        {
            double sub1, sub2, sub3, sub4, sub5, percentage, sum;

            Console.Write("Enter the Subject 1 Mark:");
            sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Subject 2 Mark:");
            sub2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Subject 3 Mark:");
            sub3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Subject 4 Mark:");
            sub4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Subject 5 Mark:");
            sub5 = Convert.ToDouble(Console.ReadLine());

            sum = sub1 + sub2 + sub3 + sub4 + sub5;

            percentage = (sum / 500) * 100;
            Console.WriteLine($"Percentage of 5 marks is {percentage} %");

            if (percentage >= 90 && percentage <= 100) 
            {
                Console.Write(" You got A Grade");
            }
            else if(percentage >= 70 && percentage <= 80)
            {
                Console.Write(" You got B Grade");
            }
            else if(percentage >= 60 && percentage <= 70)
            {
                Console.Write(" You got C Grade");
            }
            else if(percentage >= 50 && percentage <= 60)
            {
                Console.Write(" You got D Grade");
            }
            else if (percentage >= 40 && percentage <= 50)
            {
                Console.Write(" You got F Grade");
            }

        }

        static void Main(string[] args)
        {
            //DivisibleBy3And5();
            PercentageAndGrade();
        }

    }
}
