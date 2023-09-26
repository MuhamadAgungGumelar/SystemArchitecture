using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using SystemArchitecture;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.WriteLine( //Pembuatan Menu GUI Console supaya lebih interaktif
           @"                ================================================
                Selamat Datang di Repository Universitas Wakanda
                =================================================
                Silahkan Pilih Menu:
                1. Mengelola Buku
                2. Mengelola Anggota
                3. Mengelola Status Pinjaman Buku
                0. Exit
                ==================================================");

            while (int.TryParse(Console.ReadLine(), out menu)) // Membuat pengondisian untuk memilih menu menggunakan switch case
            {
                switch (menu)
                {
                    case 1: // Kondisi 1 Pengelolaan Buku
                        Menu.MenuBook();
                        break;
                    case 2: // Kondisi 2 Pengelolaan Anggota
                        Menu.MenuMember();
                        break;
                    case 3: // Kondisi 3 Pengelolaan Peminjaman Buku
                        Menu.MenuLoanBook();
                        break;
                    case 0:
                        Environment.Exit(0); // Keluar dari program
                        break;
                }
            }
        }
    }
}

