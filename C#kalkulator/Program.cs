using System;

namespace MyCalculate{

    class Kalkulator
    {
        static void Main(string[] args)
        {
            do
            {
            double angka1 = 0;
            double angka2 = 0;
            double hasil = 0;

            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t| Kalkulator Sederhana |");
            Console.WriteLine("\t------------------------");

            Console.WriteLine("Selamat datang di program kalkulator sederhana");
            Console.WriteLine("Program ini ditujukan untuk mendapat nilai tugas SKILVUL");
            Console.WriteLine("Nama : Harta Brama Yudha");
            Console.WriteLine("==================================");
            Console.WriteLine("");

            Console.Write("Masukan angka pertama :");
            angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan angka kedua :");
            angka2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Operasi Aritmatika");
            Console.WriteLine("\t+ : Tambah");
            Console.WriteLine("\t- : Kurang");
            Console.WriteLine("\t* : Kali");
            Console.WriteLine("\t/ : Bagi");
            Console.WriteLine("-----------------------");

            Console.Write("Operasi yang digunakan :");
            
                switch (Console.ReadLine())
                {
                    case "+":
                        hasil = angka1 + angka2;
                        Console.WriteLine($"Hasil dari : {angka1} + {angka2} ="+hasil);
                        break;
                
                    case "-":
                        hasil = angka1 - angka2;
                        Console.WriteLine($"Hasil dari : {angka1} - {angka2} =" +hasil);
                        break;

                    case "*":
                        hasil = angka1 * angka2;
                        Console.WriteLine($"Hasil dari : {angka1} X {angka2} =" +hasil);
                        break;

                    case "/":
                        hasil = angka1 / angka2;
                        Console.WriteLine($"Hasil dari : {angka1} / {angka2} =" +hasil);
                        break;

                    default:
                        Console.WriteLine("Ups anda memasukan key yang salah!");
                        break;
                }
                    Console.WriteLine("Ingin melanjutkan program?");
                    Console.Write("(|Y = Yes || N = No|)");
            }
            while(Console.ReadLine().ToUpper()=="Y");
            
            Console.WriteLine("Terima Kasih");
            Console.ReadKey();
        }
   }
}