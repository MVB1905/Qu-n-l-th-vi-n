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
using System.Threading;
using System.IO;

namespace Quanlythuvien
{
    public partial class FormMain : Form
    {
        Thread th;
        string connection = Properties.Settings.Default.connection;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnTimkiem.BringToFront();
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT Sach.MaS, Sach.TenSach, Sach.TacGia, Sach.TheLoai, NhaXB, Sach.NamXB " +
                "FROM Sach", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                HienThiDS(dt);
            }
        }
        private void HienThiDS(DataTable tb)
        {
            dgvDanhSachTL.DataSource = null;
            dgvDanhSachTL.DataSource = tb;
            dgvDanhSachTL.Columns[0].HeaderText = "Mã Sách";
            dgvDanhSachTL.Columns[1].HeaderText = "Tên Sách";
            dgvDanhSachTL.Columns[2].HeaderText = "Tác Giả";
            dgvDanhSachTL.Columns[3].HeaderText = "Thể Loại";
            dgvDanhSachTL.Columns[4].HeaderText = "Nhà Xuất Bản";
            dgvDanhSachTL.Columns[5].HeaderText = "Năm Xuất Bản";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            btHuyTK.BringToFront();
            if (string.IsNullOrEmpty(tbTimKiem.Text))
            {

                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
                btnTimkiem.BringToFront();
            }
            else
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("SELECT Sach.MaS, Sach.TenSach, Sach.TacGia, Sach.TheLoai, NhaXB, Sach.NamXB " +
                                                        "FROM Sach where ((Sach.MaS like '%' + @search + '%') or (Sach.TenSach like '%' + @search + '%')" +
                                                                                    "or (Sach.TacGia like '%' + @search + '%') or (Sach.TheLoai like '%' + @search + '%') " +
                                                                                    "or (Sach.NamXB like '%' + @search + '%') or (NhaXB like '%' + @search + '%'))", conn);
                string search = tbTimKiem.Text;
                da.SelectCommand.Parameters.AddWithValue("@search", search);
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb != null)
                {
                    HienThiDS(tb);
                }
                else
                {
                    MessageBox.Show("Bug");
                }

            }
        }

        private void btHuyTK_Click(object sender, EventArgs e)
        {
            btnTimkiem.BringToFront();
            tbTimKiem.Text = "";
            dgvDanhSachTL.DataSource = null;
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT Sach.MaS, Sach.TenSach, Sach.TacGia, Sach.TheLoai, NhaXB, Sach.NamXB FROM Sach", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                HienThiDS(dt);
            }
        }

        private void lbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void lbEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewForgot);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void OpennewLogin()
        {
            Application.Run(new Login());
        }
        public void OpennewForgot()
        {
            Application.Run(new Forgot());
        }

        public void OpennewCreate()
        {
            Application.Run(new Create());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = dgvDanhSachTL.SelectedRows;
            
            foreach (var row in select)
            {
                string id = (string)((DataGridViewRow)row).Cells[0].Value;
                if (CheckFile(id))
                    OpenFile(id);
                else
                    MessageBox.Show("Tài liệu này chưa cập nhật trực tuyến, vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        bool CheckFile(string id)
        {
            string filename;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            SqlCommand command = new SqlCommand("Select Filename from Sach where MaS=@id", conn);
            command.Parameters.AddWithValue("@id", id);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == "Chưa có tài liệu")
                        return false;
                    else
                        return true;
                }
                else
                    return false;
            }

        }
        void OpenFile(string id)
        {
            /*
             * Từ vị trí 1 - 3: Chiều dài của tên file
             * Từ file 4 - 4 + chiều dài của file: tên file
             * từ 4 + chiều dài của file: File
             */
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT [File], FileName FROM Sach WHERE MaS = @id", con);
            cmd.Parameters.Add("@id", id);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var data = (byte[])reader[0];
                var filename = reader[1].ToString();
                string[] extens = filename.Split('.');

                File.WriteAllBytes(filename, data);
                System.Diagnostics.Process.Start(filename);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewCreate);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
