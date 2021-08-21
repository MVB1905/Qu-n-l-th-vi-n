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
using System.IO;

namespace Quanlythuvien
{
    public partial class Test : Form
    {
        Thread th;
        string connection = Properties.Settings.Default.connection;

        //
        Controllers.Sach ctrlSach = new Controllers.Sach();
        Controllers.DocGia ctrlDocGia = new Controllers.DocGia();
        Controllers.Phat ctrlPhat = new Controllers.Phat();
        Controllers.MuonSach ctrlMuonSach = new Controllers.MuonSach();
        Controllers.TraSach ctrlTraSach = new Controllers.TraSach();
        Controllers.ChiTietPhieuMuon ctrChiTietPhieuMuon = new Controllers.ChiTietPhieuMuon();
        Controllers.TaiKhoan ctrlTaiKhoan = new Controllers.TaiKhoan();
        Controllers.ThuThu ctrlThuThu = new Controllers.ThuThu();

        //
        Models.Sach modelSach = new Models.Sach();
        Models.DocGia modelDocgia = new Models.DocGia();
        Models.Phat modelPhat = new Models.Phat();
        Models.MuonSach modelMuonSach = new Models.MuonSach();
        Models.TraSach modelsTraSach = new Models.TraSach();
        Models.ChiTietPhieuMuon modelsChiTietPhieuMuon = new Models.ChiTietPhieuMuon();
        Models.TaiKhoan modelTaiKhoan = new Models.TaiKhoan();
        Models.ThuThu modelThuThu = new Models.ThuThu();


        //
        string getid;


        public Test(string id)
        {
            getid = id;
            InitializeComponent();
        }

        public string TheLoaiTL
        {
            get
            {
                return this.tbxTheLoaiTL.Text;
            }
            set
            {
                this.tbxTheLoaiTL.Text = value;
            }
        }

        void GetlistDG()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaDG, HovaTen, DonVi FROM DocGia", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                grvDG.DataSource = dt;
                grvDG.Columns[0].HeaderText = "Mã độc giả";
                grvDG.Columns[1].HeaderText = "Tên độc giả";
                grvDG.Columns[2].HeaderText = "Đơn vị";

            }
        }
        void GetlistMT()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaPM, MaDG, MaTT, Convert(Nvarchar, NgayMuon, 103) FROM PhieuMuon", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                grvM.DataSource = dt;
                grvM.Columns[0].HeaderText = "Mã phiếu mượn";
                grvM.Columns[1].HeaderText = "Mã độc giả";
                grvM.Columns[2].HeaderText = "Mã thủ thư";
                grvM.Columns[3].HeaderText = "Ngày mượn";
            }

        }
        void GetlistTL()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, NamXB, GiaTien, SoLuong, FileName FROM Sach ", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                grvTL.DataSource = dt;
                grvTL.Columns[0].HeaderText = "Mã sách";
                grvTL.Columns[1].HeaderText = "Tên sách";
                grvTL.Columns[2].HeaderText = "Nhà xuất bản";
                grvTL.Columns[3].HeaderText = "Thể loại";
                grvTL.Columns[4].HeaderText = "Tác giả";
                grvTL.Columns[5].HeaderText = "Năm xuất bản";
                grvTL.Columns[6].HeaderText = "Giá tiền (VNĐ)";
                grvTL.Columns[7].HeaderText = "Số lượng";
                grvTL.Columns[8].HeaderText = "File tài liệu";
            }
        }
        void GetlistP()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaPhat, Phat.MaDG, DocGia.HovaTen, Phat.MaS, Sach.TenSach, Phat.SoTien, CONVERT(NVARCHAR, Phat.NgayXuPhat, 103) FROM Phat, DocGia, Sach WHERE Phat.MaDG = DocGia.MaDG AND Phat.MaS = Sach.MaS", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                grvP.DataSource = dt;
                grvP.Columns[0].HeaderText = "Mã phạt";
                grvP.Columns[1].HeaderText = "Tên độc giả";
                grvP.Columns[2].HeaderText = "Tên độc giả";
                grvP.Columns[3].HeaderText = "Mã sách";
                grvP.Columns[4].HeaderText = "Tên sách";
                grvP.Columns[5].HeaderText = "Số tiền";
                grvP.Columns[6].HeaderText = "Ngày xử phạt";
            }
        }
        void GetlistM()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("SELECT MaPM, PhieuMuon.MaDG, DocGia.HovaTen, PhieuMuon.MaTT,ThuThu.HovaTen, Convert(Nvarchar, NgayMuon, 103) FROM PhieuMuon, DocGia, ThuThu WHERE PhieuMuon.MaDG = DocGia.MaDG and PhieuMuon.MaTT = ThuThu.MaTT", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
            {
                grvM.DataSource = dt;
                grvM.Columns[0].HeaderText = "Mã phiếu mượn";
                grvM.Columns[1].HeaderText = "Mã độc giả";
                grvM.Columns[2].HeaderText = "Tên độc giả";
                grvM.Columns[3].HeaderText = "Mã thủ thư";
                grvM.Columns[4].HeaderText = "Tên thủ thư";
                grvM.Columns[5].HeaderText = "Ngày lập phiếu";
            }
        }
