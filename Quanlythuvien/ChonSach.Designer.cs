
namespace Quanlythuvien
{
    partial class ChonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rbMa = new System.Windows.Forms.RadioButton();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTL = new System.Windows.Forms.ComboBox();
            this.tbxSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvM)).BeginInit();
            this.SuspendLayout();
            // 
            // grvM
            // 
            this.grvM.AllowUserToAddRows = false;
            this.grvM.AllowUserToDeleteRows = false;
            this.grvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvM.Location = new System.Drawing.Point(11, 87);
            this.grvM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvM.MultiSelect = false;
            this.grvM.Name = "grvM";
            this.grvM.ReadOnly = true;
            this.grvM.RowHeadersVisible = false;
            this.grvM.RowHeadersWidth = 51;
            this.grvM.RowTemplate.Height = 24;
            this.grvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvM.Size = new System.Drawing.Size(853, 343);
            this.grvM.TabIndex = 151;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(443, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 152;
            this.button1.Text = "Mượn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(521, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 155;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.Location = new System.Drawing.Point(773, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 32);
            this.btnSearch.TabIndex = 154;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(521, 39);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(235, 20);
            this.tbxSearch.TabIndex = 153;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // rbMa
            // 
            this.rbMa.AutoSize = true;
            this.rbMa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMa.Location = new System.Drawing.Point(17, 44);
            this.rbMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMa.Name = "rbMa";
            this.rbMa.Size = new System.Drawing.Size(105, 25);
            this.rbMa.TabIndex = 156;
            this.rbMa.TabStop = true;
            this.rbMa.Text = "Mã tài liệu";
            this.rbMa.UseVisualStyleBackColor = true;
            this.rbMa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbTen
            // 
            this.rbTen.AutoSize = true;
            this.rbTen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTen.Location = new System.Drawing.Point(139, 44);
            this.rbTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(105, 25);
            this.rbTen.TabIndex = 156;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "Tên tài liệu";
            this.rbTen.UseVisualStyleBackColor = true;
            this.rbTen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 157;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cbxTL
            // 
            this.cbxTL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTL.FormattingEnabled = true;
            this.cbxTL.Items.AddRange(new object[] {
            "---Chọn thể loại---",
            "Giáo trình bài giảng",
            "Kỹ thuật lâm sinh",
            "Công nghệ thông tin",
            "Luận văn, Nghiên cứu khoa học",
            "Quy hoạch lâm nghiệp",
            "QL tài nguyên rừng và môi trường"});
            this.cbxTL.Location = new System.Drawing.Point(281, 39);
            this.cbxTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTL.Name = "cbxTL";
            this.cbxTL.Size = new System.Drawing.Size(212, 27);
            this.cbxTL.TabIndex = 158;
            this.cbxTL.SelectedIndexChanged += new System.EventHandler(this.cbxTL_SelectedIndexChanged);
            // 
            // tbxSoluong
            // 
            this.tbxSoluong.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoluong.Location = new System.Drawing.Point(321, 447);
            this.tbxSoluong.Name = "tbxSoluong";
            this.tbxSoluong.Size = new System.Drawing.Size(100, 28);
            this.tbxSoluong.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 157;
            this.label2.Text = "Số lượng:";
            // 
            // ChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(877, 497);
            this.Controls.Add(this.tbxSoluong);
            this.Controls.Add(this.cbxTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTen);
            this.Controls.Add(this.rbMa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.grvM);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChonSach";
            this.Text = "ChonSach";
            this.Load += new System.EventHandler(this.ChonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rbMa;
        private System.Windows.Forms.RadioButton rbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTL;
        private System.Windows.Forms.TextBox tbxSoluong;
        private System.Windows.Forms.Label label2;
    }
}