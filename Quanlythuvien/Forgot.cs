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
using System.Net.Mail;
using System.Data.SqlClient;

namespace Quanlythuvien
{
    public partial class Forgot : Form
    {
        Thread th;
        string connection = Properties.Settings.Default.connection;
        string email_to;
        string madinhdanh;
        string randomPass;
        public Forgot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNotice.Text = "Vui lòng đợi...";
            lbNotice.ForeColor = Color.Red;
            lbNotice.Text = "";
            email_to = tbxEmail.Text;
            if (IsValidEmail(tbxEmail.Text))
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaTT FROM TaiKhoan WHERE" +
                    " Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email_to);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    madinhdanh = dr.GetValue(0).ToString();
                }
                conn.Close();
                if (!string.IsNullOrEmpty(madinhdanh))
                {
                    Random rd = new Random();
                    randomPass = rd.Next(1000000, 9999999).ToString();
                    string content = "Mật mã của bạn là: " + randomPass;
                    SendMail(email_to, content);
                    this.Close();
                    th = new Thread(OpennewRedirect);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                    lbNotice.Text = "Email không tồn tại tài khoản, vui lòng thử lại!";
            }
            else
                lbNotice.Text = "Đây không phải là Email, vui lòng thử lại!";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewformLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpennewformLogin()
        {
            Application.Run(new Login());
        }
        void OpennewRedirect()
        {
            Application.Run(new Redirect(madinhdanh, randomPass));
        }
        public void SendMail(string mail_to, string content)
        {
            string mail_fr = "threewolves082000@gmail.com";
            string mail_pw = "Maimai99";
            string subject = "Gửi từ thư viện trường đại học lâm nghiệp việt nam!";
            SmtpClient emailSender = new SmtpClient();
            MailMessage msg = new MailMessage(mail_fr, mail_to, subject, content);
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            emailSender.Host = "smtp.gmail.com";
            emailSender.Port = 587;
            emailSender.UseDefaultCredentials = false;
            // bật chức năng cho các ứng dụng kém an toàn
            emailSender.Credentials = new System.Net.NetworkCredential(mail_fr, mail_pw);
            emailSender.EnableSsl = true;
            emailSender.Send(msg);
            lbNotice.ForeColor = Color.Green;
            lbNotice.Text = "Mật khẩu đã được gửi vào Email!";
            tbxEmail.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewFormMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void OpennewFormMain()
        {
            Application.Run(new FormMain());
        }
        bool IsValidEmail(string email)
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
    }
}
