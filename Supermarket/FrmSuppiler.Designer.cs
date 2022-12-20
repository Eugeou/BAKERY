namespace Supermarket
{
    partial class FrmSuppiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.search_id = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(9, 43);
            this.phone.MaxLength = 10;
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(350, 45);
            this.phone.TabIndex = 3;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(9, 43);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(350, 45);
            this.address.TabIndex = 3;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(9, 43);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(350, 45);
            this.name.TabIndex = 3;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(9, 43);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(350, 45);
            this.id.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(694, 31);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(130, 45);
            this.exit.TabIndex = 13;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(9, 31);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 45);
            this.save.TabIndex = 10;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(473, 31);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(130, 45);
            this.edit.TabIndex = 12;
            this.edit.Text = "Sửa";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(229, 31);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 45);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.search_id);
            this.panel5.Controls.Add(this.id);
            this.panel5.Location = new System.Drawing.Point(50, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 95);
            this.panel5.TabIndex = 34;
            // 
            // search_id
            // 
            this.search_id.Image = global::Supermarket.Properties.Resources.search;
            this.search_id.Location = new System.Drawing.Point(365, 43);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(45, 45);
            this.search_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_id.TabIndex = 4;
            this.search_id.TabStop = false;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.exit);
            this.panel8.Controls.Add(this.save);
            this.panel8.Controls.Add(this.edit);
            this.panel8.Controls.Add(this.delete);
            this.panel8.Location = new System.Drawing.Point(50, 288);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(885, 106);
            this.panel8.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.address);
            this.panel4.Location = new System.Drawing.Point(515, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 95);
            this.panel4.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.phone);
            this.panel3.Location = new System.Drawing.Point(515, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 95);
            this.panel3.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(50, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 95);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 45);
            this.panel1.TabIndex = 35;
            // 
            // FrmSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 410);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuppiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuppiler";
            this.Load += new System.EventHandler(this.FrmSuppiler_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox search_id;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}