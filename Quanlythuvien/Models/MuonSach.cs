using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    class MuonSach
    {
        private string maPM;
        private string maDG;
        private string maTT;
        private string ngayMuon;

        public string MaPM { get => maPM; set => maPM = value; }
        public string MaDG { get => maDG; set => maDG = value; }
        public string MaTT { get => maTT; set => maTT = value; }
        public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
    }
}
