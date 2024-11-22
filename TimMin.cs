using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TimMin
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 0, 4, 1, 3, 5 };
            int index = TimMinnn(arr);
            Console.WriteLine("Min cua mang la "+ arr[index]);
        }
        public static int TimMinnn(int []arr)
        {
            int min = arr[0];
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min= arr[i];
                    index = i;
                }
            }
            return index;

        }
    }
}