/*        void GetlistT()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand("  SELECT ChiTietPhieuMuon.MaS, Sach.TenSach, CONVERT(Nvarchar, PhieuMuon.NgayMuon, 103) , CONVERT(Nvarchar, ChiTietPhieuMuon.HanTra, 103), ChiTietPhieuMuon.TrangThai " +
                "FROM ChiTietPhieuMuon, PhieuMuon, Sach WHERE ChiTietPhieuMuon.MaPM = PhieuMuon.MaPM AND ChiTietPhieuMuon.MaS = Sach.MaS and ChiTietPhieuMuon.TrangThai = N'Đã trả'", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt != null)
                grvT.DataSource = dt;
            grvT.Columns[0].HeaderText = "Mã sách";
            grvT.Columns[1].HeaderText = "Tên sách";
            grvT.Columns[2].HeaderText = "Ngày mượn";
            grvT.Columns[3].HeaderText = "Ngày trả";
            grvT.Columns[4].HeaderText = "Trạng thái";
        }*/
        bool checkvalidateTL()
        {
            string id = tbxMaTL.Text;

            lbNamXBTL.Text = "";
            lbSoLuongTL.Text = "";

            modelSach.MaS = id;
            modelSach.TenSach = tbxTenTL.Text;
            modelSach.MaNXB = tbxMaNXBTL.Text;
            modelSach.TheLoai = tbxTheLoaiTL.Text;

            modelSach.NamXB = tbxNamXBTL.Text;
            modelSach.Giatien = tbxGiaTienTL.Text;
            modelSach.TacGia = tbxTacGiaTL.Text;
            modelSach.SoLuong = tbxSLTL.Text;
            if (!int.TryParse(modelSach.NamXB, out int number))
            {
                lbNamXBTL.ForeColor = Color.Red;
                lbNamXBTL.Text = "Năm xuất bản phải là số!";
                return false;
            }
            if (!int.TryParse(modelSach.Giatien, out number))
            {
                lbSoLuongTL.ForeColor = Color.Red;
                lbSoLuongTL.Text = "Giá tiền phải là số!";
                return false;
            }
            else if (string.IsNullOrEmpty(modelSach.FileName))
            {
                modelSach.FileName = "Chưa có tài liệu";
                modelSach.File = Encoding.UTF8.GetBytes("Chưa cập nhật tài liệu trực tuyến!");
                return false;
            }
            else if (string.IsNullOrEmpty(modelSach.Giatien) || int.Parse(modelSach.Giatien) < 1)
            {
                lbSoLuongTL.ForeColor = Color.Red;
                lbSoLuongTL.Text = "Số lượng tài liệu nhập phải lớn hơn 0!";
                return false;
            }
            else
            {
                return true;
            }
        }
        bool CheckUpdateTL()
        {
            lbNamXBTL.Text = "";
            lbSoLuongTL.Text = "";

            modelSach.MaS = tbxMaTL.Text;
            modelSach.TenSach = tbxTenTL.Text;
            modelSach.MaNXB = tbxMaNXBTL.Text;
            modelSach.TheLoai = tbxTheLoaiTL.Text;
            modelSach.NamXB = tbxNamXBTL.Text;
            modelSach.Giatien = tbxGiaTienTL.Text;
            modelSach.TacGia = tbxTacGiaTL.Text;
            modelSach.SoLuong = tbxSLTL.Text;
            if (!int.TryParse(modelSach.NamXB, out int number))
            {
                lbNamXBTL.ForeColor = Color.Red;
                lbNamXBTL.Text = "Năm xuất bản phải là số!";
                return false;
            }
            if (!int.TryParse(modelSach.Giatien, out number))
            {
                lbSoLuongTL.ForeColor = Color.Red;
                lbSoLuongTL.Text = "Giá tiền phải là số!";
                return false;
            }
            else if (string.IsNullOrEmpty(modelSach.FileName))
            {
                modelSach.FileName = "Chưa có tài liệu";
                modelSach.File = Encoding.UTF8.GetBytes("Chưa cập nhật tài liệu trực tuyến!");
                return false;
            }
            else if (string.IsNullOrEmpty(modelSach.Giatien) || int.Parse(modelSach.Giatien) < 1)
            {
                lbSoLuongTL.ForeColor = Color.Red;
                lbSoLuongTL.Text = "Số lượng tài liệu nhập phải lớn hơn 0!";
                return false;
            }
            else
            {
                return true;
            }
        }
        bool checkvalidateDG()
        {
            modelDocgia.MaDG = tbxMaDG.Text;
            modelDocgia.HovaTen = tbxTenDG.Text;
            modelDocgia.DonVi = tbxDonViDG.Text;

            if (string.IsNullOrEmpty(modelDocgia.MaDG))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả! <Mã sinh viên/giảng viên>");
                return false;
            }
            else
            {
                return true;
            }
        }
        bool checkvalidateMS()
        {
            modelMuonSach.MaDG = tbxMaDGMuonTra.Text;
            modelMuonSach.MaTT = tbxMaTTM.Text;
            modelMuonSach.NgayMuon = DateChange(tbxNgayMuonM.Text);

            if (string.IsNullOrEmpty(modelMuonSach.MaDG))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả! <Mã sinh viên/giảng viên>");
                return false;
            }
