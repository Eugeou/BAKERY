namespace Supermarket
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
            this.label_dangnhap = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.login1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.login2 = new System.Windows.Forms.Button();
            this.adminlogin = new System.Windows.Forms.Label();
            this.em_login = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.signup = new System.Windows.Forms.Label();
            this.ForgotPass = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_dangnhap
            // 
            this.label_dangnhap.AutoSize = true;
            this.label_dangnhap.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_dangnhap.Location = new System.Drawing.Point(735, 32);
            this.label_dangnhap.Name = "label_dangnhap";
            this.label_dangnhap.Size = new System.Drawing.Size(207, 50);
            this.label_dangnhap.TabIndex = 1;
            this.label_dangnhap.Text = "Đăng nhập";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(74, 56);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(340, 42);
            this.username.TabIndex = 2;
            this.username.Click += new System.EventHandler(this.tendangnhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(74, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.username);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(625, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 113);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.password);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(625, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 113);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.unlock;
            this.pictureBox2.Location = new System.Drawing.Point(12, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(74, 56);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(340, 42);
            this.password.TabIndex = 2;
            this.password.Click += new System.EventHandler(this.Matkhau_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(74, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(340, 1);
            this.panel7.TabIndex = 3;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.ForeColor = System.Drawing.Color.White;
            this.login1.Location = new System.Drawing.Point(637, 398);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(190, 50);
            this.login1.TabIndex = 9;
            this.login1.Text = "Đăng nhập";
            this.login1.UseVisualStyleBackColor = false;
            this.login1.Click += new System.EventHandler(this.Dangnhap_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(849, 398);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(190, 50);
            this.exit.TabIndex = 10;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(567, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 600);
            this.panel8.TabIndex = 0;
            // 
            // login2
            // 
            this.login2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login2.ForeColor = System.Drawing.Color.White;
            this.login2.Location = new System.Drawing.Point(637, 398);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(190, 50);
            this.login2.TabIndex = 11;
            this.login2.Text = "Đăng nhập";
            this.login2.UseVisualStyleBackColor = false;
            this.login2.Click += new System.EventHandler(this.Dangnhap2_Click);
            // 
            // adminlogin
            // 
            this.adminlogin.AutoSize = true;
            this.adminlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminlogin.Location = new System.Drawing.Point(762, 469);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(147, 31);
            this.adminlogin.TabIndex = 12;
            this.adminlogin.Text = "Quản trị viên";
            this.adminlogin.Click += new System.EventHandler(this.adminlogin_Click);
            // 
            // em_login
            // 
            this.em_login.AutoSize = true;
            this.em_login.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.em_login.Location = new System.Drawing.Point(776, 469);
            this.em_login.Name = "em_login";
            this.em_login.Size = new System.Drawing.Size(119, 31);
            this.em_login.TabIndex = 13;
            this.em_login.Text = "Nhân viên";
            this.em_login.Click += new System.EventHandler(this.userlogin_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.Location = new System.Drawing.Point(895, 347);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(144, 27);
            this.showpass.TabIndex = 14;
            this.showpass.Text = "Hiện mật khẩu";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.signup.Location = new System.Drawing.Point(794, 520);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(87, 28);
            this.signup.TabIndex = 16;
            this.signup.Text = "Đăng ký";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass.ForeColor = System.Drawing.Color.Red;
            this.ForgotPass.Location = new System.Drawing.Point(633, 347);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(138, 23);
            this.ForgotPass.TabIndex = 17;
            this.ForgotPass.Text = "Quên mật khẩu?";
            this.ForgotPass.Click += new System.EventHandler(this.ForgotPass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.bakery_shop_bakery_shop_bakery_shop_flat_style_facade_bakery_shop_facade_bakery_shop_flat_style_vector_116241299;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(567, 650);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.em_login);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label_dangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_dangnhap;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label adminlogin;
        private System.Windows.Forms.Label em_login;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label ForgotPass;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}