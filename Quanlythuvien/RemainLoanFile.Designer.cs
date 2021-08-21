
namespace Quanlythuvien
{
    partial class RemainLoanFile
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachConMuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachConMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Danh sách tài liệu bạn đang còn mượn: ";
            // 
            // dgvDanhSachConMuon
            // 
            this.dgvDanhSachConMuon.AllowUserToAddRows = false;
            this.dgvDanhSachConMuon.AllowUserToDeleteRows = false;
            this.dgvDanhSachConMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachConMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachConMuon.Location = new System.Drawing.Point(15, 52);
            this.dgvDanhSachConMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachConMuon.MultiSelect = false;
            this.dgvDanhSachConMuon.Name = "dgvDanhSachConMuon";
            this.dgvDanhSachConMuon.ReadOnly = true;
            this.dgvDanhSachConMuon.RowHeadersVisible = false;
            this.dgvDanhSachConMuon.RowHeadersWidth = 51;
            this.dgvDanhSachConMuon.RowTemplate.Height = 24;
            this.dgvDanhSachConMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachConMuon.Size = new System.Drawing.Size(939, 391);
            this.dgvDanhSachConMuon.TabIndex = 113;
            // 
            // RemainLoanFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(967, 459);
            this.Controls.Add(this.dgvDanhSachConMuon);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(985, 506);
            this.MinimumSize = new System.Drawing.Size(985, 506);
            this.Name = "RemainLoanFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemainLoanFile";
            this.Load += new System.EventHandler(this.RemainLoanFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachConMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhSachConMuon;
    }
}