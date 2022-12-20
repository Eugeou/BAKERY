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
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.supplier = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.customer = new System.Windows.Forms.Button();
            this.control_panel = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.raw = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.product_type = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bill1 = new Supermarket.Usercontrol.Bill();
            this.supplier1 = new Supermarket.Supplier();
            this.sellers1 = new Supermarket.Sellers();
            this.raw_Material2 = new Supermarket.Raw_Material();
            this.products1 = new Supermarket.Products();
            this.categories1 = new Supermarket.Categories();
            this.customers1 = new Supermarket.Customers();
            this.raw_Material1 = new Supermarket.Raw_Material();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.supplier);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.control_panel);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.raw);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.bill);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.product_type);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox10.Location = new System.Drawing.Point(47, 512);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // supplier
            // 
            this.supplier.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Location = new System.Drawing.Point(93, 512);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(219, 40);
            this.supplier.TabIndex = 20;
            this.supplier.Text = "Nhà cung cấp";
            this.supplier.UseVisualStyleBackColor = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox7.Location = new System.Drawing.Point(47, 455);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(93, 455);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(219, 40);
            this.customer.TabIndex = 18;
            this.customer.Text = "Khách hàng";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.Gray;
            this.control_panel.Location = new System.Drawing.Point(0, 148);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(10, 40);
            this.control_panel.TabIndex = 17;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Supermarket.Properties.Resources.raw_materials;
            this.pictureBox9.Location = new System.Drawing.Point(47, 568);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // raw
            // 
            this.raw.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raw.Location = new System.Drawing.Point(93, 568);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(219, 40);
            this.raw.TabIndex = 15;
            this.raw.Text = "Nguyên liệu";
            this.raw.UseVisualStyleBackColor = true;
            this.raw.Click += new System.EventHandler(this.raw_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Supermarket.Properties.Resources.logout;
            this.pictureBox8.Location = new System.Drawing.Point(47, 715);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Supermarket.Properties.Resources.bill;
            this.pictureBox6.Location = new System.Drawing.Point(47, 396);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Supermarket.Properties.Resources.employees;
            this.pictureBox5.Location = new System.Drawing.Point(47, 335);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.box;
            this.pictureBox4.Location = new System.Drawing.Point(47, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.cupcake;
            this.pictureBox3.Location = new System.Drawing.Point(47, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.monitor;
            this.pictureBox2.Location = new System.Drawing.Point(47, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(93, 715);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 40);
            this.logout.TabIndex = 7;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // bill
            // 
            this.bill.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(93, 396);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(219, 40);
            this.bill.TabIndex = 5;
            this.bill.Text = "Hóa đơn";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(93, 335);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(219, 40);
            this.employee.TabIndex = 4;
            this.employee.Text = "Nhân viên";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // product_type
            // 
            this.product_type.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_type.Location = new System.Drawing.Point(93, 272);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(219, 40);
            this.product_type.TabIndex = 3;
            this.product_type.Text = "Loại sản phẩm";
            this.product_type.UseVisualStyleBackColor = true;
            this.product_type.Click += new System.EventHandler(this.product_type_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(93, 211);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(219, 40);
            this.product.TabIndex = 2;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(93, 148);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(219, 40);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Trang chủ";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(65, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bill1);
            this.panel2.Controls.Add(this.supplier1);
            this.panel2.Controls.Add(this.sellers1);
            this.panel2.Controls.Add(this.raw_Material2);
            this.panel2.Controls.Add(this.products1);
            this.panel2.Controls.Add(this.categories1);
            this.panel2.Controls.Add(this.customers1);
            this.panel2.Controls.Add(this.raw_Material1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(350, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 800);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bill1
            // 
            this.bill1.Location = new System.Drawing.Point(0, 0);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(1200, 800);
            this.bill1.TabIndex = 9;
            // 
            // supplier1
            // 
            this.supplier1.Location = new System.Drawing.Point(0, 0);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(1200, 800);
            this.supplier1.TabIndex = 8;
            // 
            // sellers1
            // 
            this.sellers1.BackColor = System.Drawing.Color.White;
            this.sellers1.Location = new System.Drawing.Point(0, 0);
            this.sellers1.Name = "sellers1";
            this.sellers1.Size = new System.Drawing.Size(1200, 800);
            this.sellers1.TabIndex = 7;
            // 
            // raw_Material2
            // 
            this.raw_Material2.BackColor = System.Drawing.Color.White;
            this.raw_Material2.Location = new System.Drawing.Point(0, 0);
            this.raw_Material2.Name = "raw_Material2";
            this.raw_Material2.Size = new System.Drawing.Size(1200, 800);
            this.raw_Material2.TabIndex = 6;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.White;
            this.products1.Location = new System.Drawing.Point(0, 0);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1200, 800);
            this.products1.TabIndex = 5;
            // 
            // 
            // categories1
            // 
            this.categories1.BackColor = System.Drawing.Color.White;
            this.categories1.Location = new System.Drawing.Point(0, 0);
            this.categories1.Name = "categories1";
            this.categories1.Size = new System.Drawing.Size(1200, 800);
            this.categories1.TabIndex = 3;
            // 
            // customers1
            // 
            this.customers1.Location = new System.Drawing.Point(0, 0);
            this.customers1.Name = "customers1";
            this.customers1.Size = new System.Drawing.Size(1200, 800);
            this.customers1.TabIndex = 2;
            // 
            // raw_Material1
            // 
            this.raw_Material1.BackColor = System.Drawing.Color.White;
            this.raw_Material1.Location = new System.Drawing.Point(0, 0);
            this.raw_Material1.Name = "raw_Material1";
            this.raw_Material1.Size = new System.Drawing.Size(1200, 800);
            this.raw_Material1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 800);
            this.panel3.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button raw;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button customer;
        private Raw_Material raw_Material1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button supplier;
        private Usercontrol.Bill bill1;
        private Supplier supplier1;
        private Sellers sellers1;
        private Raw_Material raw_Material2;
        private Products products1;
        private Dashboard dashboard1;
        private Categories categories1;
        private Customers customers1;
    }
}