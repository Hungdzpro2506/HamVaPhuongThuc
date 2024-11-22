using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChuyendoiNhiet
    {
        static void Main(string[] args)
        {

            double DoF, DoC;
            int LuaChon;
            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                LuaChon = Int32.Parse(Console.ReadLine());
                if (LuaChon == 1)
                {
                    Console.WriteLine("Nhap do F muon chuyen doi");
                    DoF = Double.Parse(Console.ReadLine());
                    Console.WriteLine("do F sang do C la: " + ChuyenDoiFtoC(DoF)); ;
                }
                if (LuaChon == 2)
                {
                    Console.WriteLine("Nhap do C muon chuyen doi");
                    DoC = Double.Parse(Console.ReadLine());
                    Console.WriteLine("do C sang do F la: " + ChuyenDoiCtoF(DoC)); ;
                }

            } while (LuaChon != 0);
        }
        public static double ChuyenDoiCtoF(double DoC)
        {
            double DoF = (9.0 / 5) * DoC + 32;
            return DoF;
        }
        public static double ChuyenDoiFtoC(double DoF)
        {
            double DoC = (5.0 / 9) * (DoF - 32);
            return DoC;
        }
    }
}

