using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;

namespace Quanlythuvien.Controllers
{
    class MuonSach
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "PhieuMuon";
        public int Insert(Models.MuonSach m)
        {
            string query = "INSERT INTO " + table + " (MaDG, MaTT, NgayMuon) " +
            "VALUES(N'"
            + m.MaDG + "', N'"
            + m.MaTT + "', N'"
            + m.NgayMuon + "')";
            return da.Write(query);
        }
        //* Mã Thủ thư - Tên Thủ thư - Email

        public int Update(Models.MuonSach m)
        {
            string query = "UPDATE " + table + " SET MaDG=N'"
                + m.MaDG + "', MaTT=N'"
                + m.MaTT + "', NgayMuon=N'"
                + m.NgayMuon + "' WHERE MaPM= '" + m.MaPM + "'";
            return da.Write(query);
        }
        public int Delete(Models.MuonSach m)
        {
            string query = "DELETE " + table + " WHERE MaPM= '" + m.MaPM + "'";
            return da.Write(query);
        }
        public int DeleteWithMaTT(Models.MuonSach m)
        {
            string query = "DELETE " + table + " WHERE MaTT= '" + m.MaTT + "'";
            return da.Write(query);
        }
        public int DeleteWithMaDG(Models.MuonSach m)
        {
            string query = "DELETE " + table + " WHERE MaDG= '" + m.MaDG + "'";
            return da.Write(query);
        }
        /// <summary>
        /// Nhật ký lỗi
        /// </summary>
        /// <param name="value"></param>
        /// <param name="path"></param>
    }
}
