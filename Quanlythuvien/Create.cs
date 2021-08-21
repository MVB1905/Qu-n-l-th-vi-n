using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlythuvien.Controllers;
using Quanlythuvien.Models;


namespace Quanlythuvien
{
    public partial class Create : Form
    {
        string name;
        string username;
        string password;
        string email;
        string connection = Properties.Settings.Default.connection;
        Controllers.TaiKhoan taikhoan = new Controllers.TaiKhoan();
        Models.TaiKhoan mtaikhoan = new Models.TaiKhoan();
        Thread th;
        public Create()
        {
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            name = tbxName.Text.ToUpper();
            username = tbxUsername.Text.ToUpper();
            password = tbxPassword.Text.ToUpper();
            email = tbxEmail.Text.ToUpper();
            lbResult.ForeColor = Color.Red;

            // Gán thông tin vào Models
            mtaikhoan.MaTT = tbxCode.Text;
            mtaikhoan.TenNguoiDung = tbxName.Text;
            mtaikhoan.TenTaiKhoan = tbxUsername.Text;
            mtaikhoan.MatKhau = tbxPassword.Text;
            mtaikhoan.Email = tbxEmail.Text;
            mtaikhoan.PhanQuyen = "User";
            if (string.IsNullOrEmpty(username))
            {
                lbResult.Text = "Vui lòng nhập tên đăng nhập!";
                tbxUsername.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                lbResult.Text = "Tên đăng nhập không thể chứa kí tự đặc biệt!";
                tbxUsername.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                lbResult.Text = "Vui lòng nhập mật khẩu!";
                tbxPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                lbResult.Text = "Mật khẩu không thể chứa kí tự đặc biệt!";
                tbxPassword.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                lbResult.Text = "Vui lòng nhập Email!";
                tbxEmail.Focus();
                return false;
            }
            else if (tbxPassword.Text != tbxCFPassword.Text)
            {
                lbResult.Text = "Mật khẩu không khớp, Vui lòng kiểm tra lại!";
                tbxPassword.Focus();
                return false;
            }
            else if (!IsValidEmail(email))
            {
                lbResult.Text = "Đây không phải là Email, Vui lòng kiểm tra lại!";
                tbxEmail.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string ToUpperString(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            string result = "";
            //lấy danh sách các từ  
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }

            }
            return result.Trim();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connection);

            if (CheckValidate())
            {
                cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE MaTT ='" + tbxCode.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int tk = ds.Tables[0].Rows.Count;
                cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTaiKhoan ='" + tbxUsername.Text + "'", conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE Email ='" + tbxEmail.Text + "'", conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int j = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Tên đăng nhập đã tồn tại!";
                    tbxUsername.Focus();
                }
                else if (j > 0)
                {
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Email đã tồn tại!";
                    tbxEmail.Focus();
                }
                else if (tk > 0)
                {
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "Mã SV, Thủ Thư này đã tồn tại tài khoản!";
                    tbxEmail.Focus();
                }
                else
                {
                    taikhoan.Insert(mtaikhoan);
                    lbResult.ForeColor = Color.Green;
                    lbResult.Text = "Chúc mừng bạn đã đăng ký tài khoản thành công!";
                }
            }
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            btnUnseen.BringToFront();
            tbxPassword.PasswordChar = '\0';
            tbxCFPassword.PasswordChar = '\0';
        }

        private void btnUnseen_Click(object sender, EventArgs e)
        {
            btnSeen.BringToFront();
            tbxPassword.PasswordChar = '*';
            tbxCFPassword.PasswordChar = '*';
        }
    }
}
