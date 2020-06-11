using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using HelloWorld.AbstractClass;    // dengan Abstract Class
using HelloWorld.Interface;      // dengan Interface

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*makanan makanan;          // Menggunakan Abstract Class

            Console.WriteLine();
            makanan = new pisang();
            makanan.buah();
            Console.WriteLine();

            makanan = new kelapa();
            makanan.buah();
            Console.WriteLine();

            makanan = new durian();
            makanan.buah();
            Console.WriteLine();

            makanan = new manggis();
            makanan.buah();
            Console.WriteLine();*/

            Imakanan makanan;       // Menggunakan Interface

            Console.WriteLine();
            makanan = new pisang();
            makanan.buah();
            Console.WriteLine();

            makanan = new kelapa();
            makanan.buah();
            Console.WriteLine();

            makanan = new durian();
            makanan.buah();
            Console.WriteLine();

            makanan = new manggis();
            makanan.buah();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}