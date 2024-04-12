using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{
    public  class LabSession
    {
        static void AreaOfCircle()
        {
            float pi = 3.14F;
            float area;
            float radius = 10;

            area = pi * radius*radius;
            Console.Write(area);
        }

        static void SwapNumbers()
        {
            Console.Write("Enter 1st Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Numbers: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;

            temp = num1;
            num1= num2;
            num2 = temp;

            Console.Write("After Swapping:- num1: "+ num1 +" num2: "+num2);
        }

        static void AreaOfTriangle()
        {
            double area,baseLength,height;

            Console.Write("Enter the base Length: ");
            baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * baseLength * height;

            Console.WriteLine($"Area of Triangle is {area}");
        }
        
        static void CalculatePercentage()
        {
            double sub1, sub2, sub3, sub4, sub5, percentage,sum;

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
        }
        static void Main(string[] args)
        {
            //AreaOfCircle();
            //SwapNumbers();
            //AreaOfTriangle();
            CalculatePercentage();

        }
    }
}
