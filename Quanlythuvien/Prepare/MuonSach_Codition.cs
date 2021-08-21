using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien.Prepare
{
    public partial class MuonSach_Codition : Form
    {
        public MuonSach_Codition()
        {
            InitializeComponent();
        }

        private void MuonSach_Codition_Load(object sender, EventArgs e)
        {
            muonSach.Fill(this.libraryDataSet1.GetMuonSach, "1900/01/01");
            this.reportViewer1.RefreshReport();
        }
        string DateChange(string ngaythang)
        {
            string[] tmp = ngaythang.Split('/');
            return tmp[2] + '/' + tmp[1] + '/' + tmp[0];
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            muonSach.Fill(this.libraryDataSet1.GetMuonSach, DateChange(dateTimePicker1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.AddDays(-7).ToString("yyyy/MM/dd");
            muonSach.Fill(this.libraryDataSet1.GetMuonSach, date);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.AddDays(-30).ToString("yyyy/MM/dd");
            muonSach.Fill(this.libraryDataSet1.GetMuonSach, date);
            this.reportViewer1.RefreshReport();
        }
    }
}
