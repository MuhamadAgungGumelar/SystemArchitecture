using System;
using System.Collections.Generic;

namespace SystemArchitecture.Models
{
    public class BookService // Class Untuk Layanan Menu Buku
    {
        private List<Book> books = new List<Book>();

        public void AddBook(int isbn, string title, string author) // Fungsi Untuk Menambahkan Buku
        {
            books.Add(new Book { ISBN = isbn, Title = title, Author = author });
        }

        public void EditBook(int isbn, string title, string author) // Fungsi untuk Mengedit Buku
        {
            var book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                book.Title = title;
                book.Author = author;
            }
        }

        public void DeleteBook(int isbn) // Fungsi untuk Menghapus Buku
        {
            var book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public List<Book> GetAllBooks() // Fungsi untuk Menampilkan Semua Buku
        {
            return books;
        }
    }
}
