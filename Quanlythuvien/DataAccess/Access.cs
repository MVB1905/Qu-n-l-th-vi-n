using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.DataAccess
{
    class Access
    {
        string connetion = Properties.Settings.Default.connection;
        string path = @"D:\K63HTTH\Subjects\ThucTap1\Code\Bug\Log.txt";

        Quanlythuvien.Models.Sach modelSach = new Quanlythuvien.Models.Sach();

        private void Log(String value, string path)
        {
            using (StreamWriter s = new StreamWriter(path, true))
            {
                s.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ": " + value);
                s.WriteLine(Environment.NewLine + "------------------------------------------------------------------"
                    + Environment.NewLine);
            }
        }
        public DataTable Read(String query)
        {
            SqlConnection con = new SqlConnection(connetion);
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                con.Close();

                return tb;
            }
            catch (Exception e)
            {
                Log(e.ToString(), path);
                return null;
            }
        }
        public int Write(String query)
        {
            SqlConnection con = new SqlConnection(connetion);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();

            return count;
        }
    }
}
