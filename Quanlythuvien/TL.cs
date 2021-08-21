using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class TL : Form
    {
        string getid;
        string getidtl;
        public TL(string id, string idtl)
        {
            InitializeComponent();
            getid = id;
            getidtl = idtl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalsVariable.theLoai = "";
            List<string> tmp = new List<string>();
            if (cbxGT.Checked)
                tmp.Add("Giáo trình bài giảng");
            if (cbxLS.Checked)
                tmp.Add("Kỹ thuật lâm sinh");
            if (cbxIT.Checked)
                tmp.Add("Công nghệ thông tin");
            if (cbxLN.Checked)
                tmp.Add("Quy hoạch lâm nghiệp");
            if (cbxMT.Checked)
                tmp.Add("QL tài nguyên rừng và môi trường");
            if (cbxTK.Checked)
                tmp.Add("Luận văn, Nghiên cứu khoa học");
            string[] theLoai = tmp.ToArray();
            for (int i = 0; i < tmp.Count; i++)
            {
                if (i == 0)
                    GlobalsVariable.theLoai += theLoai[i];
                else
                    GlobalsVariable.theLoai += ", " + theLoai[i];
            }
            DialogResult dialogResult = MessageBox.Show("Chắc chắn chọn thể loại này?", "Xác nhận!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TL_Load(object sender, EventArgs e)
        {
            GlobalsVariable.matl = getidtl;

        }
    }
}
