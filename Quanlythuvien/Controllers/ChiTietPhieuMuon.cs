using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    class ChiTietPhieuMuon
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "ChiTietPhieuMuon";
        public int Insert(Models.ChiTietPhieuMuon m)
        {
            string query = "INSERT INTO " + table + " (MaPM, MaDG, MaS, HanTra, SoLuong, TrangThai) " +
            "VALUES(N'"
            + m.MaPM + "', N'"
            + m.MaDG + "', N'"
            + m.MaS + "', N'"
            + m.HanTra + "', N'"
            + m.SoLuong + "', N'"
            + m.TrangThai + "')";
            return da.Write(query);
        }
        //* Mã Thủ thư - Tên Thủ thư - Email

        public int Update(Models.ChiTietPhieuMuon m)
        {
            string query = "UPDATE " + table + " SET MaS=N'"
                + m.MaS + "', MaDG=N'" + m.MaDG + "', HanTra=N' "+ m.HanTra + "', SoLuong=N'" + m.SoLuong +"', TrangThai =N'"+ m.TrangThai + " WHERE MaPM= '" + m.MaPM + "'";
            return da.Write(query);
        }
        public int Delete(Models.ChiTietPhieuMuon m)
        {
            string query = "DELETE " + table + " WHERE MaPM= '" + m.MaPM + "'";
            return da.Write(query);
        }
        public int DeleteWithMaDG(Models.ChiTietPhieuMuon m)
        {
            string query = "DELETE " + table + " WHERE MaDG= '" + m.MaDG + "'";
            return da.Write(query);
        }
    }
}
