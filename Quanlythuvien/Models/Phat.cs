using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class Phat
    {
        private string maPhat;
        private string maDG;
        private string maS;
        private string ngayXuPhat;
        private string sotien;

        public string MaDG1 { get => maDG; set => maDG = value; }
        public string MaPhat { get => maPhat; set => maPhat = value; }
        public string MaS { get => maS; set => maS = value; }
        public string NgayXuPhat { get => ngayXuPhat; set => ngayXuPhat = value; }
        public string Sotien { get => sotien; set => sotien = value; }
    }
}
