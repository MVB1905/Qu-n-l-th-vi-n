using System;
using System.Threading;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class Redirect : Form
    {
        double seconds = 300;
        Thread th;
        string getid;
        string getPass;
/*        TimeSpan t = TimeSpan.FromSeconds(seconds);

        string answer = string.Format("{1:D2}m:{2:D2}s",
                        t.Minutes,
                        t.Seconds);*/
        public Redirect(string id, string pass)
        {
            InitializeComponent();
            getid = id;
            getPass = pass;
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text != getPass)
            {
                lbNotice.Text = "Mật mã không chính xác, vui lòng kiểm tra lại!";
            }
            else
            {
                this.Close();
                th = new Thread(OpennewformChange);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }
        void OpennewformChange()
        {
            Application.Run(new AfterForgot(getid));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                getPass = "";
                timer1.Stop();
                lbtime.Text = "để xác nhận. Mật mã gồm 7 số! (Mã này đã hết hiệu lực)";
            }
            else
            {
                int getMin = (int)seconds / 60;
                int getSeconds = (int)seconds % 60;
                if (getSeconds >= 10)
                    lbtime.Text = "để xác nhận. Mật mã gồm 7 số! (Mã có hiệu lực trong 0" + getMin + ":" + getSeconds + "s)";
                else if (getSeconds <= 10)
                    lbtime.Text = "để xác nhận. Mật mã gồm 7 số! (Mã có hiệu lực trong 0" + getMin + ":0" + getSeconds + "s)";
            }
        }

        private void Redirect_Load(object sender, EventArgs e)
        {
            int getMin = (int)seconds / 60;
            int getSeconds = (int)seconds % 60;
            if (getSeconds >= 10)
                lbtime.Text = "để xác nhận. Mật mã gồm 7 số! (Mã có hiệu lực trong 0" + getMin + ":" + getSeconds + "s)";
            else if (getSeconds <= 10)
                lbtime.Text = "để xác nhận. Mật mã gồm 7 số! (Mã có hiệu lực trong 0" + getMin + ":0" + getSeconds + "s)";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void OpennewMain()
        {
            Application.Run(new FormMain());
        }
        void OpennewLogin()
        {
            Application.Run(new Login());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        // Gửi mã random đến email  - Print: Mã đã được gửi đến email - random after 5min
        // Gửi id và mã sang form nhập mã - Mã true chuyển hướng sang trang đổi mật khẩu - Mã False, Print: Mật mã không chính xác
        // 
    }
}
