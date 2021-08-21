using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.DataAccess;
using Quanlythuvien.Models;

namespace Quanlythuvien.Controllers
{
    class TaiKhoan
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "TaiKhoan";
        public int Insert(Models.TaiKhoan m)
        {
            string query = "INSERT INTO " + table + " (TenNguoiDung, TenTaiKhoan, MatKhau, PhanQuyen, MaTT, Email) " +
            "VALUES(N'"
            + m.TenNguoiDung + "', N'"
            + m.TenTaiKhoan + "', N'"
            + m.MatKhau + "', N'"
            + m.PhanQuyen + "', N'"
            + m.MaTT + "', N'"
            + m.Email + "')";
            return da.Write(query);
        }
        public int Update(Models.TaiKhoan m)
        {
            string query = "UPDATE " + table + " SET TenNguoiDung=N'"
                + m.TenNguoiDung + "', TenTaiKhoan=N'"
                + m.TenTaiKhoan + "', MatKhau=N'"
                + m.MatKhau + "', PhanQuyen=N'"
                + m.PhanQuyen + "', Email=N'"
                + m.Email + "' WHERE MaTT='" + m.MaTT + "'";
            return da.Write(query);
        }
        public int DeleteWithMaTT(Models.TaiKhoan m)
        {
            string query = "DELETE " + table + " WHERE MaTT = '" + m.MaTT + "'";
            return da.Write(query);
        }
        /// <summary>
        /// Nhật ký lỗi
        /// </summary>
        /// <param name="value"></param>
        /// <param name="path"></param>
        public void Log(String value)
        {
            string path = @"F:\LTCSharp_QLDTKH\QLDTKH\QLDTKH\LogCAccount.txt";

            using (StreamWriter s = new StreamWriter(path, true))
            {
                s.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ": " + value);
                s.WriteLine(Environment.NewLine + "------------------------------------------------------------------" + Environment.NewLine);
            }
        }
    }
}
