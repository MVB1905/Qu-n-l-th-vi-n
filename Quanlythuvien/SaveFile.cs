using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class SaveFile : Form
    {
        string connection = Properties.Settings.Default.connection;
        public SaveFile()
        {
            InitializeComponent();
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdg = new OpenFileDialog();
            fdg.ShowDialog();
            textBox1.Text = fdg.FileName;

        }
        void  Save(string path)
        {
            using (Stream stream = File.OpenRead(path))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string etxn = new FileInfo(path).Extension;
                string filename = new FileInfo(path).Name;

                string query = "INSERT INTO SaveFile(Data, Extension, Filename)VALUES(@data, @extension, @filename)";
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                cmd.Parameters.Add("@extension", SqlDbType.NVarChar).Value = etxn;
                cmd.Parameters.Add("@filename", SqlDbType.NVarChar).Value = filename;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                getlis();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(textBox1.Text);
        }

        private void SaveFile_Load(object sender, EventArgs e)
        {
            getlis();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.SelectedRows;
            foreach (var row in select)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }
        void OpenFile (int id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT Data, Extension, FileName FROM SaveFile WHERE ID = @id", con);
            cmd.Parameters.Add("@id", id);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var name = reader[2].ToString();
                var data = (byte[])reader[0];
                var exten = reader[1].ToString();

                var newfilename = name.Replace(exten, DateTime.Now.ToString("ddMMyyyyhhmmss")) + exten;
                File.WriteAllBytes(newfilename, data);
                System.Diagnostics.Process.Start(newfilename);
            }
        }
        void getlis()
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT ID, Extension, FileName FROM SaveFile ", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            if (tb != null)
                dataGridView1.DataSource = tb;
        }
    }
}
