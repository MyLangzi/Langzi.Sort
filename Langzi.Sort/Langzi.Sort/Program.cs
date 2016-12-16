using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Langzi.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -3, 43, 453, 2, 4, 54 };

            arr.BubbleSort_Efficient();
            Print(arr);


            Console.ReadKey();
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }
    }
}
