using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;

namespace Quanlythuvien.Controllers
{
    class ThuThu
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "ThuThu";
        public int Insert(Models.ThuThu m)
        {
            string query = "INSERT INTO " + table + " (MaTT, HovaTen, GioiTinh, NgaySinh, DiaChi, Email) " +
            "VALUES(N'"
            + m.MaTT + "', N'"
            + m.HovaTen + "', N'"
            + m.GioiTinh + "', N'"
            + m.NgaySinh + "', N'"
            + m.DiaChi + "', N'"
            + m.Email + "')";
            return da.Write(query);
        }
        //* Mã Thủ thư - Tên Thủ thư - Email

        public int UpdateTaiKhoan(Models.ThuThu m)
        {
            string query = "UPDATE " + table + " SET HovaTen=N'"
                + m.HovaTen + "', Email=N'"
                + m.Email + "' WHERE MaTT= '" + m.MaTT + "'";
            return da.Write(query);
        }

        public int Update(Models.ThuThu m)
        {
            string query = "UPDATE " + table + " SET MaTT=N'"
                + m.MaTT + "', HovaTen=N'"
                + m.HovaTen + "', GioiTinh=N'"
                + m.GioiTinh + "', NgaySinh=N'"
                + m.NgaySinh + "', DiaChi=N'"
                + m.DiaChi + "', Email=N'"
                + m.Email + "' WHERE MaTT= '" + m.MaTT + "'";
            return da.Write(query);
        }
        public int Delete(Models.ThuThu m)
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
