namespace Supermarket
{
    partial class Supplier
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
            this.reload = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sup = new Supermarket.Sup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sUPPLIERTableAdapter = new Supermarket.SupTableAdapters.SUPPLIERTableAdapter();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reload)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).BeginInit();
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
            this.panel8.Controls.Add(this.reload);
            this.panel8.Controls.Add(this.change);
            this.panel8.Location = new System.Drawing.Point(656, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(521, 95);
            this.panel8.TabIndex = 50;
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
            this.panel2.Location = new System.Drawing.Point(23, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 95);
            this.panel2.TabIndex = 49;
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
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà cung cấp";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView);
            this.panel9.Location = new System.Drawing.Point(23, 219);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1154, 557);
            this.panel9.TabIndex = 51;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.sADDRESSDataGridViewTextBoxColumn,
            this.sPHONEDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sUPPLIERBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1154, 557);
            this.dataGridView.TabIndex = 0;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.sIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "S_NAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "Tên nhà cung cấp";
            this.sNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            this.sNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sADDRESSDataGridViewTextBoxColumn
            // 
            this.sADDRESSDataGridViewTextBoxColumn.DataPropertyName = "S_ADDRESS";
            this.sADDRESSDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.sADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sADDRESSDataGridViewTextBoxColumn.Name = "sADDRESSDataGridViewTextBoxColumn";
            this.sADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPHONEDataGridViewTextBoxColumn
            // 
            this.sPHONEDataGridViewTextBoxColumn.DataPropertyName = "S_PHONE";
            this.sPHONEDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPHONEDataGridViewTextBoxColumn.Name = "sPHONEDataGridViewTextBoxColumn";
            this.sPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.sup;
            // 
            // sup
            // 
            this.sup.DataSetName = "Sup";
            this.sup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 45);
            this.panel1.TabIndex = 48;
            // 
            // sUPPLIERTableAdapter
            // 
            this.sUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sup)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private Sup sup;
        private SupTableAdapters.SUPPLIERTableAdapter sUPPLIERTableAdapter;
    }
}
