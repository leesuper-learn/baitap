using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so tien USD: ");
            int USD = int.Parse(Console.ReadLine());
            int rate = USD * 23000;
            Console.WriteLine("So tien VND la: " + rate);
            Console.ReadKey();
        }
    }
}
