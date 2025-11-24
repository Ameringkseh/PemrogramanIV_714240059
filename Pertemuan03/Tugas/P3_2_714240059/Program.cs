using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk mengontrol perulangan utama program
            bool ulangiProgram = true;

            // Program akan terus mengulang selama 'ulangiProgram' bernilai true
            while (ulangiProgram)
            {
                // Membersihkan layar konsol setiap kali menu utama ditampilkan
                Console.Clear();

                // Menampilkan menu pilihan
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                // Membaca input pilihan dari user
                string pilihan = Console.ReadLine();

                // Struktur switch untuk memproses pilihan menu
                switch (pilihan)
                {
                    case "1":
                        // Memanggil method untuk menghitung luas
                        HitungLuas();
                        break;
                    case "2":
                        // Memanggil method untuk menghitung keliling
                        HitungKeliling();
                        break;
                    case "3":
                        // Pilihan untuk keluar dari program
                        ulangiProgram = false; // Menghentikan loop 'while'
                        Console.WriteLine("Program selesai.");
                        Console.WriteLine("Terima kasih!");
                        break;
                    default:
                        // Penanganan jika input menu tidak valid
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                // Bagian ini akan dijalankan setelah menu 1, 2, atau default.
                // Tidak akan dijalankan jika user memilih menu "3" (Keluar).
                if (pilihan != "3")
                {
                    Console.Write("\nIngin mengulang kembali (Y/T)? ");
                    string ulangi = Console.ReadLine();

                    if (ulangi.ToUpper() == "T")
                    {
                        ulangiProgram = false; // Menghentikan loop 'while'
                        Console.WriteLine("Terima kasih!");
                    }
                    // Jika user input 'Y', program akan otomatis kembali ke atas (loop 'while' berlanjut)
                }
            }

            // Menahan konsol agar tidak langsung tertutup
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }

        // Method untuk menghitung luas persegi panjang
        static void HitungLuas()
        {
            Console.Write("Masukkan panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            // Rumus luas
            int luas = panjang * lebar;

            Console.WriteLine($"Luas Persegi Panjang: {luas}");
        }

        // Method untuk menghitung keliling persegi panjang
        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            // Rumus keliling
            int keliling = 2 * (panjang + lebar);

            Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
        }
    }
}
