using System;
using System.Collections.Generic;

namespace SystemArchitecture.Models
{
    public class BookLoanService // Class Untuk Layanan Menu Peminjaman Buku
    {
        private List<BookLoan> loans = new List<BookLoan>();
        private int nextLoanId = 1;

        public void LoanBook(int memberId, int isbn, DateTime dueDate) // Fungsi Untuk Menambahkan Peminjaman Buku
        {
            loans.Add(new BookLoan
            {
                LoanId = nextLoanId++,
                MemberId = memberId,
                ISBN = isbn,
                DueDate = dueDate,
                IsReturned = false
            });
        }

        public void ReturnBook(int loanId) // Fungsi untuk Mengedit Peminjaman Buku
        {
            var loan = loans.Find(l => l.LoanId == loanId);
            if (loan != null)
            {
                loan.IsReturned = true;
            }
        }

        public void DeleteLoan(int loanId) // Fungsi untuk Menghapus Peminjaman Buku
        {
            var loan = loans.Find(l => l.LoanId == loanId);
            if (loan != null)
            {
                loans.Remove(loan);
            }
        }

        public List<BookLoan> GetMemberLoans(int memberId) // Fungsi untuk Menampilkan Peminjaman Buku
        {
            return loans.FindAll(l => l.MemberId == memberId);
        }
    }
}
