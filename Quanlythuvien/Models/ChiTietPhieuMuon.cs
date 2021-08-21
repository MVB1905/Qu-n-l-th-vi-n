using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class ChiTietPhieuMuon
    {

        private string maPM;
        private string maS;
        private string hanTra;
        private string maDG;
        private string trangThai;
        private string soLuong;
        public string MaPM { get => maPM; set => maPM = value; }
        public string MaS { get => maS; set => maS = value; }
        public string HanTra { get => hanTra; set => hanTra = value; }
        public string MaDG { get => maDG; set => maDG = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
    }
}
