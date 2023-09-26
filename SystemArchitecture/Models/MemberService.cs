using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemArchitecture.Models
{
    public class MemberService // Class Untuk Layanan Menu Anggota
    {
        private List<Member> members = new List<Member>();

        public void AddMember(int memberId, string name, string email) // Fungsi Untuk Menambahkan Anggota
        {
            members.Add(new Member { MemberId = memberId, Name = name, Email = email });
        }

        public void EditMember(int memberId, string name, string email) // Fungsi untuk Mengedit Anggota
        {
            var member = members.Find(m => m.MemberId == memberId);
            if (member != null)
            {
                member.Name = name;
                member.Email = email;
            }
        }

        public void DeleteMember(int memberId) // Fungsi untuk Menghapus Anggota
        {
            var member = members.Find(m => m.MemberId == memberId);
            if (member != null)
            {
                members.Remove(member);
            }
        }

        public List<Member> GetAllMembers() // Fungsi untuk Menampilkan Semua Anggota
        {
            return members;
        }
    }
}
