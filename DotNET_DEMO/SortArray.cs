using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_DEMO
{
    public class SortArray
    {

        static void Sort(int []arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])//for decending use < (less than symbol)
                    {

                    int temp = arr[i];
                    arr[i]= arr[j];
                    arr[j]= temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 5,8,6,5,3,4,1};

            Sort(arr);

            Console.Write("Sorted Array");

            foreach(int sortArr in arr)
            {
                Console.Write(sortArr+" ");
            }
        }
    }
}
