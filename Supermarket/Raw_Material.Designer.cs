namespace Supermarket
{
    partial class Raw_Material
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.id_name = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rAWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWMATERIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rM = new Supermarket.RM();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rAW_MATERIALTableAdapter = new Supermarket.RMTableAdapters.RAW_MATERIALTableAdapter();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWMATERIALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(149, 43);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(282, 39);
            this.id_name.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.delete);
            this.panel8.Controls.Add(this.reload);
            this.panel8.Controls.Add(this.change);
            this.panel8.Location = new System.Drawing.Point(656, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(524, 95);
            this.panel8.TabIndex = 46;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(158, 44);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 39);
            this.delete.TabIndex = 12;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reload
            // 
            this.reload.Image = global::Supermarket.Properties.Resources.refresh;
            this.reload.Location = new System.Drawing.Point(470, 44);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(45, 38);
            this.reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reload.TabIndex = 11;
            this.reload.TabStop = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(314, 43);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(150, 39);
            this.change.TabIndex = 10;
            this.change.Text = "Thêm mới";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.id_name);
            this.panel2.Location = new System.Drawing.Point(23, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 95);
            this.panel2.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã ",
            "Tên "});
            this.comboBox1.Location = new System.Drawing.Point(8, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 39);
            this.comboBox1.TabIndex = 5;
            // 
            // search
            // 
            this.search.Image = global::Supermarket.Properties.Resources.search;
            this.search.Location = new System.Drawing.Point(437, 43);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(45, 39);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu hàng";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView);
            this.panel9.Location = new System.Drawing.Point(23, 207);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1160, 557);
            this.panel9.TabIndex = 47;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAWIDDataGridViewTextBoxColumn,
            this.rAWDATEDataGridViewTextBoxColumn,
            this.rAWQUANTITYDataGridViewTextBoxColumn,
            this.rAWTOTALDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView.DataSource = this.rAWMATERIALBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1157, 557);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // rAWIDDataGridViewTextBoxColumn
            // 
            this.rAWIDDataGridViewTextBoxColumn.DataPropertyName = "RAW_ID";
            this.rAWIDDataGridViewTextBoxColumn.HeaderText = "Mã phiếu hàng";
            this.rAWIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWIDDataGridViewTextBoxColumn.Name = "rAWIDDataGridViewTextBoxColumn";
            this.rAWIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rAWDATEDataGridViewTextBoxColumn
            // 
            this.rAWDATEDataGridViewTextBoxColumn.DataPropertyName = "RAW_DATE";
            this.rAWDATEDataGridViewTextBoxColumn.HeaderText = "Ngày lập phiếu";
            this.rAWDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWDATEDataGridViewTextBoxColumn.Name = "rAWDATEDataGridViewTextBoxColumn";
            this.rAWDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rAWQUANTITYDataGridViewTextBoxColumn
            // 
            this.rAWQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "RAW_QUANTITY";
            this.rAWQUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng ";
            this.rAWQUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWQUANTITYDataGridViewTextBoxColumn.Name = "rAWQUANTITYDataGridViewTextBoxColumn";
            this.rAWQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWQUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // rAWTOTALDataGridViewTextBoxColumn
            // 
            this.rAWTOTALDataGridViewTextBoxColumn.DataPropertyName = "RAW_TOTAL";
            this.rAWTOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.rAWTOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWTOTALDataGridViewTextBoxColumn.Name = "rAWTOTALDataGridViewTextBoxColumn";
            this.rAWTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAWTOTALDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "S_Name";
            this.Column1.HeaderText = "Nhà cung cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // rAWMATERIALBindingSource
            // 
            this.rAWMATERIALBindingSource.DataMember = "RAW_MATERIAL";
            this.rAWMATERIALBindingSource.DataSource = this.rM;
            // 
            // rM
            // 
            this.rM.DataSetName = "RM";
            this.rM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 45);
            this.panel1.TabIndex = 44;
            // 
            // rAW_MATERIALTableAdapter
            // 
            this.rAW_MATERIALTableAdapter.ClearBeforeFill = true;
            // 
            // Raw_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Name = "Raw_Material";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Raw_Material_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWMATERIALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rAWMATERIALBindingSource;
        private RM rM;
        private RMTableAdapters.RAW_MATERIALTableAdapter rAW_MATERIALTableAdapter;
    }
}
