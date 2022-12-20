namespace Supermarket.Usercontrol
{
    partial class Bill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b = new Supermarket.B();
            this.panel8 = new System.Windows.Forms.Panel();
            this.reload = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.bILLTableAdapter = new Supermarket.BTableAdapters.BILLTableAdapter();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 15);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.bDATEDataGridViewTextBoxColumn,
            this.cUSIDDataGridViewTextBoxColumn,
            this.eMIDDataGridViewTextBoxColumn,
            this.bPRICEDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bILLBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(21, 210);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1159, 555);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.b;
            // 
            // b
            // 
            this.b.DataSetName = "B";
            this.b.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.reload);
            this.panel8.Controls.Add(this.change);
            this.panel8.Location = new System.Drawing.Point(651, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(529, 95);
            this.panel8.TabIndex = 48;
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
            this.change.Location = new System.Drawing.Point(242, 43);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(222, 39);
            this.change.TabIndex = 10;
            this.change.Text = "Thêm hóa đơn";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.id_name);
            this.panel2.Location = new System.Drawing.Point(21, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 95);
            this.panel2.TabIndex = 47;
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
            this.search.Size = new System.Drawing.Size(45, 39);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
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
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bDATEDataGridViewTextBoxColumn
            // 
            this.bDATEDataGridViewTextBoxColumn.DataPropertyName = "B_DATE";
            this.bDATEDataGridViewTextBoxColumn.HeaderText = "Ngày hóa đơn";
            this.bDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDATEDataGridViewTextBoxColumn.Name = "bDATEDataGridViewTextBoxColumn";
            this.bDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSIDDataGridViewTextBoxColumn
            // 
            this.cUSIDDataGridViewTextBoxColumn.DataPropertyName = "CUS_NAME";
            this.cUSIDDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.cUSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSIDDataGridViewTextBoxColumn.Name = "cUSIDDataGridViewTextBoxColumn";
            this.cUSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMIDDataGridViewTextBoxColumn
            // 
            this.eMIDDataGridViewTextBoxColumn.DataPropertyName = "EM_NAME";
            this.eMIDDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.eMIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMIDDataGridViewTextBoxColumn.Name = "eMIDDataGridViewTextBoxColumn";
            this.eMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bPRICEDataGridViewTextBoxColumn
            // 
            this.bPRICEDataGridViewTextBoxColumn.DataPropertyName = "B_PRICE";
            this.bPRICEDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.bPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bPRICEDataGridViewTextBoxColumn.Name = "bPRICEDataGridViewTextBoxColumn";
            this.bPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox id_name;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private B b;
        private BTableAdapters.BILLTableAdapter bILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPRICEDataGridViewTextBoxColumn;
    }
}
