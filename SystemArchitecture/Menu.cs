using System;
using System.Collections.Generic;
using SystemArchitecture.Models;


namespace SystemArchitecture
{
    public class Menu // Class Untuk Pengelolaan Menu
    {
        public static void MenuBook() // Fungsi Untuk Pengelolaan Menu Bagian Buku
        {
            var bookService = new BookService();

            string title;
            string author;
            int isbn;


            Console.WriteLine("Masukan buku yang akan ditambahkan:");
            var isLoop = true;

            while (isLoop)
            {
                Console.WriteLine("1. Menambahkan Buku");
                Console.WriteLine("2. Mengedit Buku");
                Console.WriteLine("3. Menghapus Buku");
                Console.WriteLine("4. Menampilkan List Buku");
                Console.WriteLine("10. Back");
                Console.Write("Enter your choice: ");
                var input2 = Console.ReadLine();
                switch (input2)
                {

                    case "1":
                        Console.WriteLine("Masukan buku yang akan ditambahkan:");
                        Console.WriteLine("Masukan Nomer ISBN");
                        if (int.TryParse(Console.ReadLine(), out isbn) && isbn > 0)
                        {
                            Console.WriteLine("Masukan Judul Buku");
                            title = Console.ReadLine();
                            Console.WriteLine("Masukan Penulis Buku");
                            author = Console.ReadLine();

                            bookService.AddBook(isbn, title, author);
                        }
                        else
                        {
                            Console.WriteLine("ISBN tidak boleh kososng.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Menghapus buku yang akan ditambahkan:");
                        Console.WriteLine("Masukan Nomer ISBN");
                        if (int.TryParse(Console.ReadLine(), out isbn) && isbn > 0)
                        {
                            Console.WriteLine("Masukan Judul Buku");
                            title = Console.ReadLine();
                            Console.WriteLine("Masukan Penulis Buku");
                            author = Console.ReadLine();

                            bookService.EditBook(isbn, title, author);
                        }
                        else
                        {
                            Console.WriteLine("ISBN tidak boleh kososng.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Masukan Nomer ISBN");
                        if (int.TryParse(Console.ReadLine(), out isbn) && isbn > 0)
                        {
                            bookService.DeleteBook(isbn);
                        }
                        else
                        {
                            Console.WriteLine("ISBN tidak boleh kososng.");
                        }
                        break;
                    case "4":
                        var books = bookService.GetAllBooks();
                        Console.WriteLine("\nList of Books:");
                        if (books.Count > 0)
                        {
                            foreach (var book in books)
                            {
                                Console.WriteLine($"\nISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List Buku Kosong");
                        }
                        break;
                    case "10":
                        isLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    
        public static void MenuMember() // Fungsi Untuk Pengelolaan Menu Bagian Anggota
        {
            var memberService = new MemberService();


            string name;
            string email;
            int memberId;

            Console.WriteLine("Masukan anggota yang akan ditambahkan:");
            var isLoop2 = true;

            while (isLoop2)
            {
                Console.WriteLine("1. Menambahkan Anggota");
                Console.WriteLine("2. Mengedit Anggota");
                Console.WriteLine("3. Menghapus Anggota");
                Console.WriteLine("4. Menampilkan List Anggota");
                Console.WriteLine("10. Back");
                Console.Write("Enter your choice: ");
                var input2 = Console.ReadLine();
                switch (input2)
                {

                    case "1":
                        Console.WriteLine("Masukan Anggota yang akan ditambahkan:");
                        Console.WriteLine("Masukan Nomer Anggota Id");
                        if (int.TryParse(Console.ReadLine(), out memberId) && memberId > 0)
                        {
                            Console.WriteLine("Masukan Nama Anggota");
                            name = Console.ReadLine();
                            Console.WriteLine("Masukan Email Anggota");
                            email = Console.ReadLine();

                            memberService.AddMember(memberId, name, email);
                        }
                        else
                        {
                            Console.WriteLine("Nomer Anggota Id tidak boleh kososng.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Mengedit Anggota yang akan ditambahkan:");
                        Console.WriteLine("Masukan Nomer Anggota Id");
                        if (int.TryParse(Console.ReadLine(), out memberId) && memberId > 0)
                        {
                            Console.WriteLine("Masukan Nama Anggota");
                            name = Console.ReadLine();
                            Console.WriteLine("Masukan Email Anggota");
                            email = Console.ReadLine();

                            memberService.EditMember(memberId, name, email);
                        }
                        else
                        {
                            Console.WriteLine("Nomer Anggota Id tidak boleh kososng.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Masukan Nomer Anggota Id");
                        if (int.TryParse(Console.ReadLine(), out memberId) && memberId > 0)
                        {
                            memberService.DeleteMember(memberId);
                        }
                        else
                        {
                            Console.WriteLine("Nomer Anggota Id tidak boleh kososng.");
                        }
                        break;
                    case "4":
                        var members = memberService.GetAllMembers();
                        Console.WriteLine("\nList of Members:");
                        if (members.Count > 0)
                        {
                            foreach (var member in members)
                            {
                                Console.WriteLine($"MemberId: {member.MemberId}, Name: {member.Name}, Email: {member.Email}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List Anggota Kosong");
                        }
                        break;
                    case "10":
                        isLoop2 = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    
        public static void MenuLoanBook() // Fungsi Untuk Pengelolaan Menu Bagian Peminjaman Buku
        {
            var bookLoanService = new BookLoanService();

            int isbn;
            int memberId;
            DateTime dueDateTime;
            int loanId;

            Console.WriteLine("Masukan pinjaman buku yang akan ditambahkan:");
            var isLoop3 = true;

            while (isLoop3)
            {
                Console.WriteLine("1. Meminjam Buku");
                Console.WriteLine("2. Mengedit Peminjaman Buku");
                Console.WriteLine("3. Menghapus Peminjaman Buku");
                Console.WriteLine("4. Menampilkan List Peminjaman Buku");
                Console.WriteLine("10. Back");
                Console.Write("Enter your choice: ");
                var input2 = Console.ReadLine();
                switch (input2)
                {

                    case "1":
                        Console.WriteLine("Masukan Peminjaman Buku yang akan ditambahkan:");
                        Console.WriteLine("Masukan Nomer Anggota Id");
                        if (int.TryParse(Console.ReadLine(), out memberId) && memberId > 0)
                        {
                            Console.WriteLine("Masukan No ISBN");
                            if (int.TryParse(Console.ReadLine(), out isbn) && isbn > 0)
                            {
                                Console.WriteLine("Masukan Tanggal Peminjaman Buku");
                                if (DateTime.TryParse(Console.ReadLine(), out dueDateTime))
                                {
                                    bookLoanService.LoanBook(memberId, isbn, dueDateTime);
                                }
                                else
                                {
                                    Console.WriteLine("Format tanggal tidak valid.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("ISBN tidak boleh kososng.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nomer Anggota Id tidak boleh kososng.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Mengedit Status Peminjaman Buku:");
                        Console.WriteLine("Masukan Peminjaman Id");
                        if (int.TryParse(Console.ReadLine(), out loanId) && loanId > 0)
                        {
                            bookLoanService.ReturnBook(loanId);
                        }
                        else
                        {
                            Console.WriteLine("ID Peminjaman tidak valid.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Masukkan ID Peminjaman Buku yang akan dihapus:");
                        if (int.TryParse(Console.ReadLine(), out int loanId2) && loanId2 > 0)
                        {
                            bookLoanService.DeleteLoan(loanId2);
                            Console.WriteLine("Peminjaman Buku berhasil dihapus.");
                        }
                        else
                        {
                            Console.WriteLine("ID Peminjaman Buku tidak valid.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nMasukan Anggota Id:");
                        if (int.TryParse(Console.ReadLine(), out memberId) && memberId != null && memberId > 0)
                        {
                            var loanLists = bookLoanService.GetMemberLoans(memberId);
                            Console.WriteLine("\nList of Loan Books:");

                            foreach (var loan in loanLists)
                            {
                                Console.WriteLine($"Loan ID: {loan.LoanId}");
                                Console.WriteLine($"Member ID: {loan.MemberId}");
                                Console.WriteLine($"ISBN: {loan.ISBN}");
                                Console.WriteLine($"Tanggal Peminjaman: {loan.DueDate}");
                                Console.WriteLine($"Telah Dikembalikan: {loan.IsReturned}");
                                Console.WriteLine("--------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nomer Anggota Id tidak boleh kosong.");
                        }
                        break;
                    case "10":
                        isLoop3 = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
