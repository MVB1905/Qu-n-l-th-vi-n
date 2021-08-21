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
using System.Threading;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models;

namespace Quanlythuvien
{
    public partial class Admin : Form
    {
        //
        string code;
        string username;
        string password;
        string name;
        string email;
        string usertype;

        // 
        string hodem;
        string ten;


        //
        string getid;

        //
        string connection = Properties.Settings.Default.connection;

        Controllers.TaiKhoan ctrtTaiKhoan = new Controllers.TaiKhoan();
        Controllers.ThuThu ctrlThuThu = new Controllers.ThuThu();

        Models.TaiKhoan modelTaiKhoan = new Models.TaiKhoan();
        Models.ThuThu modelThuThu = new Models.ThuThu();

        //
        Thread th;
        public Admin(string id)
        {
            getid = id;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                ten = tbxName.Text;

                modelThuThu.MaTT = code;
                modelThuThu.HovaTen = ten;
                modelThuThu.Email = tbxEmail.Text;

                //
                modelTaiKhoan.TenTaiKhoan = username;
                modelTaiKhoan.MatKhau = password;
                modelTaiKhoan.MaTT = code;
                modelTaiKhoan.PhanQuyen = usertype;
                modelTaiKhoan.Email = tbxEmail.Text;
                modelTaiKhoan.TenNguoiDung = tbxName.Text;
                if (usertype.ToUpper() == "ADMIN" || usertype.ToUpper() == "STAFF")
                {
                    int check = 0;
                    // Kiểm tra dữ liệu tồn tại ở bảng nào
                    SqlConnection conn = new SqlConnection(connection);
                    SqlCommand cm = new SqlCommand("SELECT MaTT FROM ThuThu WHERE MaTT ='" + code + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int j = dt.Rows.Count;
                    if (j > 0)
                        check = 2;
                    // Dữ liệu không tồn tại
                    if (check == 0)
                    {
                        ctrlThuThu.Insert(modelThuThu);
                        ctrtTaiKhoan.Insert(modelTaiKhoan);
                    }
                    // Dữ liệu tồn tại
                    else if (check == 2)
                    {
                        ctrlThuThu.UpdateTaiKhoan(modelThuThu);
                        ctrtTaiKhoan.Insert(modelTaiKhoan);
                    }
                }
                else
                {
                    ctrtTaiKhoan.Insert(modelTaiKhoan);
                }

                Success("Tạo");
                tbxCode.Text = "";
                tbxUserame.Text = "";
                tbxName.Text = "";
                tbxEmail.Text = "";
                tbxPassword.Text = "";

                //
                modelTaiKhoan.TenTaiKhoan = "";
                modelTaiKhoan.MatKhau = "";
                modelTaiKhoan.MaTT = "";
                modelTaiKhoan.PhanQuyen = "";


                modelThuThu.MaTT = "";
                modelThuThu.HovaTen = "";
                modelThuThu.Email = "";

                Getlist();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelTaiKhoan.MaTT))
            {
                if (tbxCode.Text == grv.SelectedRows[0].Cells[3].Value.ToString())
                {
                    if (CheckValidateUpdate())
                    {
                        int check = 0;
                        modelThuThu.MaTT = code;
                        modelThuThu.HovaTen = ten;
                        modelThuThu.GioiTinh = "";
                        modelThuThu.NgaySinh = "";
                        modelThuThu.DiaChi = "";
                        modelThuThu.Email = email;
                        modelThuThu.SoDienThoai = "";
                        modelThuThu.NgayVaoLam = "";

                        //
                        modelTaiKhoan.TenTaiKhoan = tbxUserame.Text;
                        modelTaiKhoan.MatKhau = password;
                        modelTaiKhoan.MaTT = code;
                        modelTaiKhoan.PhanQuyen = usertype;
                        modelTaiKhoan.Email = tbxEmail.Text;
                        modelTaiKhoan.TenNguoiDung = tbxName.Text;
                        if (usertype.ToUpper() == "ADMIN" || usertype.ToUpper() == "STAFF")
                        {

                            // Kiểm tra dữ liệu tồn tại ở bảng nào
                            SqlConnection conn = new SqlConnection(connection);
                            SqlCommand cm = new SqlCommand("SELECT MaTT FROM ThuThu WHERE MaTT ='" + code + "'", conn);
                            SqlDataAdapter da = new SqlDataAdapter(cm);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            int j = dt.Rows.Count;
                            if (j > 0)
                                check = 2;
                            // Dữ liệu không tồn tại
                            if (check == 0)
                            {
                                ctrlThuThu.UpdateTaiKhoan(modelThuThu);
                                ctrtTaiKhoan.Update(modelTaiKhoan);
                            }
                            // Dữ liệu tồn tại
                            else if (check == 2)
                            {
                                ctrlThuThu.UpdateTaiKhoan(modelThuThu);
                                ctrtTaiKhoan.Update(modelTaiKhoan);
                            }
                        }
                        else
                        {
                            ctrtTaiKhoan.Update(modelTaiKhoan);
                        }

                        Success("Cập nhật");
                        tbxCode.Text = "";
                        tbxUserame.Text = "";
                        tbxName.Text = "";
                        tbxEmail.Text = "";
                        tbxPassword.Text = "";
                        Getlist();
                        tbxCode.Enabled = true;
                    }
                }
                else
                {
                    lbReasult.ForeColor = Color.Red;
                    lbReasult.Text = "Không thể thay đổi mã thủ thư, độc giả!";
                }
            }
            else
            {
                lbReasult.ForeColor = Color.Red;
                lbReasult.Text = "Chưa chọn thủ thư, độc giả cần cập nhật!";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelTaiKhoan.MaTT))
            {
                Success("Xóa");
                ctrtTaiKhoan.DeleteWithMaTT(modelTaiKhoan);
                tbxCode.Text = "";
                tbxUserame.Text = "";
                tbxName.Text = "";
                tbxEmail.Text = "";
                tbxPassword.Text = "";
                modelTaiKhoan.MaTT = "";
                Getlist();
                tbxCode.Enabled = true;
            }
            else
            {
                lbReasult.ForeColor = Color.Red;
                lbReasult.Text = "Vui lòng chọn tài khoản cần xóa!";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Tìm kiếm
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewFormMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnClearn_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewAdminThuThu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private bool CheckValidate()
        {
            code = tbxCode.Text;
            username = tbxUserame.Text;
            password = tbxPassword.Text;
            ten = tbxName.Text;
            email = tbxEmail.Text;

            usertype = cbxUsertype.Text;
            if (usertype == "Độc giả")
                usertype = "User";
            else if (usertype == "Thủ thư")
                usertype = "Staff";
            else if (usertype == "Quản trị viên")
                usertype = "Admin";

            lbCode.Text = "";
            lbName.Text = "";
            lbUser.Text = "";
            lbPass.Text = "";
            lbEmail.Text = "";
            lbCode.ForeColor = Color.Red;
            lbName.ForeColor = Color.Red;
            lbUser.ForeColor = Color.Red;
            lbPass.ForeColor = Color.Red;
            lbEmail.ForeColor = Color.Red;

            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da;
            SqlCommand cm;
            DataTable dt;
            cm = new SqlCommand("SELECT TenTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = '" + username + "'", conn);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;

            cm = new SqlCommand("SELECT MaTT FROM TaiKhoan WHERE MaTT = '" + code + "'", conn);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            int taikhoan = dt.Rows.Count;
            if (string.IsNullOrEmpty(code))
            {
                lbCode.Text = "Vui lòng nhập mã Thủ thư, độc giả!";
                tbxCode.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(username))
            {
                lbUser.Text = "Vui lòng nhập tên đăng nhập!";
                tbxUserame.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lbPass.Text = "Vui lòng nhập mật khẩu!";
                tbxPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                lbEmail.Text = "Vui lòng nhập Email!";
                tbxEmail.Focus();
                return false;
            }
            else if (taikhoan > 0)
            {
                lbCode.Text = "Mã thủ thư đã tồn tại tài khoản!";
                lbCode.Focus();
                return false;
            }
            else if (i > 0)
            {
                lbUser.Text = "Tên đăng nhập đã tồn tại!";
                tbxUserame.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                lbUser.Text = "Tên đăng nhập không thể chứa kí tự đặc biệt!";
                tbxUserame.Focus();
                return false;
            }

            else if (string.IsNullOrWhiteSpace(password))
            {
                lbPass.Text = "Mật khẩu không thể chứa kí tự đặc biệt!";
                tbxPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckValidateUpdate()
        {
            code = tbxCode.Text;
            username = tbxUserame.Text;
            password = tbxPassword.Text;
            ten = tbxName.Text;
            email = tbxEmail.Text;

            usertype = cbxUsertype.Text;
            if (usertype == "Độc giả")
                usertype = "USER";
            else if (usertype == "Thủ thư")
                usertype = "Staff";
            else if (usertype == "Quản trị viên")
                usertype = "Admin";

            lbCode.Text = "";
            lbName.Text = "";
            lbUser.Text = "";
            lbPass.Text = "";
            lbEmail.Text = "";
            lbCode.ForeColor = Color.Red;
            lbName.ForeColor = Color.Red;
            lbUser.ForeColor = Color.Red;
            lbPass.ForeColor = Color.Red;
            lbEmail.ForeColor = Color.Red;

            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da;
            SqlCommand cm;
            DataTable dt;

            cm = new SqlCommand("SELECT TenTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = '" + username + "'", conn);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            int i = dt.Rows.Count;

            cm = new SqlCommand("SELECT MaTT FROM TaiKhoan WHERE MaTT = '" + code + "'", conn);
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            da.Fill(dt);
            int taikhoan = dt.Rows.Count;
            if (string.IsNullOrEmpty(code))
            {
                lbCode.Text = "Vui lòng nhập mã Thủ thư, độc giả!";
                tbxCode.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(username))
            {
                lbUser.Text = "Vui lòng nhập tên đăng nhập!";
                tbxUserame.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lbPass.Text = "Vui lòng nhập mật khẩu!";
                tbxPassword.Focus();
                return false;
            }
            else if (taikhoan > 0 && code != grv.SelectedRows[0].Cells[3].Value.ToString())
            {
                lbCode.Text = "Mã thủ thư, độc giả đã tồn tại tài khoản!";
                lbCode.Focus();
                return false;
            }
            else if (i > 0 && username != grv.SelectedRows[0].Cells[1].Value.ToString())
            {
                lbUser.Text = "Tên đăng nhập đã tồn tại!";
                tbxUserame.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                lbUser.Text = "Tên đăng nhập không thể chứa kí tự đặc biệt!";
                tbxUserame.Focus();
                return false;
            }

            else if (string.IsNullOrWhiteSpace(password))
            {
                lbPass.Text = "Mật khẩu không thể chứa kí tự đặc biệt!";
                tbxPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Success(string value)
        {
            lbReasult.ForeColor = Color.Green;
            MessageBox.Show(value + " Thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxUserame.Text = "";
            tbxUserame.Text = "";
            cbxUsertype.SelectedItem = "Độc giả";
        }
        private void Admin_Load(object sender, EventArgs e)
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
            cbxUsertype.SelectedItem = "Độc giả";
            Getlist();
        }
        private void Getlist()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT Id,TenTaiKhoan, MatKhau, MaTT, TenNguoiDung, Email, PhanQuyen FROM TaiKhoan WHERE TaiKhoan.MaTT != '" + getid + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
                grv.DataSource = dt;
            grv.Columns[0].HeaderText = "ID";
            grv.Columns[1].HeaderText = "Tên tài khoản";
            grv.Columns[2].HeaderText = "Mật khẩu";
            grv.Columns[3].HeaderText = "Mã người dùng";
            grv.Columns[4].HeaderText = "Tên người dùng";
            grv.Columns[5].HeaderText = "Email";
            grv.Columns[6].HeaderText = "Phân quyền";
        }

        private void grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grv.Rows.Count > 0)
            {
                modelTaiKhoan.MaTT = grv.SelectedRows[0].Cells[3].Value.ToString();

                tbxUserame.Text = grv.SelectedRows[0].Cells[1].Value.ToString();
                tbxPassword.Text = grv.SelectedRows[0].Cells[2].Value.ToString();
                tbxCode.Text = grv.SelectedRows[0].Cells[3].Value.ToString();
                tbxName.Text = grv.SelectedRows[0].Cells[4].Value.ToString();
                tbxEmail.Text = grv.SelectedRows[0].Cells[5].Value.ToString();
                if (grv.SelectedRows[0].Cells[6].Value.ToString().ToUpper() == "ADMIN")
                    cbxUsertype.SelectedItem = "Quản trị viên";
                else if (grv.SelectedRows[0].Cells[6].Value.ToString().ToUpper() == "STAFF")
                    cbxUsertype.SelectedItem = "Thủ thư";
                else
                    cbxUsertype.SelectedItem = "Độc giả"; 
                tbxCode.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxCode.Enabled = true;
            tbxCode.Text = "";
            tbxUserame.Text = "";
            tbxPassword.Text = "";
            tbxName.Text = "";
            tbxEmail.Text = "";

            lbReasult.Text = "";
            lbCode.Text = "";
            lbEmail.Text = "";
            lbName.Text = "";
            lbPass.Text = "";
            lbUser.Text = "";
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewThuThu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void tbxCode_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT HovaTen, Email FROM " +
                "ThuThu WHERE MaTT = @matt", con);
            cmd.Parameters.AddWithValue("@matt", tbxCode.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                string name = da.GetValue(0).ToString();
                string email = da.GetValue(1).ToString();

                if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email))
                {
                    tbxEmail.Enabled = true;
                    tbxName.Enabled = false;
                    tbxName.Text = name;
                }
                else if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email))
                {
                    tbxEmail.Enabled = false;
                    tbxName.Enabled = true;
                    tbxEmail.Text = email;
                }
                else
                {
                    tbxEmail.Enabled = false;
                    tbxName.Enabled = false;
                    tbxEmail.Text = email;
                    tbxName.Text = name;
                }

            }
            else
            {
                tbxEmail.Enabled = true;
                tbxName.Enabled = true;
                tbxEmail.Text = "";
                tbxName.Text = "";
            }
            con.Close();
        }
        public void OpennewAdminThuThu()
        {
            Application.Run(new AdminThuThu(getid));
        }
        public void OpennewFormMain()
        {
            Application.Run(new FormMain());
        }
        void OpennewThuThu()
        {
            Application.Run(new Test(getid));
        }
    }
}
