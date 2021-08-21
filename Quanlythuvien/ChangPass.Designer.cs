
namespace Quanlythuvien
{
    partial class ChangPass
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
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxCFPassword = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbOld = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.lbCF = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSeen = new System.Windows.Forms.Button();
            this.btnUnseen = new System.Windows.Forms.Button();
            this.Unseen = new System.Windows.Forms.Button();
            this.Seen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOldPassword.Location = new System.Drawing.Point(197, 66);
            this.tbxOldPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.PasswordChar = '*';
            this.tbxOldPassword.Size = new System.Drawing.Size(291, 23);
            this.tbxOldPassword.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(197, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 35);
            this.button1.TabIndex = 213123;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 1);
            this.panel1.TabIndex = 12312;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 1);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 11221;
            this.label2.Text = "Tên tài khoản: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 1211212;
            this.label3.Text = "Nhập mật khẩu cũ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 12112;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 211212;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassword.Location = new System.Drawing.Point(197, 123);
            this.tbxNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '*';
            this.tbxNewPassword.Size = new System.Drawing.Size(291, 23);
            this.tbxNewPassword.TabIndex = 1;
            // 
            // tbxCFPassword
            // 
            this.tbxCFPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCFPassword.Location = new System.Drawing.Point(197, 180);
            this.tbxCFPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCFPassword.Name = "tbxCFPassword";
            this.tbxCFPassword.PasswordChar = '*';
            this.tbxCFPassword.Size = new System.Drawing.Size(291, 23);
            this.tbxCFPassword.TabIndex = 2;
            // 
            // tbxResult
            // 
            this.tbxResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxResult.Location = new System.Drawing.Point(11, 298);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(550, 16);
            this.tbxResult.TabIndex = 2121122;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(-6, 333);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 1);
            this.panel3.TabIndex = 122;
            // 
            // lbOld
            // 
            this.lbOld.AutoSize = true;
            this.lbOld.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOld.Location = new System.Drawing.Point(198, 91);
            this.lbOld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOld.Name = "lbOld";
            this.lbOld.Size = new System.Drawing.Size(0, 15);
            this.lbOld.TabIndex = 12321123;
            this.lbOld.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNew.Location = new System.Drawing.Point(198, 148);
            this.lbNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(0, 15);
            this.lbNew.TabIndex = 1231231;
            this.lbNew.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbCF
            // 
            this.lbCF.AutoSize = true;
            this.lbCF.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCF.Location = new System.Drawing.Point(198, 205);
            this.lbCF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCF.Name = "lbCF";
            this.lbCF.Size = new System.Drawing.Size(0, 15);
            this.lbCF.TabIndex = 12123;
            this.lbCF.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(97, 12);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 15);
            this.lbUsername.TabIndex = 11221;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSeen
            // 
            this.btnSeen.BackgroundImage = global::Quanlythuvien.Properties.Resources.seen;
            this.btnSeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeen.FlatAppearance.BorderSize = 0;
            this.btnSeen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeen.Location = new System.Drawing.Point(466, 123);
            this.btnSeen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(22, 22);
            this.btnSeen.TabIndex = 12321124;
            this.btnSeen.Text = "button2";
            this.btnSeen.UseVisualStyleBackColor = true;
            this.btnSeen.Click += new System.EventHandler(this.btnSeen_Click);
            // 
            // btnUnseen
            // 
            this.btnUnseen.BackgroundImage = global::Quanlythuvien.Properties.Resources.unseen;
            this.btnUnseen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnseen.FlatAppearance.BorderSize = 0;
            this.btnUnseen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnseen.Location = new System.Drawing.Point(466, 123);
            this.btnUnseen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnseen.Name = "btnUnseen";
            this.btnUnseen.Size = new System.Drawing.Size(22, 23);
            this.btnUnseen.TabIndex = 12321125;
            this.btnUnseen.Text = "button2";
            this.btnUnseen.UseVisualStyleBackColor = true;
            this.btnUnseen.Click += new System.EventHandler(this.btnUnseen_Click);
            // 
            // Unseen
            // 
            this.Unseen.BackgroundImage = global::Quanlythuvien.Properties.Resources.unseen;
            this.Unseen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Unseen.FlatAppearance.BorderSize = 0;
            this.Unseen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unseen.Location = new System.Drawing.Point(466, 66);
            this.Unseen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Unseen.Name = "Unseen";
            this.Unseen.Size = new System.Drawing.Size(22, 23);
            this.Unseen.TabIndex = 12321125;
            this.Unseen.Text = "button2";
            this.Unseen.UseVisualStyleBackColor = true;
            this.Unseen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Seen
            // 
            this.Seen.BackgroundImage = global::Quanlythuvien.Properties.Resources.seen;
            this.Seen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Seen.FlatAppearance.BorderSize = 0;
            this.Seen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Seen.Location = new System.Drawing.Point(466, 66);
            this.Seen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seen.Name = "Seen";
            this.Seen.Size = new System.Drawing.Size(22, 22);
            this.Seen.TabIndex = 12321124;
            this.Seen.Text = "button2";
            this.Seen.UseVisualStyleBackColor = true;
            this.Seen.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChangPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.Unseen);
            this.Controls.Add(this.btnUnseen);
            this.Controls.Add(this.Seen);
            this.Controls.Add(this.btnSeen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCF);
            this.Controls.Add(this.lbNew);
            this.Controls.Add(this.lbOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCFPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxOldPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.ChangPass_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxCFPassword;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbOld;
        private System.Windows.Forms.Label lbNew;
        private System.Windows.Forms.Label lbCF;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSeen;
        private System.Windows.Forms.Button btnUnseen;
        private System.Windows.Forms.Button Unseen;
        private System.Windows.Forms.Button Seen;
    }
}