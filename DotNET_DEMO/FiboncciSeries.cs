using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{
    public class FiboncciNumbers
    {
        static void PrintSeries(int times)
        {
            int num1=0,num2=1,num3;

            Console.Write(num1+" "+num2);
            for (int i = 2; i < times; i++)
            {
                num3 = num2 + num1;
                Console.Write(" + "+num3);
                num1 = num2;
                num2 = num3;
            }
        }
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the number: ");
        //    int times = Convert.ToInt32(Console.ReadLine());
        //    PrintSeries(times);
            
        //}
    }
}
