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

namespace Quanlythuvien
{
    public partial class RemainLoanFile : Form
    {
        string connection = Properties.Settings.Default.connection;
        Thread th;
        string getcode;
        public RemainLoanFile(string code)
        {
            InitializeComponent();
            getcode = code;
        }

        private void RemainLoanFile_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("SELECT DocGia.HovaTen , DocGia.DonVi, Sach.MaS, Sach.TenSach, PhieuMuon.NgayMuon, " +
                "ChiTietPhieuMuon.HanTra  FROM DocGia, Sach, PhieuMuon, ChiTietPhieuMuon where(DocGia.MaDG = PhieuMuon.MaDG) and(Sach.MaS = ChiTietPhieuMuon.MaS) " +
                "and(ChiTietPhieuMuon.MaPM = PhieuMuon.MaPM) and (DocGia.MaDG = @search)", conn);
            da.SelectCommand.Parameters.AddWithValue("@search", getcode);
            DataTable tb = new DataTable();

            da.Fill(tb);
            if (tb != null)
            {
                dgvDanhSachConMuon.DataSource = tb;
                dgvDanhSachConMuon.Columns[0].HeaderText = "Họ và tên";
                dgvDanhSachConMuon.Columns[1].HeaderText = "Đơn vị";
                dgvDanhSachConMuon.Columns[2].HeaderText = "Mã sách";
                dgvDanhSachConMuon.Columns[3].HeaderText = "Tên Sách";
                dgvDanhSachConMuon.Columns[4].HeaderText = "Ngày Mượn";
                dgvDanhSachConMuon.Columns[5].HeaderText = "Hạn Trả";

                dgvDanhSachConMuon.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDanhSachConMuon.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("Bug");
            }
        }
        public void OpennewFormMain()
        {
            Application.Run(new FormMain());
        }

    }
}