/*            else if (!TenDG(tbxMaDGMuonTra, tbxTenDGM))
            {
                MessageBox.Show("Độc giả chưa có trong hệ thống vui lòng khởi tạo!");
                return false;
            }*/
            else
            {
                return true;
            }
        }
/*        bool checkvalidateTS()
        {
            modelsTraSach.MaDG = tbxMaDGT.Text;
            modelsTraSach.MaS = tbxMaTLT.Text;
            modelsTraSach.NgayTra = DateChange(tbxNgayMuonM.Text);

            if (string.IsNullOrEmpty(modelsTraSach.MaDG))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả! <Mã sinh viên/giảng viên>");
                return false;
            }
            else
            {
                return true;
            }
        }*/

        bool TenDG(TextBox txtid, TextBox txtname)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT HovaTen FROM " +
                "DocGia WHERE MaDG = @madg", con);
            cmd.Parameters.AddWithValue("@madg", txtid.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                txtname.Enabled = false;
                txtname.Text = da.GetValue(0).ToString();
                return true;
            }
            else
            {
                txtname.Enabled = true;
                txtname.Text = "";
                return false;
            }
            con.Close();
        }
        void Refesh()
        {
            // độc giả
            tbxMaDG.Enabled = true;
            tbxMaDG.Text = "";
            tbxTenDG.Text = "";
            tbxDonViDG.Text = "";

            // Tài liệu
            tbxTenTL.Text = "";
            tbxMaNXBTL.Text = "";
            tbxTheLoaiTL.Text = "";
            tbxNamXBTL.Text = "";
            tbxTacGiaTL.Text = "";
            tbxFileTL.Text = "";
            tbxGiaTienTL.Text = "";
            tbxSLTL.Text = "";

            // Mượn
            tbxMaDGMuonTra.Enabled = true;
            tbxMaDGMuonTra.Text = "";
            tbxTenDGM.Text = "";

            // Trả
/*            tbxMaTLT.Enabled = true;
            tbxMaTLT.Text = "";
            tbxTenTLT.Text = "";
            tbxTenDGT.Text = "";
            tbxMaDGT.Text = "";*/

            // Phạt
            tbxMaDGP.Text = "";
            tbxTenDGP.Text = "";
        }
        string DateChange(string ngaythang)
        {
            string[] tmp = ngaythang.Split('/');
            return tmp[2] + '/' + tmp[1] + '/' + tmp[0];
        }
        void OpennewFormMain()
        {
            Application.Run(new FormMain());
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select Max(Id) From Sach", conn);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                tbxMaTL.Text = da.GetValue(0).ToString();
            }
            tbxMaTL.Enabled = false;
            conn.Close();
            GetlistDG();
            GetlistTL();
            GetlistP();
            GetlistM();
            //GetlistT();
        }

        private void btnChonTL_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdg = new OpenFileDialog();
            fdg.Filter = "PDF Files (PDF, pdf)|*.PDF;*.pdf;";
            if (fdg.ShowDialog() == DialogResult.OK)
            {

                string path = fdg.FileName;
                using (Stream stream = File.OpenRead(path))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);

                    string filename = new FileInfo(path).Name;
                    tbxFileTL.Text = filename;
                    modelSach.File = buffer;
                    modelSach.FileName = filename;
                }
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            if (checkvalidateTL())
            {
                SqlConnection con = new SqlConnection(connection);
                string query = "INSERT INTO Sach(MaS, TenSach, TacGia, NhaXB, TheLoai, NamXB, GiaTien, [File], FileName, SoLuong)" +
                                "VALUES(N'" + modelSach.MaS + "',N'" + modelSach.TenSach + "', N'" + modelSach.TacGia +
                                "', N'" + modelSach.MaNXB + "', N'" + modelSach.TheLoai + "', '" + modelSach.NamXB + "'," +
                                "N'" + modelSach.Giatien + "', @file, @filename," +
                                "N'" + modelSach.SoLuong + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@file", SqlDbType.VarBinary).Value = modelSach.File;
                cmd.Parameters.Add("@filename", SqlDbType.NVarChar).Value = modelSach.FileName;
                con.Open();
                try
                {
                   cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Mã tài liệu này đã tồn tại, vui lòng thử lại!");
                }
                con.Close();
                GetlistTL();
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (CheckUpdateTL())
            {
                SqlConnection con = new SqlConnection(connection);
                string query = "UPDATE Sach SET MaS = N'" + modelSach.MaS + "', TenSach = N'" + modelSach.TenSach + "'," +
                    "TacGia = N'" + modelSach.TacGia + "', NhaXB =  N'" + modelSach.MaNXB + "',TheLoai = N'" + modelSach.TheLoai + "'," +
                    "NamXB =  " + modelSach.NamXB + ", GiaTien = N'" + modelSach.Giatien + "', [File] = @file, " +
                    "FileName = N'" + modelSach.FileName + "', SoLuong=" + modelSach.SoLuong +
                    "WHERE MaS = N'" + modelSach.MaS + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@file", SqlDbType.VarBinary).Value = modelSach.File;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetlistTL();
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelSach.MaS))
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa tất cả thông tin liên quan đến sách này!", "Sau khi xóa không thể khôi phục dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ctrlSach.Delete(modelSach);
                    GetlistTL();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select Max(Id) From Sach", conn);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                tbxMaTL.Text = da.GetValue(0).ToString();
            }
            conn.Close();

            tbxMaTL.Enabled = false;
            tbxTenTL.Text = "";
            tbxNamXBTL.Text = "";
            tbxTacGiaTL.Text = "";
            tbxTheLoaiTL.Text = "";
            tbxMaNXBTL.Text = "";
            tbxFileTL.Text = "";
            tbxGiaTienTL.Text = "";
            GlobalsVariable.matl = null;
            GlobalsVariable.theLoai = null;
            tbxMaTL.Text = "";
            Refesh();

        }

        private void grvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaTL.Enabled = false;
            tbxMaTL.Text = grvTL.SelectedRows[0].Cells[0].Value.ToString();
            tbxTenTL.Text = grvTL.SelectedRows[0].Cells[1].Value.ToString();
            tbxMaNXBTL.Text = grvTL.SelectedRows[0].Cells[2].Value.ToString();
            tbxTheLoaiTL.Text = grvTL.SelectedRows[0].Cells[3].Value.ToString();
            tbxTacGiaTL.Text = grvTL.SelectedRows[0].Cells[4].Value.ToString();
            tbxNamXBTL.Text = grvTL.SelectedRows[0].Cells[5].Value.ToString();
            tbxGiaTienTL.Text = grvTL.SelectedRows[0].Cells[6].Value.ToString();
            tbxSLTL.Text = grvTL.SelectedRows[0].Cells[7].Value.ToString();
            tbxFileTL.Text = grvTL.SelectedRows[0].Cells[8].Value.ToString();
            modelSach.MaS = grvTL.SelectedRows[0].Cells[0].Value.ToString();

            // Select file tài liệu
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT [File], FileName FROM Sach WHERE MaS = @id", con);
            cmd.Parameters.Add("@id", modelSach.MaS);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                modelSach.File = (byte[])reader[0];
                modelSach.FileName = reader[1].ToString();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            if (checkvalidateDG())
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cm;
                cm = new SqlCommand("SELECT MaDG FROM DocGia WHERE MaDG = '" + modelDocgia.MaDG + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i < 1 )
                {
                    ctrlDocGia.Insert(modelDocgia);
                    GetlistDG();
                    Refesh();
                }
                else
                {
                    MessageBox.Show("Mã độc giả đã tồn tại vui lòng chọn mã khác!");
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxMaP_TextChanged(object sender, EventArgs e)
        {
            TenDG(tbxMaDGP, tbxTenDGP);
        }

/*        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Sach.TenSach FROM Sach WHERE MaS = N'"+ tbxMaTLT.Text +"'", con);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                tbxTenTLT.Enabled = false;
                tbxTenTLT.Text = da.GetValue(0).ToString();
            }
            else
            {
                tbxTenTLT.Enabled = true;
                tbxTenTLT.Text = "";
            }
            con.Close();
        }*/

/*        private void tbxMaDGT_TextChanged(object sender, EventArgs e)
        {
            TenDG(tbxMaDGT, tbxTenDGT);
        }*/

        private void tabMT_Click(object sender, EventArgs e)
        {
            GetlistDG();
            GetlistTL();
            GetlistP();
            GetlistM();
            //GetlistT();
            string dt = DateTime.Now.ToString("ddMMyyyy");

/*            tbxNgayTraT.Text = dt;
            tbxNgayTraT.Enabled = false;*/
            tbxNgayMuonM.Text = dt;
            tbxNgayMuonM.Enabled = false;
            tbxMaTTM.Text = getid;

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT TenNguoiDung FROM " +
                "TaiKhoan WHERE MaTT = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", getid);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                tbxMaTTM.Enabled = false;
                tbxTenTTM.Enabled = false;
                tbxTenTTM.Text = da.GetValue(0).ToString();
            }

            conn.Close();
        }

        private void tbxMaDGMuonTra_TextChanged(object sender, EventArgs e)
        {
            TenDG(tbxMaDGMuonTra, tbxTenDGM);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(OpennewFormMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (checkvalidateDG())
            {
                ctrlDocGia.Update(modelDocgia);
                GetlistDG();
                Refesh();

            }
        }

        private void grvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaDG.Enabled = false;
            modelDocgia.MaDG = grvDG.SelectedRows[0].Cells[0].Value.ToString();
            tbxMaDG.Text = grvDG.SelectedRows[0].Cells[0].Value.ToString();
            tbxTenDG.Text = grvDG.SelectedRows[0].Cells[1].Value.ToString();
            tbxDonViDG.Text = grvDG.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxMaDG.Text)){
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa tất cả thông tin liên quan đến độc giả này!", "Sau khi xóa không thể khôi phục dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Trạng thái: 
                    /*
                     * Trạng thái: 0 - Đang mượn
                     * Trạng thái: 1 - Đã trả
                     * Trạng thái: 2 - Quá hạn
                     */
                    modelMuonSach.MaDG = modelDocgia.MaDG;
                    modelsTraSach.MaDG = modelDocgia.MaDG;
                    modelsChiTietPhieuMuon.MaDG = modelDocgia.MaDG;
                    modelPhat.MaDG1 = modelDocgia.MaDG;
                    string map = modelDocgia.MaDG;

                    ctrChiTietPhieuMuon.DeleteWithMaDG(modelsChiTietPhieuMuon);
                    ctrlMuonSach.DeleteWithMaDG(modelMuonSach);
                    ctrlPhat.DeleteWithMaDG(map);
                    
                    ctrlDocGia.Delete(modelDocgia);
                    GetlistDG();
                    Refesh();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Refesh();
        }

        private void btnThemMuonTra_Click(object sender, EventArgs e)
        {
            if (checkvalidateMS())
            {
                // SELECT bảng tài khoản với id độc giả đã nhập xem đã tồn tại hay chưa
                // Nếu chưa
                // Kiểm tra xem độc giả đã có trong bảng độc giả chưa 
                //
                string ma = tbxMaDGMuonTra.Text;
                string ten = tbxTenDGM.Text;
                string phanquyen = "USER";
                string matkhau = "a";

                //
                string query = "SELECT * FROM DocGia WHERE MaDG = N'" +tbxMaDGMuonTra.Text + "'";
                if (!IsExist(query))
                {
                    modelDocgia.MaDG = ma;
                    modelDocgia.HovaTen = ten;
                    ctrlDocGia.Insert(modelDocgia);
                    // Create new DG
                    query = "SELECT * FROM TaiKhoan Where MaTT = N'" + tbxMaDGMuonTra.Text + "'";
                    if (!IsExist(query))
                    {
                        // Create new account
                        modelTaiKhoan.TenTaiKhoan = ma;
                        modelTaiKhoan.MaTT = ma;
                        modelTaiKhoan.PhanQuyen = phanquyen;
                        modelTaiKhoan.MatKhau = matkhau;
                        modelTaiKhoan.TenNguoiDung = ten;
                        ctrlTaiKhoan.Insert(modelTaiKhoan);
                    }
                }
                else
                {
                    query = "SELECT * FROM TaiKhoan Where MaTT = N'" + tbxMaDGMuonTra.Text + "'";
                    if (!IsExist(query))
                    {
                        // Create new account
                        modelTaiKhoan.TenTaiKhoan = ma;
                        modelTaiKhoan.MaTT = ma;
                        modelTaiKhoan.PhanQuyen = phanquyen;
                        modelTaiKhoan.MatKhau = matkhau;
                        modelTaiKhoan.TenNguoiDung = ten;
                        ctrlTaiKhoan.Insert(modelTaiKhoan);
                    }
                }
                
                //  - Nếu chưa insert độc giả vào bảng đọc giả
                // Kiểm tra xem mã độc giả đã có trong bảng tài khoản chưa
                // - Nếu chưa thì insert vào bảng tài khoản với mã độc giả này: Username: Mãđộcgiả, Password: a, Usertype: USER, Name: name, Email: null

                ctrlMuonSach.Insert(modelMuonSach);
                GetlistM();
            }
        }

        bool IsExist(string query)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                return true;
            }
            return false;
            conn.Close();
        }




        private void btnXoaMuonTra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(modelMuonSach.MaPM))
            {
                modelsChiTietPhieuMuon.MaPM = modelMuonSach.MaPM;
                ctrChiTietPhieuMuon.Delete(modelsChiTietPhieuMuon);
                
                ctrlMuonSach.Delete(modelMuonSach);
                GetlistM();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phiếu mượn cần xóa!");
            }
        }

        private void grvM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modelMuonSach.MaPM = grvM.SelectedRows[0].Cells[0].Value.ToString();
        }

