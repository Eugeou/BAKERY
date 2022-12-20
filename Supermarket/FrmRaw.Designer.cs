namespace Supermarket
{
    partial class FrmRaw
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.provider = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.exit);
            this.panel8.Controls.Add(this.save);
            this.panel8.Controls.Add(this.add);
            this.panel8.Location = new System.Drawing.Point(45, 567);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 86);
            this.panel8.TabIndex = 45;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(342, 21);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(150, 45);
            this.exit.TabIndex = 13;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(9, 21);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 45);
            this.save.TabIndex = 10;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(176, 21);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 45);
            this.add.TabIndex = 11;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.price);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(45, 466);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 95);
            this.panel7.TabIndex = 44;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(11, 42);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(481, 39);
            this.price.TabIndex = 4;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giá";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.quantity);
            this.panel5.Location = new System.Drawing.Point(45, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 95);
            this.panel5.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(11, 42);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(481, 39);
            this.quantity.TabIndex = 3;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.provider);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(45, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 95);
            this.panel4.TabIndex = 41;
            // 
            // provider
            // 
            this.provider.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provider.FormattingEnabled = true;
            this.provider.Location = new System.Drawing.Point(8, 42);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(484, 39);
            this.provider.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.name);
            this.panel3.Location = new System.Drawing.Point(45, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 95);
            this.panel3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nguyên liệu";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(9, 42);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(483, 39);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(45, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 95);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.id);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(11, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 39);
            this.panel1.TabIndex = 46;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(103, 31);
            this.id.TabIndex = 47;
            this.id.Text = "PH00001";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(605, 45);
            this.panel6.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phiếu hàng";
            // 
            // FrmRaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 657);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw";
            this.Load += new System.EventHandler(this.Raw_Load);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ComboBox provider;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
    }
}