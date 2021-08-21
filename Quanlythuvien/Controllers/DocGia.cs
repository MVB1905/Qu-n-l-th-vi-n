using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;

namespace Quanlythuvien.Controllers
{
    class DocGia
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "DocGia";
        public int Insert(Models.DocGia m)
        {
            string query = "INSERT INTO " + table + " (MaDG, HovaTen, DonVi) " +
            "VALUES(N'"
            + m.MaDG + "', N'"
            + m.HovaTen + "', N'"
            + m.DonVi + "')";
            return da.Write(query);
        }
        public int Update(Models.DocGia m)
        {
            string query = "UPDATE " + table + " SET HovaTen=N'"
                + m.HovaTen + "', DonVi=N'"
                + m.DonVi + "' WHERE MaDG = '"  + m.MaDG + "'";
            return da.Write(query);
        }
        public int Delete(Models.DocGia m)
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