/*        private void button3_Click(object sender, EventArgs e)
        {
            if (checkvalidateTS())
            {
                ctrlTraSach.Insert(modelsTraSach);
                GetlistT();
            }
        }*/

/*        private void grvT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modelsTraSach.MaDG = grvT.SelectedRows[0].Cells[0].Value.ToString();
            tbxMaDGT.Text = grvT.SelectedRows[0].Cells[0].Value.ToString();
            tbxTenDGT.Text = grvT.SelectedRows[0].Cells[1].Value.ToString();
            tbxMaTLT.Text = grvT.SelectedRows[0].Cells[2].Value.ToString();
            tbxTenTLT.Text = grvT.SelectedRows[0].Cells[3].Value.ToString();
            tbxNgayTraT.Text = grvT.SelectedRows[0].Cells[4].Value.ToString();
        }
*/
        private void btnXoaTS_Click(object sender, EventArgs e)
        {
/*            if (grvT.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa tất cả thông tin liên quan!", "Sau khi xóa không thể khôi phục dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ctrlTraSach.DeleteWithMaDG(modelsTraSach);
                    GetlistT();
                }
            }*/
        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {

        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            modelPhat.MaDG1 = tbxMaDGP.Text;
            modelPhat.MaS = tbxMaSP.Text;
            modelPhat.NgayXuPhat = DateChange(tbxNgayXuPhatP.Text);
            modelPhat.Sotien = tbxGiaTienP.Text;
            ctrlPhat.Insert(modelPhat);
            GetlistP();
            
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (grvP.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa tất cả thông tin liên quan đến thủ thư này!", "Sau khi xóa không thể khôi phục dữ liệu!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ctrlPhat.Delete(grvDG.SelectedRows[0].Cells[0].Value.ToString());
                    GetlistP();
                }
            }
        }

        private void grvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modelPhat.MaPhat = grvP.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnTimKiemTL_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaS, TenSach, NhaXB, TheLoai, TacGia, NamXB, GiaTien, SoLuong, FileName FROM Sach " +
                "where (MaS LIKE @search) or ((TenSach LIKE '%' + @search + '%') or (NhaXB LIKE '%' + @search + '%') or (TheLoai LIKE '%' + @search + '%'))", conn);
            string search = tbxTimKiemTL.Text;
            da.SelectCommand.Parameters.AddWithValue("@search", search);
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb != null)
            {
                grvTL.DataSource = tb;
                grvTL.Columns[0].HeaderText = "Mã sách";
                grvTL.Columns[1].HeaderText = "Tên sách";
                grvTL.Columns[2].HeaderText = "Nhà xuất bản";
                grvTL.Columns[3].HeaderText = "Thể loại";
                grvTL.Columns[4].HeaderText = "Tác giả";
                grvTL.Columns[5].HeaderText = "Năm xuất bản";
                grvTL.Columns[6].HeaderText = "Giá tiền";
                grvTL.Columns[7].HeaderText = "File tài liệu";
            }
            else
            {
                MessageBox.Show("Hiện tại không có bản ghi nào");
            }
        }

        private void tbxTimKiemTL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTimKiemTL.Text))
            {
                GetlistTL();
            }

        }

        private void btnTimKiemDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchDG.Text))
            {

                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbxTimKiemTL.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection(connection);
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaDG, HovaTen, DonVi FROM DocGia " +
                    "where  ((MaDG LIKE @search) or (HovaTen LIKE '%' + @search + '%') or (DonVi LIKE @search))", conn);
                string search = tbxSearchDG.Text;
                da.SelectCommand.Parameters.AddWithValue("@search", search);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    grvDG.DataSource = dt;
                    grvDG.Columns[0].HeaderText = "Mã độc giả";
                    grvDG.Columns[1].HeaderText = "Tên độc giả";
                    grvDG.Columns[2].HeaderText = "Đơn vị";
                }
                else
                {
                    MessageBox.Show("Hiện tại không có bản ghi nào");
                }
            }
        }

        private void tbxSearchDG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchDG.Text))
            {
                GetlistDG();
            }
        }

        private void btnTimKiemMuonTra_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPM, PhieuMuon.MaDG, DocGia.HovaTen, PhieuMuon.MaTT,ThuThu.HovaTen, Convert(Nvarchar, NgayMuon, 103) " +
                "FROM PhieuMuon, DocGia, ThuThu " +
                "WHERE (PhieuMuon.MaDG = DocGia.MaDG AND PhieuMuon.MaTT = ThuThu.MaTT) " +
                "AND ((MaPM LIKE @search) or (PhieuMuon.MaDG LIKE @search) or (PhieuMuon.MaTT LIKE @search))", con);
            da.SelectCommand.Parameters.AddWithValue("@search", tbxTimKiemMT.Text);
            da.Fill(dt);
            if (dt != null)
            {
                grvM.DataSource = dt;
                grvM.Columns[0].HeaderText = "Mã phiếu mượn";
                grvM.Columns[1].HeaderText = "Mã độc giả";
                grvM.Columns[2].HeaderText = "Tên độc giả";
                grvM.Columns[3].HeaderText = "Mã thủ thư";
                grvM.Columns[4].HeaderText = "Tên thủ thư";
                grvM.Columns[5].HeaderText = "Ngày lập phiếu";
            }
        }

        private void tbxTimKiemMT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTimKiemMT.Text))
                GetlistM();
        }

        private void btnTimKiemP_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhat, Phat.MaDG, DocGia.HovaTen, Phat.MaS, Sach.TenSach, Phat.SoTien, CONVERT(NVARCHAR, Phat.NgayXuPhat, 103) " +
                "FROM Phat, DocGia, Sach " +
                "WHERE (Phat.MaDG = DocGia.MaDG AND Phat.MaS = Sach.MaS) " +
                "AND ((MaPhat LIKE @search) OR (Phat.MaDG LIKE @search) OR (Phat.MaS LIKE @search) OR (DocGia.HovaTen LIKE '%' + @search + '%'))", con);
            da.SelectCommand.Parameters.AddWithValue("@search", tbxTimKiemP.Text);
            da.Fill(dt);
            if (dt != null)
            {
                grvP.DataSource = dt;
                grvP.Columns[0].HeaderText = "Mã phạt";
                grvP.Columns[1].HeaderText = "Mã độc giả";
                grvP.Columns[2].HeaderText = "Tên độc giả";
                grvP.Columns[3].HeaderText = "Mã sách";
                grvP.Columns[4].HeaderText = "Tên sách";
                grvP.Columns[5].HeaderText = "Số tiền";
                grvP.Columns[6].HeaderText = "Ngày xử phạt";
            }
        }

        private void tbxTimKiemP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTimKiemP.Text))
                GetlistP();
        }

        private void grvM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mapm = grvM.SelectedRows[0].Cells[0].Value.ToString();
            MuonSach f = new MuonSach(mapm);
            f.Show();
        }

        private void tbxMaSP_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            string query = "SELECT TenSach, GiaTien FROM Sach WHERE MaS = @mas ";
            SqlCommand cmd = new SqlCommand(query, conn);
            string search = tbxMaSP.Text;
            cmd.Parameters.AddWithValue("@mas", search);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                tbxTenSachP.Enabled = false;
                tbxGiaTienP.Enabled = false;
                tbxTenSachP.Text = da.GetValue(0).ToString();
                tbxGiaTienP.Text = da.GetValue(1).ToString();
            }
            else
            {
                tbxTenSachP.Enabled = true;
                tbxGiaTienP.Enabled = true;
                tbxTenSachP.Text = "";
                tbxGiaTienP.Text = "";
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TL tl = new TL(getid, tbxMaTL.Text);
            tl.ShowDialog();
        }

        private void tabTL_Click(object sender, EventArgs e)
        {
            if (tbxMaTL.Text == GlobalsVariable.matl)
            {
                tbxTheLoaiTL.Text = GlobalsVariable.theLoai;
            }
        }

        private void lbOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            th = new Thread(OpennewFormMain);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prepare.Sach td = new Prepare.Sach();
            td.Show();
        }

        private void tbxGiaTienTL_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhật thông tin!", "Xác nhận cập nhật!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Get value from DB
                modelThuThu.MaTT = changeCode.Text;
                modelThuThu.HovaTen = changeName.Text;
                modelThuThu.GioiTinh = changeSex.Text;
                modelThuThu.NgaySinh = DateChange(changeBirthdate.Text);
                modelThuThu.DiaChi = changeAddress.Text;
                modelThuThu.Email = ChangeEmail.Text;

                // Get value From DB
                modelTaiKhoan.Email = ChangeEmail.Text;
                modelTaiKhoan.TenNguoiDung = changeName.Text;

                //
                ctrlThuThu.Update(modelThuThu);
                ctrlTaiKhoan.Update(modelTaiKhoan);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // get value from db
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaTT, TenTaiKhoan, MatKhau, PhanQuyen, Email, TenNguoiDung" +
                " FROM TaiKhoan WHERE MaTT = N'" + getid + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                string matt = da.GetValue(0).ToString();
                string tentaikhoan = da.GetValue(1).ToString();
                string matkhau = da.GetValue(2).ToString();
                string phanquyen = da.GetValue(3).ToString();
                string email = da.GetValue(4).ToString();
                string tennguoidung = da.GetValue(5).ToString();

                //
                changeCode.Enabled = false;
                modelTaiKhoan.MaTT = matt;
                modelTaiKhoan.TenTaiKhoan = tentaikhoan;
                modelTaiKhoan.MatKhau = matkhau;
                modelTaiKhoan.PhanQuyen = phanquyen;
                modelTaiKhoan.Email = email;
                modelTaiKhoan.TenNguoiDung = tennguoidung;
                ChangeEmail.Text = email;


            }
            con.Close();
            con.Open();
            cmd = new SqlCommand("SELECT MaTT, HovaTen, GioiTinh, CONVERT(Nvarchar, NgaySinh, 103), DiaChi, Email" +
                " FROM ThuThu WHERE MaTT = N'" + getid + "'", con);
            da = cmd.ExecuteReader();
            if (da.Read())
            {
                string matt = da.GetValue(0).ToString();
                string hovaten = da.GetValue(1).ToString();
                string gioitinh = da.GetValue(2).ToString();
                string ngaysinh = da.GetValue(3).ToString();
                string diachi = da.GetValue(4).ToString();
                string email = da.GetValue(5).ToString();

                //
                modelThuThu.MaTT = matt;
                modelThuThu.HovaTen = hovaten;
                modelThuThu.GioiTinh = gioitinh;
                modelThuThu.NgaySinh = ngaysinh;
                modelThuThu.DiaChi = diachi;
                modelThuThu.Email = email;

                //

                changeCode.Text = matt;
                changeName.Text = hovaten;
                changeSex.Text = gioitinh;
                changeBirthdate.Text = ngaysinh;
                changeAddress.Text = diachi;
            }
            con.Close();
        }

        private void tbxTimKiemTL_TextChanged(object sender, EventArgs e)
        {
            GetlistTL();
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM TaiKhoan WHERE MaTT = N'" + getid + "' AND PhanQuyen = N'ADMIN'", conn);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                th = new Thread(OpennewAdmin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                th = new Thread(OpennewFormMain);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            conn.Close();
        }
        void OpennewAdmin()
        {
            Application.Run(new Admin(getid));
        }

        private void tbxTheLoaiTL_TextChanged(object sender, EventArgs e)
        {
            int id = 0;

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select Max(Id) From Sach", conn);
            conn.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                id = Int32.Parse(da.GetValue(0).ToString());
            }

            conn = new SqlConnection(connection);
            cmd = new SqlCommand("SELECT id From Sach Where MaS = N'" + tbxMaTL.Text + "'", conn);
            conn.Open();
            da = cmd.ExecuteReader();
            if (!da.Read())
            {
                tbxMaTL.Text = "";
                if (tbxTheLoaiTL.Text.Contains("Giáo trình bài giảng"))
                    tbxMaTL.Text = "GTBG" + id++;
                else if (tbxTheLoaiTL.Text.Contains("Luận văn, Nghiên cứu khoa học"))
                    tbxMaTL.Text = "LVNCKH" + id++;
                else
                    tbxMaTL.Text = "TLTK" + id++;
            }
            conn.Close();

        }

        private void grvTL_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prepare.TheLoaiSach cl = new Prepare.TheLoaiSach();
            cl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Prepare.TraSach_Codition ts = new Prepare.TraSach_Codition();
            ts.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Prepare.MuonSach_Codition ms = new Prepare.MuonSach_Codition();
            ms.Show();
        }
    }
}
