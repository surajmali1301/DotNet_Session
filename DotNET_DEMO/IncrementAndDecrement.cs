using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{
    public class IncrementAndDecrement
    {
        static void Main(string[] args)
        {
            //int a = 10;

            //int b = a++;

            //int c = a++ - --b;

            //Console.WriteLine($"{a}, {b} ,{c}");

            //int a = 1; 
            //do
            //{
            //    Console.Write(a+" ");
            //    a++;
            //}while(a<=5);

            for (int i = 1; i<=5;i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
