using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class ThuThu
    {
        private string maTT;
        private string gioiTinh;
        private string ngaySinh;
        private string diaChi;
        private string email;
        private string soDienThoai;
        private string ngayVaoLam;
        private string hovaTen;

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public string HovaTen { get => hovaTen; set => hovaTen = value; }
    }
}
