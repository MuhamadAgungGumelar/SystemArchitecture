using System;
using System.Collections.Generic;

namespace SystemArchitecture.Models
{
    public class BookLoan // Class BookLoan sebagai Atribut Menu Peminjaman Buku yang diperlukan
    {
        public int LoanId { get; set; } // Id Peminjaman
        public int MemberId { get; set; } // Id Anggota
        public int ISBN { get; set; } // Nomer ISBN Buku
        public DateTime DueDate { get; set; } // Tanggal Peminjaman
        public bool IsReturned { get; set; } // Status Peminjaman

        public override string ToString() // Method untuk menampilkan data Peminjaman BukuD
        {
            return $"LoanId: {LoanId}\nMemberId: {MemberId}\nISBN: {ISBN}\nDueDate: {DueDate}\nIsReturned: {IsReturned}";
        }
    }
}
