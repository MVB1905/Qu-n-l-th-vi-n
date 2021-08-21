using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() {ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf"})
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = of.FileName;
                }
            }    
        }
    }
}
