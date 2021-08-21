using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class Sach
    {
        private string maS;
        private string tenSach;
        private string maNXB;
        private string theLoai;
        private string namXB;
        private string giatien;
        private byte[] file;
        private string fileName;
        private string tacGia;
        private string soLuong;

        public string MaS { get => maS; set => maS = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string NamXB { get => namXB; set => namXB = value; }
        public byte[] File { get => file; set => file = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string Giatien { get => giatien; set => giatien = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
    }
}
