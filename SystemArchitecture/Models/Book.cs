using System;
using System.Collections.Generic;

namespace SystemArchitecture.Models
{
    public class Book // Class Buku sebagai Atribut Menu Buku yang diperlukan
    {
        public int ISBN { get; set; } // Nomer ISBN Buku
        public string Title { get; set; } // Judul Buku
        public string Author { get; set; } // Penulis Buku

        public override string ToString() // Method untuk menampilkan data buku
        {
            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthor: {Author}\n";
        }
    }
}
