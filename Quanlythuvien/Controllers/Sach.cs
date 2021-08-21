namespace Quanlythuvien.Controllers
{
    class Sach
    {
        DataAccess.Access da = new DataAccess.Access();
        string table = "Sach";
        public int Insert(Models.Sach m)
        {
            string query = "INSERT INTO " + table + " (MaS, TenSach, MaNXB, TheLoai, TacGia, NamXB, GiaTien, [File], FileName) " +
            "VALUES(N'"
            + m.MaS + "', N'"
            + m.TenSach + "', N'"
            + m.MaNXB + "', N'"
            + m.TheLoai + "', N'"
            + m.TacGia + "', N'"
            + m.NamXB + "', N'"
            + m.Giatien + "', N'"
            + m.File + "', N'"
            + m.FileName + "')";
            return da.Write(query);
        }
        public int Update(Models.Sach m)
        {
            string query = "UPDATE " + table + " SET TenSach=N'"
                + m.TenSach + "', MaNXB=N'"
                + m.MaNXB + "', TheLoai=N'"
                + m.TheLoai + "', TacGia=N'"
                + m.TacGia + "', NamXB=N'"
                + m.NamXB + "', GiaTien=N'"
                + m.Giatien + "', [File]=N'"
                + m.File + "', FileName=N'"
                + m.FileName + "' WHERE MaS= N'" + m.MaS + "'";
            return da.Write(query);
        }
        public int Delete(Models.Sach m)
        {
            string query = "DELETE " + table + " WHERE MaS = '" + m.MaS + "'";
            return da.Write(query);
        }
        /// <summary>
        /// Nhật ký lỗi
        /// </summary>
        /// <param name="value"></param>
        /// <param name="path"></param>
    }
}
