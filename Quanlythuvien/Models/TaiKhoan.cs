using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string tenNguoiDung;
        private string matKhau;
        private string phanQuyen;
        private string maTT;
        private string email;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string Email { get => email; set => email = value; }
    }
}
