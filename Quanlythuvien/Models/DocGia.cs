using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class DocGia
    {
        private string maDG;
        private string hovaTen;
        private string donVi;
        private string ngaySinh;
        private string gioiTinh;
        private string email;

        public string MaDG { get => maDG; set => maDG = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string HovaTen { get => hovaTen; set => hovaTen = value; }
    }
}
