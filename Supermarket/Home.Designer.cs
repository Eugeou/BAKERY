namespace Supermarket
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.control_panel = new System.Windows.Forms.Panel();
            this.raw = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.product_type = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard3 = new Supermarket.Dashboard();
            this.dashboard1 = new Supermarket.Dashboard();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.control_panel);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.raw);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.bill);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.product_type);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 769);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.Gray;
            this.control_panel.Location = new System.Drawing.Point(77, 144);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(75, 50);
            this.control_panel.TabIndex = 17;
            this.control_panel.Visible = false;
            // 
            // raw
            // 
            this.raw.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raw.Location = new System.Drawing.Point(93, 627);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(219, 50);
            this.raw.TabIndex = 15;
            this.raw.Text = "Nguyên liệu";
            this.raw.UseVisualStyleBackColor = true;
            this.raw.Click += new System.EventHandler(this.raw_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(93, 705);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 50);
            this.logout.TabIndex = 7;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(93, 547);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(219, 50);
            this.bill.TabIndex = 5;
            this.bill.Text = "Hóa đơn";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(93, 471);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(219, 50);
            this.employee.TabIndex = 4;
            this.employee.Text = "Nhân viên";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // product_type
            // 
            this.product_type.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_type.Location = new System.Drawing.Point(93, 398);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(219, 50);
            this.product_type.TabIndex = 3;
            this.product_type.Text = "Loại sản phẩm";
            this.product_type.UseVisualStyleBackColor = true;
            this.product_type.Click += new System.EventHandler(this.product_type_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(93, 305);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(219, 50);
            this.product.TabIndex = 2;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(93, 211);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(219, 50);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Trang chủ";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dashboard3);
            this.panel2.Controls.Add(this.dashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 769);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 800);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox9.Location = new System.Drawing.Point(37, 627);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(50, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Supermarket.Properties.Resources.logout;
            this.pictureBox8.Location = new System.Drawing.Point(37, 705);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Supermarket.Properties.Resources.bill;
            this.pictureBox6.Location = new System.Drawing.Point(37, 547);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Supermarket.Properties.Resources.employees;
            this.pictureBox5.Location = new System.Drawing.Point(37, 471);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.box;
            this.pictureBox4.Location = new System.Drawing.Point(37, 398);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.monitor;
            this.pictureBox2.Location = new System.Drawing.Point(37, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(92, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard3
            // 
            this.dashboard3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dashboard3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.dashboard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.dashboard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard3.Location = new System.Drawing.Point(0, 0);
            this.dashboard3.Name = "dashboard3";
            this.dashboard3.Size = new System.Drawing.Size(1180, 803);
            this.dashboard3.TabIndex = 1;
            this.dashboard3.Load += new System.EventHandler(this.dashboard3_Load);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.dashboard1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1194, 764);
            this.dashboard1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1550, 769);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button product_type;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button raw;
        private Dashboard dashboard1;
        private System.Windows.Forms.Panel control_panel;
        private Dashboard dashboard3;
        private System.Windows.Forms.Button button1;
    }
}