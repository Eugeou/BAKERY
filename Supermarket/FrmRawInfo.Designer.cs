namespace Supermarket
{
    partial class FrmRawInfo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rAWINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawInfo = new Supermarket.RawInfo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rAWINFOTableAdapter = new Supermarket.RawInfoTableAdapters.RAWINFOTableAdapter();
            this.exit = new System.Windows.Forms.Button();
            this.rIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rINAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rITOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 442);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIIDDataGridViewTextBoxColumn,
            this.rAWIDDataGridViewTextBoxColumn,
            this.rINAMEDataGridViewTextBoxColumn,
            this.rIQUANTITYDataGridViewTextBoxColumn,
            this.rIPRICEDataGridViewTextBoxColumn,
            this.rITOTALDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.rAWINFOBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(3, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(960, 442);
            this.dataGridView.TabIndex = 0;
            // 
            // rAWINFOBindingSource
            // 
            this.rAWINFOBindingSource.DataMember = "RAWINFO";
            this.rAWINFOBindingSource.DataSource = this.rawInfo;
            // 
            // rawInfo
            // 
            this.rawInfo.DataSetName = "RawInfo";
            this.rawInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 45);
            this.panel2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết phiếu hàng";
            // 
            // rAWINFOTableAdapter
            // 
            this.rAWINFOTableAdapter.ClearBeforeFill = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(830, 543);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(158, 43);
            this.exit.TabIndex = 47;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // rIIDDataGridViewTextBoxColumn
            // 
            this.rIIDDataGridViewTextBoxColumn.DataPropertyName = "RI_ID";
            this.rIIDDataGridViewTextBoxColumn.HeaderText = "STT";
            this.rIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIIDDataGridViewTextBoxColumn.Name = "rIIDDataGridViewTextBoxColumn";
            this.rIIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rAWIDDataGridViewTextBoxColumn
            // 
            this.rAWIDDataGridViewTextBoxColumn.DataPropertyName = "RAW_ID";
            this.rAWIDDataGridViewTextBoxColumn.HeaderText = "Mã phiếu hàng";
            this.rAWIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rAWIDDataGridViewTextBoxColumn.Name = "rAWIDDataGridViewTextBoxColumn";
            this.rAWIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rINAMEDataGridViewTextBoxColumn
            // 
            this.rINAMEDataGridViewTextBoxColumn.DataPropertyName = "RI_NAME";
            this.rINAMEDataGridViewTextBoxColumn.HeaderText = "Tên nguyên liệu";
            this.rINAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rINAMEDataGridViewTextBoxColumn.Name = "rINAMEDataGridViewTextBoxColumn";
            this.rINAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rIQUANTITYDataGridViewTextBoxColumn
            // 
            this.rIQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "RI_QUANTITY";
            this.rIQUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.rIQUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIQUANTITYDataGridViewTextBoxColumn.Name = "rIQUANTITYDataGridViewTextBoxColumn";
            this.rIQUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // rIPRICEDataGridViewTextBoxColumn
            // 
            this.rIPRICEDataGridViewTextBoxColumn.DataPropertyName = "RI_PRICE";
            this.rIPRICEDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.rIPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIPRICEDataGridViewTextBoxColumn.Name = "rIPRICEDataGridViewTextBoxColumn";
            this.rIPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rITOTALDataGridViewTextBoxColumn
            // 
            this.rITOTALDataGridViewTextBoxColumn.DataPropertyName = "RI_TOTAL";
            this.rITOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.rITOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rITOTALDataGridViewTextBoxColumn.Name = "rITOTALDataGridViewTextBoxColumn";
            this.rITOTALDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmRawInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 617);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRawInfo";
            this.Text = "FrmRawInfo";
            this.Load += new System.EventHandler(this.FrmRawInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAWINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RawInfo rawInfo;
        private System.Windows.Forms.BindingSource rAWINFOBindingSource;
        private RawInfoTableAdapters.RAWINFOTableAdapter rAWINFOTableAdapter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rINAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rITOTALDataGridViewTextBoxColumn;
    }
}