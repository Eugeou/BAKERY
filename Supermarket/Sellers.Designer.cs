namespace Supermarket
{
    partial class Sellers
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.eMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMUSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eM = new Supermarket.EM();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.reload = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.eMPLOYEETableAdapter = new Supermarket.EMTableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eM)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMIDDataGridViewTextBoxColumn,
            this.eMNAMEDataGridViewTextBoxColumn,
            this.eMUSERNAMEDataGridViewTextBoxColumn,
            this.eMPASSWORDDataGridViewTextBoxColumn,
            this.eMPHONEDataGridViewTextBoxColumn,
            this.eMEMAILDataGridViewTextBoxColumn,
            this.eMPOSITIONDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.eMPLOYEEBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(19, 196);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1159, 601);
            this.dataGridView.TabIndex = 22;
            // 
            // eMIDDataGridViewTextBoxColumn
            // 
            this.eMIDDataGridViewTextBoxColumn.DataPropertyName = "EM_ID";
            this.eMIDDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.eMIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMIDDataGridViewTextBoxColumn.Name = "eMIDDataGridViewTextBoxColumn";
            this.eMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMNAMEDataGridViewTextBoxColumn
            // 
            this.eMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_NAME";
            this.eMNAMEDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.eMNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMNAMEDataGridViewTextBoxColumn.Name = "eMNAMEDataGridViewTextBoxColumn";
            this.eMNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMUSERNAMEDataGridViewTextBoxColumn
            // 
            this.eMUSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "EM_USERNAME";
            this.eMUSERNAMEDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.eMUSERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMUSERNAMEDataGridViewTextBoxColumn.Name = "eMUSERNAMEDataGridViewTextBoxColumn";
            this.eMUSERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMUSERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPASSWORDDataGridViewTextBoxColumn
            // 
            this.eMPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "EM_PASSWORD";
            this.eMPASSWORDDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.eMPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPASSWORDDataGridViewTextBoxColumn.Name = "eMPASSWORDDataGridViewTextBoxColumn";
            this.eMPASSWORDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPHONEDataGridViewTextBoxColumn
            // 
            this.eMPHONEDataGridViewTextBoxColumn.DataPropertyName = "EM_PHONE";
            this.eMPHONEDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.eMPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPHONEDataGridViewTextBoxColumn.Name = "eMPHONEDataGridViewTextBoxColumn";
            this.eMPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMEMAILDataGridViewTextBoxColumn
            // 
            this.eMEMAILDataGridViewTextBoxColumn.DataPropertyName = "EM_EMAIL";
            this.eMEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMEMAILDataGridViewTextBoxColumn.Name = "eMEMAILDataGridViewTextBoxColumn";
            this.eMEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMEMAILDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPOSITIONDataGridViewTextBoxColumn
            // 
            this.eMPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "EM_POSITION";
            this.eMPOSITIONDataGridViewTextBoxColumn.HeaderText = "Vị trí";
            this.eMPOSITIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPOSITIONDataGridViewTextBoxColumn.Name = "eMPOSITIONDataGridViewTextBoxColumn";
            this.eMPOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPOSITIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.eM;
            // 
            // eM
            // 
            this.eM.DataSetName = "EM";
            this.eM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 45);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân viên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.reload);
            this.panel8.Controls.Add(this.change);
            this.panel8.Location = new System.Drawing.Point(652, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(527, 103);
            this.panel8.TabIndex = 40;
            // 
            // reload
            // 
            this.reload.Image = global::Supermarket.Properties.Resources.refresh;
            this.reload.Location = new System.Drawing.Point(470, 44);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(45, 45);
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
            this.change.Size = new System.Drawing.Size(150, 45);
            this.change.TabIndex = 10;
            this.change.Text = "Thay đổi";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.id_name);
            this.panel2.Location = new System.Drawing.Point(19, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 95);
            this.panel2.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã ",
            "Tên "});
            this.comboBox1.Location = new System.Drawing.Point(8, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 45);
            this.comboBox1.TabIndex = 5;
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
            // search
            // 
            this.search.Image = global::Supermarket.Properties.Resources.search;
            this.search.Location = new System.Drawing.Point(437, 43);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(45, 45);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // id_name
            // 
            this.id_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name.Location = new System.Drawing.Point(149, 43);
            this.id_name.Multiline = true;
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(282, 45);
            this.id_name.TabIndex = 3;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Sellers";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMUSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private EM eM;
        private EMTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
    }
}
