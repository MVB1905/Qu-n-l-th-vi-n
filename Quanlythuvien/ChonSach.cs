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

namespace Quanlythuvien
{
    public partial class ChonSach : Form
    {
        string connection = Properties.Settings.Default.connection;


        Controllers.ChiTietPhieuMuon ctrlchitiet = new Controllers.ChiTietPhieuMuon();
        Controllers.Sach ctrlSach = new Controllers.Sach();

        Models.Sach modelSach = new Models.Sach();
        Models.ChiTietPhieuMuon modelsChitiet = new Models.ChiTietPhieuMuon();


        string getmapm;
        string getmadg;
        public ChonSach(string madg, string mapm)
        {
            getmadg = madg;
            getmapm = mapm;
            InitializeComponent();
        }

        private void ChonSach_Load(object sender, EventArgs e)
        {
            rbMa.Checked = true;
            cbxTL.SelectedIndex = 0;
            query("");
        }
        void query(string codition)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            string query = "SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, SoLuong FROM Sach ";
            if (!string.IsNullOrEmpty(codition))
                query += codition;

            SqlCommand cm = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
                grvM.DataSource = dt;
            grvM.Columns[0].HeaderText = "Mã sách";
            grvM.Columns[1].HeaderText = "Tên sách";
            grvM.Columns[2].HeaderText = "Nhà xuất bản";
            grvM.Columns[3].HeaderText = "Thể loại";
            grvM.Columns[4].HeaderText = "Tác giả";
            grvM.Columns[5].HeaderText = "Số lượng";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grvM.SelectedRows.Count > 0)
            {
                // Lấy giá trị số lượng
                int sl = Int32.Parse(tbxSoluong.Text);
                int slsach = 0;
                string maS = grvM.SelectedRows[0].Cells[0].Value.ToString();
                // Select soluong sách
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                string query = "SELECT SoLuong FROM Sach Where MaS = N'"  + maS +  "'";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    slsach = Int32.Parse(dr.GetValue(0).ToString());
                }
                con.Close();
                // kiểm tra số lượng sách
                if (slsach > sl)
                {
                    modelSach.SoLuong = (slsach - sl).ToString();
                    modelSach.MaS = maS;
                    // Sql query
                    query = "UPDATE Sach SET SoLuong=" + modelSach.SoLuong +
                         " WHERE MaS = N'" + modelSach.MaS + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    modelsChitiet.MaDG = getmadg;
                    modelsChitiet.MaPM = getmapm;
                    modelsChitiet.MaS = maS;
                    modelsChitiet.SoLuong = sl.ToString();
                    modelsChitiet.TrangThai = "Đang mượn";
                    modelsChitiet.HanTra = DateTime.Today.AddDays(60).ToString("yyyyMMdd");
                    ctrlchitiet.Insert(modelsChitiet);
                    MessageBox.Show("Mượn thành công sách: " + grvM.SelectedRows[0].Cells[1].Value.ToString());
                }
                else
                    MessageBox.Show("Không đủ số lượng sách cần mượn!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 


            }
            else
                MessageBox.Show("Bạn chưa chọn sách để mượn!");
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string codition = "";
            if (!string.IsNullOrEmpty(tbxSearch.Text))
            {
                if (rbMa.Checked)
                {
                    if (cbxTL.SelectedIndex != 0)
                    {
                        codition = " Where TheLoai Like '%' + N'" + cbxTL.Text + "' + '%' AND MaS LIKE N'" + tbxSearch.Text + "'";
                        query(codition);
                    }
                    else
                    {
                        // Select Ma
                        codition = " Where MaS LIKE N'" + tbxSearch.Text + "'";
                        query(codition);
                    }
                }
                else if (rbTen.Checked)
                {
                    // Select Ten
                    if (cbxTL.SelectedIndex != 0)
                    {
                        codition = " Where TheLoai Like '%' + N'" + cbxTL.Text + "' + '%' AND TenSach LIKE '%' + N'" + tbxSearch.Text + "' + '%'";
                        query(codition);
                    }
                    else
                    {
                        // Select Ten
                        codition = " Where TenSach LIKE '%' + N'" + tbxSearch.Text + "' + '%'";
                        query(codition);
                    }

                }
            }  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTen.Checked)
            {
                rbMa.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMa.Checked)
            {
                rbTen.Checked = false;
            }
        }

        private void cbxTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string q = "SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, SoLuong FROM Sach " +
                "WHERE TheLoai Like '%' + N'" + cbxTL.Text + "' + '%'";
            if (cbxTL.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb != null)
                {
                    grvM.DataSource = tb;
                    grvM.Columns[0].HeaderText = "Mã sách";
                    grvM.Columns[1].HeaderText = "Tên sách";
                    grvM.Columns[2].HeaderText = "Nhà xuất bản";
                    grvM.Columns[3].HeaderText = "Thể loại";
                    grvM.Columns[4].HeaderText = "Tác giả";
                    grvM.Columns[5].HeaderText = "Số lượng";
                }
                else
                {
                    MessageBox.Show("Hiện tại không có bản ghi nào");
                }
            }
            else
                query("");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string q = "";
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                if (cbxTL.SelectedIndex != 0)
                {
                    q = "SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, SoLuong FROM Sach " +
                        "WHERE TheLoai Like '%' + N'" + cbxTL.Text + "' + '%'";
                }
                else
                {
                    q = "SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, SoLuong FROM Sach ";
                }
                SqlConnection conn = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb != null)
                {
                    grvM.DataSource = tb;
                    grvM.Columns[0].HeaderText = "Mã sách";
                    grvM.Columns[1].HeaderText = "Tên sách";
                    grvM.Columns[2].HeaderText = "Nhà xuất bản";
                    grvM.Columns[3].HeaderText = "Thể loại";
                    grvM.Columns[4].HeaderText = "Tác giả";
                    grvM.Columns[5].HeaderText = "Số lượng";
                }
            }
        }
    }
}
