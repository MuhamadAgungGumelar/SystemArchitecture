using System;
using System.Collections.Generic;

namespace SystemArchitecture.Models
{
    public class Member // Class Member sebagai Atribut Menu Anggota yang diperlukan
    {
        public int MemberId { get; set; } // Id Anggota
        public string Name { get; set; } // Nama Anggota
        public string Email { get; set; } // Email Anggota

        public override string ToString() // Method untuk menampilkan data Anggota
        {
            return $"MemberId: {MemberId}\nName: {Name}\nEmail: {Email}\n";
        }
    }
}
