namespace Quanlythuvien
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbNotice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbForgot = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxStudentcode = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSeen = new System.Windows.Forms.Button();
            this.btnUnseen = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNotice.Location = new System.Drawing.Point(37, 485);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(0, 21);
            this.lbNotice.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(37, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(36, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(40, 324);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 1);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(40, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 1);
            this.panel1.TabIndex = 67;
            // 
            // lbForgot
            // 
            this.lbForgot.AutoSize = true;
            this.lbForgot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgot.Location = new System.Drawing.Point(36, 514);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(125, 21);
            this.lbForgot.TabIndex = 65;
            this.lbForgot.TabStop = true;
            this.lbForgot.Text = "Quên mật khẩu?";
            this.lbForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgot_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 37);
            this.button1.TabIndex = 64;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(41, 384);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(324, 21);
            this.tbxPassword.TabIndex = 63;
            // 
            // tbxStudentcode
            // 
            this.tbxStudentcode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxStudentcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStudentcode.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentcode.Location = new System.Drawing.Point(40, 297);
            this.tbxStudentcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxStudentcode.Name = "tbxStudentcode";
            this.tbxStudentcode.Size = new System.Drawing.Size(324, 21);
            this.tbxStudentcode.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(0, -10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(407, 242);
            this.panel3.MinimumSize = new System.Drawing.Size(407, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 242);
            this.panel3.TabIndex = 61;
            this.panel3.TabStop = true;
            // 
            // btnSeen
            // 
            this.btnSeen.BackgroundImage = global::Quanlythuvien.Properties.Resources.seen;
            this.btnSeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeen.FlatAppearance.BorderSize = 0;
            this.btnSeen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeen.Location = new System.Drawing.Point(335, 379);
            this.btnSeen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(29, 30);
            this.btnSeen.TabIndex = 69;
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
            this.btnUnseen.Location = new System.Drawing.Point(335, 379);
            this.btnUnseen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnseen.Name = "btnUnseen";
            this.btnUnseen.Size = new System.Drawing.Size(29, 30);
            this.btnUnseen.TabIndex = 70;
            this.btnUnseen.Text = "button2";
            this.btnUnseen.UseVisualStyleBackColor = true;
            this.btnUnseen.Click += new System.EventHandler(this.btnUnseen_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(235, 514);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 21);
            this.linkLabel1.TabIndex = 74;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trở lại trang chủ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(407, 569);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeen);
            this.Controls.Add(this.btnUnseen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbForgot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxStudentcode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeen;
        private System.Windows.Forms.Button btnUnseen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbForgot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxStudentcode;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

