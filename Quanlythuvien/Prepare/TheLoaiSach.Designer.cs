
namespace Quanlythuvien.Prepare
{
    partial class TheLoaiSach
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Quanlythuvien.LibraryDataSet1();
            this.getGTBGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gTBG = new Quanlythuvien.LibraryDataSet1TableAdapters.GTBG();
            this.getCNTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNTT = new Quanlythuvien.LibraryDataSet1TableAdapters.CNTT();
            this.getKTLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kTLS = new Quanlythuvien.LibraryDataSet1TableAdapters.KTLS();
            this.getQHLNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qHLN = new Quanlythuvien.LibraryDataSet1TableAdapters.QHLN();
            this.getLVNCKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lVNCKH = new Quanlythuvien.LibraryDataSet1TableAdapters.LVNCKH();
            this.getQLTNRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTNR = new Quanlythuvien.LibraryDataSet1TableAdapters.QLTNR();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGTBGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCNTTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKTLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQHLNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLVNCKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQLTNRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "GTBG";
            reportDataSource1.Value = this.getGTBGBindingSource;
            reportDataSource2.Name = "CNTT";
            reportDataSource2.Value = this.getCNTTBindingSource;
            reportDataSource3.Name = "KTLS";
            reportDataSource3.Value = this.getKTLSBindingSource;
            reportDataSource4.Name = "QHLN";
            reportDataSource4.Value = this.getQHLNBindingSource;
            reportDataSource5.Name = "LVNCKH";
            reportDataSource5.Value = this.getLVNCKHBindingSource;
            reportDataSource6.Name = "QLTNR";
            reportDataSource6.Value = this.getQLTNRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlythuvien.Prepare.SachTheLoai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.libraryDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGTBGBindingSource
            // 
            this.getGTBGBindingSource.DataMember = "GetGTBG";
            this.getGTBGBindingSource.DataSource = this.bindingSource1;
            // 
            // gTBG
            // 
            this.gTBG.ClearBeforeFill = true;
            // 
            // getCNTTBindingSource
            // 
            this.getCNTTBindingSource.DataMember = "GetCNTT";
            this.getCNTTBindingSource.DataSource = this.bindingSource1;
            // 
            // cNTT
            // 
            this.cNTT.ClearBeforeFill = true;
            // 
            // getKTLSBindingSource
            // 
            this.getKTLSBindingSource.DataMember = "GetKTLS";
            this.getKTLSBindingSource.DataSource = this.bindingSource1;
            // 
            // kTLS
            // 
            this.kTLS.ClearBeforeFill = true;
            // 
            // getQHLNBindingSource
            // 
            this.getQHLNBindingSource.DataMember = "GetQHLN";
            this.getQHLNBindingSource.DataSource = this.bindingSource1;
            // 
            // qHLN
            // 
            this.qHLN.ClearBeforeFill = true;
            // 
            // getLVNCKHBindingSource
            // 
            this.getLVNCKHBindingSource.DataMember = "GetLVNCKH";
            this.getLVNCKHBindingSource.DataSource = this.bindingSource1;
            // 
            // lVNCKH
            // 
            this.lVNCKH.ClearBeforeFill = true;
            // 
            // getQLTNRBindingSource
            // 
            this.getQLTNRBindingSource.DataMember = "GetQLTNR";
            this.getQLTNRBindingSource.DataSource = this.bindingSource1;
            // 
            // qLTNR
            // 
            this.qLTNR.ClearBeforeFill = true;
            // 
            // TheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TheLoaiSach";
            this.Text = "TheLoaiSach";
            this.Load += new System.EventHandler(this.TheLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGTBGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCNTTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getKTLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQHLNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLVNCKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQLTNRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource getGTBGBindingSource;
        private LibraryDataSet1TableAdapters.GTBG gTBG;
        private System.Windows.Forms.BindingSource getCNTTBindingSource;
        private LibraryDataSet1TableAdapters.CNTT cNTT;
        private System.Windows.Forms.BindingSource getKTLSBindingSource;
        private LibraryDataSet1TableAdapters.KTLS kTLS;
        private System.Windows.Forms.BindingSource getQHLNBindingSource;
        private LibraryDataSet1TableAdapters.QHLN qHLN;
        private System.Windows.Forms.BindingSource getLVNCKHBindingSource;
        private LibraryDataSet1TableAdapters.LVNCKH lVNCKH;
        private System.Windows.Forms.BindingSource getQLTNRBindingSource;
        private LibraryDataSet1TableAdapters.QLTNR qLTNR;
    }
}