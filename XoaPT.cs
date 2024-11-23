using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class XoaPT
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7};
            Console.WriteLine("Mang hien tai la: ");
            for (int i = 0;i< arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Nhap phan tu can xoa");
            int X= int.Parse(Console.ReadLine());

            int MangMoi= Removee(arr, X);

            Console.WriteLine("Mang sau khi xoa la: ");
            for (int i = 0; i < MangMoi; i++)
            {
                Console.Write(arr[i]+" ");
            }



        }
        public static int Removee(int[] array,int index_del)
        {
            int index = Array.IndexOf(array,index_del);

            if (index == -1)
            {
                Console.WriteLine($"Khong ton tai phan tu {index_del}");
                return array.Length;
            }
            
                for (int i = index; i < array.Length-1; i++)
                { 
                            array[i] = array[i + 1];
                        
                }
            Array.Resize(ref array, array.Length - 1);
            return array.Length;
        }
    }
}
