using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DemPhanTu
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 2, 3, 2, 2, 4, 5, 6, 2 };
            Console.WriteLine("mang ban dau la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.WriteLine("nhap phan tu muon dem: ");
            int X= int.Parse(Console.ReadLine());
            Console.WriteLine($"Phan tu {X} xuat hien: " + DemPT(arr, X));

        }
        public static int DemPT(int[] array, int PTCanDem) 
        {
            int Dem = 0;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] == PTCanDem) { Dem++; }
            }
            
            return Dem;
        
        }
    }
}
