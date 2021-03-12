using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            // int a = 10 , deklarasi variabel a, dengan nilai awal 10
            // int b = 6 , deklarasi variabel b, dengan nilai awal 6

            // jika ingin menginputkan variabel a dan b nya

            Menu();

            int SelectMenu = selectMenu();
            
            if ( SelectMenu < 1 || SelectMenu >4 )
            {
                Console.WriteLine("Maaf, menu yang anda pilih tak tersedia");    
                
                Console.WriteLine();
                Console.WriteLine("Tekan sembarang Key untuk keluar");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine();
            int a = nilaiA();
            int b = nilaiB();

            Console.WriteLine();
            if ( SelectMenu == 1)
            {
              Console.WriteLine( "Hasil Penambahan {0} + {1} = {2}",a, b, Penambahan(a, b));  
            }
            if ( SelectMenu == 2)
            {
              Console.WriteLine( "Hasil Penambahan {0} - {1} = {2}",a, b, Pengurangan(a, b));  
            }
            if ( SelectMenu == 3)
            {
                Console.WriteLine( "Hasil Perkalian {0} * {1} = {2}",a, b, Perkalian(a, b));
            }
            if ( SelectMenu == 4)
            {
                Console.WriteLine( "Hasil Pembagian {0} / {1} = {2}",a, b, Pembagian(a, b));
            }
        //    Console.WriteLine(); // jika ingin menambahkan baris kosong
        //    Console.WriteLine( "Hasil Penambahan {0} + {1} = {2}",a, b, Penambahan(a, b));
        //    Console.WriteLine( "Hasil Penambahan {0} - {1} = {2}",a, b, Pengurangan(a, b));
        //    Console.WriteLine( "Hasil Perkalian {0} * {1} = {2}",a, b, Perkalian(a, b));
        //    Console.WriteLine( "Hasil Pembagian {0} / {1} = {2}",a, b, Pembagian(a, b));

        //    Console.WriteLine("\n Tekan sembarang key untuk keluar");
        //    Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("Tekan sembarang Key untuk keluar");
                Console.ReadLine();
                Environment.Exit(0);
        }

        static void Menu()
        {
            Console.WriteLine("Silahkan pilih menu kalkulator");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        static int selectMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Input nomor menu [1...4] : ");
            
            return int.Parse(Console.ReadLine());
        }

        static int nilaiA()
        {
            Console.WriteLine();
            Console.WriteLine("Inputkan nilai a : ");

            return int.Parse(Console.ReadLine());
        }

        static int nilaiB()
        {
            Console.WriteLine();
            Console.WriteLine("Inputkan nilai b : ");

            return int.Parse(Console.ReadLine());
        }

        static int Penambahan (int a, int b)
            {
                return a+b;
            }

        static int Pengurangan (int a, int b)
            {
                return a-b;
            }

        static double Perkalian (int a, int b)
            {
                return a*b;
            }

        static double Pembagian (int a, int b)
            {
                return a/b;
            }

    }
}
