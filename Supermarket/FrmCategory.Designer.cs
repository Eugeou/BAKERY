namespace Supermarket
{
    partial class FrmCategory
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
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.search_id = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.exit);
            this.panel8.Controls.Add(this.save);
            this.panel8.Controls.Add(this.edit);
            this.panel8.Controls.Add(this.delete);
            this.panel8.Location = new System.Drawing.Point(35, 372);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(576, 106);
            this.panel8.TabIndex = 18;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(440, 31);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(130, 45);
            this.exit.TabIndex = 13;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(3, 31);
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
            this.edit.Location = new System.Drawing.Point(294, 31);
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
            this.delete.Location = new System.Drawing.Point(148, 31);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(130, 45);
            this.delete.TabIndex = 11;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.description);
            this.panel4.Location = new System.Drawing.Point(35, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 95);
            this.panel4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô tả";
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(9, 43);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(489, 45);
            this.description.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.name);
            this.panel3.Location = new System.Drawing.Point(35, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 95);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(9, 43);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(489, 45);
            this.name.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.search_id);
            this.panel2.Controls.Add(this.id);
            this.panel2.Location = new System.Drawing.Point(35, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 95);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // search_id
            // 
            this.search_id.Image = global::Supermarket.Properties.Resources.search;
            this.search_id.Location = new System.Drawing.Point(525, 43);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(45, 45);
            this.search_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_id.TabIndex = 4;
            this.search_id.TabStop = false;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(9, 43);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(489, 45);
            this.id.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 45);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại sản phẩm";
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_id)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox search_id;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}