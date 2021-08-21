using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Controllers;

namespace Quanlythuvien
{
    public partial class MuonSach : Form
    {
        //
        string connection = Properties.Settings.Default.connection;


        //
        Controllers.ChiTietPhieuMuon ctrlChitiet = new ChiTietPhieuMuon();
        Models.ChiTietPhieuMuon modelsChitiets = new Models.ChiTietPhieuMuon();
        //

        Models.Sach modelSach = new Models.Sach();

        Controllers.Sach ctrlSach = new Controllers.Sach();

        string getMa;
        string ngayMuon;
        string hanTra;
        public MuonSach(string MaPM)
        {
            getMa = MaPM;
            InitializeComponent();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("  SELECT PhieuMuon.MaDG, DocGia.HovaTen, PhieuMuon.MaTT, ThuThu.HovaTen, CONVERT(Nvarchar, PhieuMuon.NgayMuon, 103) " +
                "FROM PhieuMuon, DocGia, ThuThu WHERE PhieuMuon.MaDG = DocGia.MaDG AND PhieuMuon.MaTT = ThuThu.MaTT AND PhieuMuon.MaPM = " + getMa, conn);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                lbMaPM.Text = getMa;
                lbMaDG.Text = da.GetValue(0).ToString();
                lbTenDG.Text = da.GetValue(1).ToString();
                lbMaTT.Text = da.GetValue(2).ToString();
                lbTenTT.Text = da.GetValue(3).ToString();
                lbNgayLapPhieu.Text = da.GetValue(4).ToString();

            }
            conn.Close();
            Getlist();
            if (grvM.Rows.Count > 0)
            {
                btnMuonSach.Enabled = false;
            }
        }
        private void Getlist()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("  SELECT ChiTietPhieuMuon.MaS, Sach.TenSach, CONVERT(Nvarchar, PhieuMuon.NgayMuon, 103) , CONVERT(Nvarchar, ChiTietPhieuMuon.HanTra, 103), ChiTietPhieuMuon.TrangThai, ChiTietPhieuMuon.SoLuong " +
                "FROM ChiTietPhieuMuon, PhieuMuon, Sach WHERE ChiTietPhieuMuon.MaPM = PhieuMuon.MaPM AND ChiTietPhieuMuon.MaS = Sach.MaS and ChiTietPhieuMuon.MaPM = " + getMa, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
                grvM.DataSource = dt;
            grvM.Columns[0].HeaderText = "Mã sách";
            grvM.Columns[1].HeaderText = "Tên sách";
            grvM.Columns[2].HeaderText = "Ngày mượn";
            grvM.Columns[3].HeaderText = "Hạn trả";
            grvM.Columns[4].HeaderText = "Trạng thái";
            grvM.Columns[5].HeaderText = "Số lượng";
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            ChonSach f = new ChonSach(lbMaDG.Text, lbMaPM.Text);
            f.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Getlist();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (grvM.SelectedRows[0].Cells[4].Value.ToString() != "Đã trả")
            {
                string maS = grvM.SelectedRows[0].Cells[0].Value.ToString();
                string maPm = getMa;

                SqlConnection con = new SqlConnection(connection);
                string query = "UPDATE ChiTietPhieuMuon SET TrangThai = N'Đã trả'  WHERE MaPM = " + lbMaPM.Text + "AND MaS = N'" + maS + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Getlist();

                con.Open();
                int slsach = 0;
                query = "SELECT SoLuong FROM Sach Where MaS = N'" + maS + "'";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    slsach = Int32.Parse(dr.GetValue(0).ToString());
                }
                con.Close();

                con.Open();
                int slmuon = 0;
                query = "SELECT SoLuong FROM ChiTietPhieuMuon Where MaS = N'" + maS + "' AND MaPM = N'" + maPm + "'";
                cm = new SqlCommand(query, con);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    slmuon = Int32.Parse(dr.GetValue(0).ToString());
                }
                con.Close();

                modelSach.SoLuong = (slsach + slmuon).ToString();
                modelSach.MaS = maS;
                // Sql query
                query = "UPDATE Sach SET SoLuong=" + modelSach.SoLuong +
                     " WHERE MaS = N'" + modelSach.MaS + "'";
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                string today = DateTime.Today.ToString("yyyy/MM/dd");
                // Insert to TraSach
                query = "INSERT INTO TraSach " +
                    "VALUES(N'" + lbMaDG.Text + "', N'" + maS + "', '" + today + "')";
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Sách này đã được trả!");
            }
        }
    }
}
