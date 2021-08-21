using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Quanlythuvien
{
    public partial class Login : Form
    {
        Thread th;
        string connection = Properties.Settings.Default.connection;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSeen_Click(object sender, EventArgs e)
        {
            btnUnseen.BringToFront();
            tbxPassword.PasswordChar = '\0';
        }

        private void btnUnseen_Click(object sender, EventArgs e)
        {
            btnSeen.BringToFront();
            tbxPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbxStudentcode.Text.ToUpper();
            string password = tbxPassword.Text.ToUpper();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            if (string.IsNullOrEmpty(username))
            {
                lbNotice.Text = "Vui lòng nhập mã sinh viên!";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT TenTaiKhoan, MatKhau, PhanQuyen, MaTT FROM " +
                    "TaiKhoan WHERE TenTaiKhoan = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader da = cmd.ExecuteReader();

                if (da.Read())
                {
                    if (password != da.GetValue(1).ToString().ToUpper())
                    {
                        lbNotice.Text = "Mật khẩu không chính xác!";
                    }
                    else if (username == da.GetValue(0).ToString().ToUpper() &&
                        password == da.GetValue(1).ToString().ToUpper())
                    {
                        if (da.GetValue(2).ToString().ToUpper() == "STAFF")
                        {
                            string id = da.GetValue(3).ToString();
                            Test f = new Test(id);
                            this.Hide();
                            f.Show();
                        }
                        else if (da.GetValue(2).ToString().ToUpper() == "ADMIN")
                        {
                            string id = da.GetValue(3).ToString();
                            Admin f = new Admin(id);
                            this.Hide();
                            f.Show();
                        }
                        else if (da.GetValue(2).ToString().ToUpper() == "USER")
                        {
                            string id = da.GetValue(3).ToString();
                            User f = new User(id);
                            this.Hide();
                            f.Show();
                        }


                    }
                    conn.Close();
                }
                else if (!da.Read())
                {
                    lbNotice.Text = "Tên đăng nhập không chính xác!";
                }
            }
        }

        private void lbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewForgot);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpennewForgot()
        {
            Application.Run(new Forgot());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain f = new FormMain();
            this.Hide();
            f.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
