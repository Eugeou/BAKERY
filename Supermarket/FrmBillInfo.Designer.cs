namespace Supermarket
{
    partial class FrmBillInfo
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
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.billInfo = new Supermarket.BillInfo();
            this.bILLINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bILLINFOTableAdapter = new Supermarket.BillInfoTableAdapters.BILLINFOTableAdapter();
            this.pROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(845, 531);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(158, 43);
            this.exit.TabIndex = 53;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 45);
            this.panel2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(40, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 442);
            this.panel1.TabIndex = 51;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROIDDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bILLINFOBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(3, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(960, 442);
            this.dataGridView.TabIndex = 0;
            // 
            // billInfo
            // 
            this.billInfo.DataSetName = "BillInfo";
            this.billInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLINFOBindingSource
            // 
            this.bILLINFOBindingSource.DataMember = "BILLINFO";
            this.bILLINFOBindingSource.DataSource = this.billInfo;
            // 
            // bILLINFOTableAdapter
            // 
            this.bILLINFOTableAdapter.ClearBeforeFill = true;
            // 
            // pROIDDataGridViewTextBoxColumn
            // 
            this.pROIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_ID";
            this.pROIDDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.pROIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROIDDataGridViewTextBoxColumn.Name = "pROIDDataGridViewTextBoxColumn";
            this.pROIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.qUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.tOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 599);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBillInfo";
            this.Load += new System.EventHandler(this.FrmBillInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLINFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private BillInfo billInfo;
        private System.Windows.Forms.BindingSource bILLINFOBindingSource;
        private BillInfoTableAdapters.BILLINFOTableAdapter bILLINFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
    }
}