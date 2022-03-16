using System;
namespace kalkulator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.Title = "kalkulator sederhana";


            static double tambah(double a, double b)
            { return a + b; }
            static double kurang(double a, double b)
            { return a - b; }
            static double kali(double a, double b)
            { return a * b; }
            static double bagi(double a, double b)
            { return a / b; }


           
            {
                double bil1, bil2, pilih;
                Console.WriteLine("kalkulator sederhana");
                Console.WriteLine("1. Penjumlahan \n 2.Pengurangan\n 3.Perkalian\n 4.Pembagian");
                Console.WriteLine("masukan pilihan");
                pilih = Convert.ToDouble(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.WriteLine("Masukan bilangan pertama");
                    bil1 =Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukan bilangan kedua");
                    bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + bil1+ "+" + bil2 + "=" +tambah(bil1, bil2) + "");
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Masukan bilangan pertama");
                    bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukan bilangan kedua");
                    bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + bil1 + "-" + bil2 + "=" + kurang(bil1, bil2) + "");
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Masukan bilangan pertama");
                    bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukan bilangan kedua");
                    bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + bil1 + "*" + bil2 + "=" + kali(bil1, bil2) + "");
                }
                else if (pilih == 4)
                {
                    Console.WriteLine("Masukan bilangan pertama");
                    bil1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukan bilangan kedua");
                    bil2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil dari " + bil1 + "/" + bil2 + "=" + bagi(bil1, bil2) + "");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                }
            }Console.WriteLine("tekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }
}
