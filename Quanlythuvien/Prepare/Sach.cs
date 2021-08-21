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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.GetSach' table. You can move, or remove it, as needed.
            this.sach1.Fill(this.libraryDataSet1.GetSach);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetSach' table. You can move, or remove it, as needed.
            this.sach1.Fill(this.libraryDataSet1.GetSach);

            this.reportViewer1.RefreshReport();
        }
    }
}
