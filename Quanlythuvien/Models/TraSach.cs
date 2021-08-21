using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class TraSach
    {
        private string maDG;
        private string maS;
        private string maTT;
        private string ngayTra;

        public string MaDG { get => maDG; set => maDG = value; }
        public string MaS { get => maS; set => maS = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
