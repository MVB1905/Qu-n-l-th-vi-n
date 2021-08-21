using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;

namespace Quanlythuvien.Controllers
{
    class TraSach
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "TraSach";
        public int Insert(Models.TraSach m)
        {
            string query = "INSERT INTO " + table + " (MaDG, MaS, NgayTra) " +
            "VALUES(N'"
            + m.MaDG + "', N'"
            + m.MaS + "', N'"
            + m.NgayTra + "')";
            return da.Write(query);
        }
        //* Mã Thủ thư - Tên Thủ thư - Email

        public int Update(Models.TraSach m)
        {
            string query = "UPDATE " + table + " SET MaDG=N'"
                + m.MaDG + "', NgayTra=N'"
                + m.NgayTra + "' WHERE MaDG= '" + m.MaDG + "'";
            return da.Write(query);
        }
        public int DeleteWithMaDG(Models.TraSach m)
        {
            string query = "DELETE " + table + " WHERE MaDG= '" + m.MaDG + "'";
            return da.Write(query);
        }
        public int DeleteWithMaTT(Models.TraSach m)
        {
            string query = "DELETE " + table + " WHERE MaTT= '" + m.MaTT + "'";
            return da.Write(query);
        }
        /// <summary>
        /// Nhật ký lỗi
        /// </summary>
        /// <param name="value"></param>
        /// <param name="path"></param>

    }
}
