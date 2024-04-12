using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{

    public class ChatGPtCode
    {
    static void CheckPrime(int num)
    {
            if (num<=1)
            {
                Console.WriteLine($"{num} is not prime");
            }
                for (int i = 2; i <= num/2; i++)
                {
                if(num%i == 0)
                    {
                        Console.WriteLine($"{num} is not prime number");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is prime number");
                    }
                }

        }

       // static void Main(string[] args)
       // {
       //     Console.Write("Enter The Number:");
       //     int num = Convert.ToInt32(Console.ReadLine() );
       //     CheckPrime(num);
       // }

    }
}
