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
    public partial class TheLoaiSach : Form
    {
        public TheLoaiSach()
        {
            InitializeComponent();
        }

        private void TheLoaiSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.GetQLTNR' table. You can move, or remove it, as needed.
            this.qLTNR.Fill(this.libraryDataSet1.GetQLTNR);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetLVNCKH' table. You can move, or remove it, as needed.
            this.lVNCKH.Fill(this.libraryDataSet1.GetLVNCKH);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetQHLN' table. You can move, or remove it, as needed.
            this.qHLN.Fill(this.libraryDataSet1.GetQHLN);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetKTLS' table. You can move, or remove it, as needed.
            this.kTLS.Fill(this.libraryDataSet1.GetKTLS);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetCNTT' table. You can move, or remove it, as needed.
            this.cNTT.Fill(this.libraryDataSet1.GetCNTT);
            // TODO: This line of code loads data into the 'libraryDataSet1.GetGTBG' table. You can move, or remove it, as needed.
            this.gTBG.Fill(this.libraryDataSet1.GetGTBG);

            this.reportViewer1.RefreshReport();
        }
    }
}
