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
using Quanlythuvien.Models;
using System.Threading;

namespace Quanlythuvien
{
    public partial class AdminThuThu : Form
    {
        Thread th;
        string connection = Properties.Settings.Default.connection;
        Controllers.ThuThu ctrlThuThu = new Controllers.ThuThu();
        Controllers.MuonSach ctrlMuonSach = new Controllers.MuonSach();
        Controllers.TraSach ctrlTraSach = new Controllers.TraSach();
        Controllers.TaiKhoan ctrlTaiKhoan = new Controllers.TaiKhoan();

        Models.ThuThu modelThuThu = new Models.ThuThu();
        Models.MuonSach modelMuonSach = new Models.MuonSach();
        Models.TraSach modelTraSach = new Models.TraSach();
        Models.TaiKhoan modelTaiKhoan = new Models.TaiKhoan();

        string code;
        string ten;
        string gioitinh;
        string ngaysinh;
        string diachi;
        string email;
        string sodienthoai;
        string ngayvaolam;

        //
        string getid;

        public AdminThuThu(string id)
        {
            getid = id;
            InitializeComponent();
            Getlist();
        }

        private void tbxBirthday_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT HovaTen FROM " +
                "ThuThu WHERE MaTT = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", getid);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
                lbUsername.Text = da.GetValue(0).ToString();
            conn.Close();
            Getlist();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNu.Checked)
                checkNam.Enabled = false;
            else
                checkNam.Enabled = true;
        }

        private void checkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNam.Checked)
                checkNu.Enabled = false;
            else
                checkNu.Enabled = true;
        }

        private void tbxRefresh_Click(object sender, EventArgs e)
        {
            tbxMa.Enabled = true;
            tbxMa.Text = "";
            tbxTen.Text = "";
            checkNam.Checked = false;
            checkNu.Checked = false;
            tbxNgaySinh.Text = "";
            tbxEmail.Text = "";
            tbxDiaChi.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                modelThuThu.MaTT = code;
                modelThuThu.HovaTen = ten;
                modelThuThu.GioiTinh = gioitinh;
                modelThuThu.NgaySinh = ngaysinh;
                modelThuThu.DiaChi = diachi;
                modelThuThu.Email = email;
                modelThuThu.SoDienThoai = sodienthoai;
                modelThuThu.NgayVaoLam = ngayvaolam;
                ctrlThuThu.Insert(modelThuThu);
                modelThuThu.MaTT = "";
                modelThuThu.HovaTen = "";
                modelThuThu.GioiTinh = "";
                modelThuThu.NgaySinh = "";
                modelThuThu.DiaChi = "";
                modelThuThu.Email = "";
                modelThuThu.SoDienThoai = "";
                modelThuThu.NgayVaoLam = "";
                Getlist();
                MessageBox.Show("Tạo thủ thư thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelThuThu.MaTT))
            {
                if (tbxMa.Text == grv.SelectedRows[0].Cells[0].Value.ToString())
                {
                    if (CheckValidateUpdate())
                    {
                        modelThuThu.MaTT = code;
                        modelThuThu.HovaTen = ten;
                        modelThuThu.GioiTinh = gioitinh;
                        modelThuThu.NgaySinh = ngaysinh;
                        modelThuThu.DiaChi = diachi;
                        modelThuThu.Email = email;
                        modelThuThu.SoDienThoai = sodienthoai;
                        modelThuThu.NgayVaoLam = ngayvaolam;

                        ctrlThuThu.Update(modelThuThu);

                        // get value from db
                        SqlConnection con = new SqlConnection(connection);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT TaiKhoan.MaTT, TenTaiKhoan, MatKhau, PhanQuyen, ThuThu.Email, ThuThu.HovaTen" +
                            " FROM TaiKhoan, ThuThu WHERE TaiKhoan.MaTT = N'" + code + "'", con);
                        SqlDataReader da = cmd.ExecuteReader();
                        if (da.Read())
                        {
                            string matt = da.GetValue(0).ToString();
                            string tentaikhoan = da.GetValue(1).ToString();
                            string matkhau = da.GetValue(2).ToString();
                            string phanquyen = da.GetValue(3).ToString();
                            string email = da.GetValue(4).ToString();
                            string tennguoidung = da.GetValue(5).ToString();

                            //
                            modelTaiKhoan.MaTT = matt;
                            modelTaiKhoan.TenTaiKhoan = tentaikhoan;
                            modelTaiKhoan.MatKhau = matkhau;
                            modelTaiKhoan.PhanQuyen = phanquyen;
                            modelTaiKhoan.Email = email;
                            modelTaiKhoan.TenNguoiDung = tennguoidung;
                        }
                        ctrlTaiKhoan.Update(modelTaiKhoan);

                        modelThuThu.MaTT = "";
                        modelThuThu.HovaTen = "";
                        modelThuThu.GioiTinh = "";
                        modelThuThu.NgaySinh = "";
                        modelThuThu.DiaChi = "";
                        modelThuThu.Email = "";
                        modelThuThu.SoDienThoai = "";
                        modelThuThu.NgayVaoLam = "";
                        Getlist();
                        MessageBox.Show("Cập nhật thủ thư thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã thủ thư không thể thay đổi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelThuThu.MaTT))
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa tất cả thông tin liên quan đến thủ thư này!", "Sau khi xóa không thể khôi phục dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (getid != tbxMa.Text)
                    {
                        modelMuonSach.MaTT = modelThuThu.MaTT;
                        modelTraSach.MaTT = modelTraSach.MaTT;
                        modelTaiKhoan.MaTT = modelThuThu.MaTT;

                        ctrlTaiKhoan.DeleteWithMaTT(modelTaiKhoan);
                        ctrlMuonSach.DeleteWithMaTT(modelMuonSach);
                        ctrlThuThu.Delete(modelThuThu);
                        modelThuThu.MaTT = "";
                        Getlist();
                        MessageBox.Show("Xóa thủ thư thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!","Cảnh báo!", MessageBoxButtons.OK);
                    }

                }

            }
        }
        string DateChange(string ngaythang)
        {
            string[] tmp = ngaythang.Split('/');
            return tmp[2] + '/' + tmp[1] + '/' + tmp[0];
        }
        private bool CheckValidate()
        {

            code = tbxMa.Text;
            ten = tbxTen.Text;
            if (checkNam.Checked)
                gioitinh = "Nam";
            else if (checkNu.Checked)
                gioitinh = "Nữ";
            else
                gioitinh = "Chưa xác định";
            ngaysinh = DateChange(tbxNgaySinh.Text);
            diachi = tbxDiaChi.Text;
            email = tbxEmail.Text;

            lbCode.Text = "";
            lbDiaChi.Text = "";
            lbEmail.Text = "";
            lbNgaysinh.Text = "";
            lbReasult.Text = "";
            lbGT.Text = "";
            lbTen.Text = "";

            lbCode.ForeColor = Color.Red;
            lbDiaChi.ForeColor = Color.Red;
            lbEmail.ForeColor = Color.Red;
            lbNgaysinh.ForeColor = Color.Red;
            lbReasult.ForeColor = Color.Red;
            lbGT.ForeColor = Color.Red;
            lbTen.ForeColor = Color.Red;



            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da;
            SqlCommand cm;
            DataTable dt = new DataTable();
            cm = new SqlCommand("SELECT MaTT FROM ThuThu WHERE MaTT ='" + code + "'", conn);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            int thuthu = dt.Rows.Count;

            if (string.IsNullOrEmpty(code))
            {
                lbCode.Text = "Vui lòng nhập mã Thủ thư!";
                tbxMa.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(ten))
            {
                lbTen.Text = "Vui lòng nhập tên thủ thư!";
                tbxTen.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                lbEmail.Text = "Vui lòng nhập Email!";
                tbxEmail.Focus();
                return false;
            }
            else if (thuthu > 0)
            {
                lbCode.Text = "Mã thủ thư đã tồn tại!";
                tbxMa.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckValidateUpdate()
        {

            code = tbxMa.Text;

            lbCode.Text = "";
            lbDiaChi.Text = "";
            lbEmail.Text = "";
            lbGT.Text = "";
            lbNgaysinh.Text = "";
            lbTen.Text = "";



            lbCode.ForeColor = Color.Red;
            lbDiaChi.ForeColor = Color.Red;
            lbEmail.ForeColor = Color.Red;
            lbGT.ForeColor = Color.Red;
            lbNgaysinh.ForeColor = Color.Red;
            lbTen.ForeColor = Color.Red;

            tbxMa.Enabled = false;
            ten = tbxTen.Text;
            if (checkNam.Checked)
                gioitinh = "Nam";
            else if (checkNu.Checked)
                gioitinh = "Nữ";
            else
                gioitinh = "Chưa xác định";
            ngaysinh = DateChange(tbxNgaySinh.Text);
            diachi = tbxDiaChi.Text;
            email = tbxEmail.Text;

            if (string.IsNullOrEmpty(code))
            {
                lbCode.Text = "Vui lòng nhập mã Thủ thư!";
                tbxMa.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(ten))
            {
                lbTen.Text = "Vui lòng nhập tên thủ thư!";
                tbxTen.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                lbEmail.Text = "Vui lòng nhập Email!";
                tbxEmail.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Getlist()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaTT, HovaTen, GioiTinh, CONVERT(Nvarchar, NgaySinh, 103), DiaChi, " +
                "Email FROM ThuThu ", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
                grv.DataSource = dt;
            grv.Columns[0].HeaderText = "ID thủ thư";
            grv.Columns[1].HeaderText = "Họ và tên";
            grv.Columns[2].HeaderText = "Giới tính";
            grv.Columns[3].HeaderText = "Ngày sinh";
            grv.Columns[4].HeaderText = "Địa chỉ";
            grv.Columns[5].HeaderText = "Email";
        }

        private void grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMa.Enabled = false;
            modelThuThu.MaTT = grv.SelectedRows[0].Cells[0].Value.ToString();

            tbxMa.Text = grv.SelectedRows[0].Cells[0].Value.ToString();
            tbxTen.Text = grv.SelectedRows[0].Cells[1].Value.ToString();
            if (grv.SelectedRows[0].Cells[2].Value.ToString() == "Nam")
                checkNam.Checked = true;
            else if (grv.SelectedRows[0].Cells[2].Value.ToString() == "Nữ")
                checkNu.Checked = true;
            tbxNgaySinh.Text = grv.SelectedRows[0].Cells[3].Value.ToString();
            tbxDiaChi.Text = grv.SelectedRows[0].Cells[4].Value.ToString();
            tbxEmail.Text = grv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void AdminThuThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            th = new Thread(OpennewAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void OpennewAdmin()
        {
            Application.Run(new Admin(getid));
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            th = new Thread(OpennewMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void OpennewMain()
        {
            Application.Run(new FormMain());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
