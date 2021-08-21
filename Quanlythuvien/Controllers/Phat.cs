using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    class Phat
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "Phat";
        public int Insert(Models.Phat m)
        {
            string query = "INSERT INTO " + table + " (MaDG, MaS, NgayXuPhat, SoTien) " +
            "VALUES(N'"
            + m.MaDG1 + "', N'"
            + m.MaS + "', N'"
            + m.NgayXuPhat + "', N'"
            + m.Sotien + "')";
            return da.Write(query);
        }
        //* Mã Thủ thư - Tên Thủ thư - Email

        public int Update(Models.Phat m)
        {
            string query = "UPDATE " + table + " SET MaDG=N'"
                + m.MaDG1 + "', MaS=N'"
                + m.MaS + "', NgayXuPhat=N'"
                + m.NgayXuPhat + "', SoTien=N'"
                + m.Sotien + "' WHERE MaPhat= '" + m.MaPhat + "'";
            return da.Write(query);
        }
        public int Delete(string maphat)
        {
            string query = "DELETE " + table + " WHERE MaPhat= '" + maphat + "'";
            return da.Write(query);
        }
        public int DeleteWithMaDG(string maphat)
        {
            string query = "DELETE " + table + " WHERE MaDG= '" + maphat + "'";
            return da.Write(query);
        }
    }
}
