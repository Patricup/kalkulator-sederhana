using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = " Aplikasi Kalkulator ";

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Masukan Nomor Menu [1...4] = ");

            string pilih = Console.ReadLine();
            float a, b, jumlah, kali, bagi, kurang;

            if (pilih == "1")
            {
                Console.Write("masukan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                jumlah = a + b;

                Console.Write("hasil Penjumlahan adalah " + a + " + " + b + " = " + jumlah);

            }
            else if (pilih == "2")
            {
                Console.Write("masukan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                kurang = a - b;
                Console.Write("hasil Pengurangan adalah " + a + " - " + b + " = " + kurang);
            }
            else if (pilih == "3")
            {
                Console.Write("masukan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                kali = a * b;
                Console.Write("hasil Perkalian adalah " + a + " * " + b + " = " + kali);
            }
            else if (pilih == "4")
            {
                Console.Write("masukan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                bagi = a / b;
                Console.Write("hasil Pembagian adalah " + a + " / " + b + " = " + bagi);
            }
            else
            {
                Console.WriteLine(" Maaf menu yang anda pilih tidak tersedia");
            }
            Console.WriteLine();
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }
    }
}

