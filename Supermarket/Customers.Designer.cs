namespace Supermarket
{
    partial class Customers
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
            this.cUSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUS = new Supermarket.CUS();
            this.cUSTOMERTableAdapter = new Supermarket.CUSTableAdapters.CUSTOMERTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.reload = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.PictureBox();
            this.id_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUS)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSIDDataGridViewTextBoxColumn,
            this.cUSNAMEDataGridViewTextBoxColumn,
            this.cUSPHONEDataGridViewTextBoxColumn,
            this.cUSADDRESSDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(37, 190);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1132, 580);
            this.dataGridView.TabIndex = 22;
            // 
            // cUSIDDataGridViewTextBoxColumn
            // 
            this.cUSIDDataGridViewTextBoxColumn.DataPropertyName = "CUS_ID";
            this.cUSIDDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.cUSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSIDDataGridViewTextBoxColumn.Name = "cUSIDDataGridViewTextBoxColumn";
            this.cUSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSNAMEDataGridViewTextBoxColumn
            // 
            this.cUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUS_NAME";
            this.cUSNAMEDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.cUSNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSNAMEDataGridViewTextBoxColumn.Name = "cUSNAMEDataGridViewTextBoxColumn";
            this.cUSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSPHONEDataGridViewTextBoxColumn
            // 
            this.cUSPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUS_PHONE";
            this.cUSPHONEDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.cUSPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSPHONEDataGridViewTextBoxColumn.Name = "cUSPHONEDataGridViewTextBoxColumn";
            this.cUSPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSPHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUS_ADDRESS";
            this.cUSADDRESSDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.cUSADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSADDRESSDataGridViewTextBoxColumn.Name = "cUSADDRESSDataGridViewTextBoxColumn";
            this.cUSADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.cUS;
            // 
            // cUS
            // 
            this.cUS.DataSetName = "CUS";
            this.cUS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.reload);
            this.panel8.Controls.Add(this.change);
            this.panel8.Location = new System.Drawing.Point(659, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(529, 95);
            this.panel8.TabIndex = 52;
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
            this.change.Location = new System.Drawing.Point(276, 43);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(188, 39);
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
            this.panel2.Location = new System.Drawing.Point(29, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 95);
            this.panel2.TabIndex = 51;
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
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUS)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private CUS cUS;
        private CUSTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox reload;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.TextBox id_name;
    }
}
