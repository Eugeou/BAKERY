namespace Supermarket
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTotalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbNumofOrder = new System.Windows.Forms.Label();
            this.lbNumofOrders = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotalRevenues = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbTotalProfits = new System.Windows.Forms.Label();
            this.lTotalProfit = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbProductQuantity = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbNumSupplier = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbNumCustomer = new System.Windows.Forms.Label();
            this.lbCustom = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard ";
            // 
            // chartTotalRevenue
            // 
            this.chartTotalRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.Format = "$0 VND";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartTotalRevenue.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Doanh thu";
            legend1.TitleForeColor = System.Drawing.Color.DodgerBlue;
            legend1.TitleSeparatorColor = System.Drawing.Color.Bisque;
            this.chartTotalRevenue.Legends.Add(legend1);
            this.chartTotalRevenue.Location = new System.Drawing.Point(25, 201);
            this.chartTotalRevenue.Name = "chartTotalRevenue";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.LegendText = "Theo thời gian";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chartTotalRevenue.Series.Add(series1);
            this.chartTotalRevenue.Size = new System.Drawing.Size(731, 300);
            this.chartTotalRevenue.TabIndex = 9;
            this.chartTotalRevenue.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Tổng Doanh thu";
            this.chartTotalRevenue.Titles.Add(title1);
            this.chartTotalRevenue.Click += new System.EventHandler(this.chartTotalRevenue_Click);
            // 
            // chartTop5
            // 
            this.chartTop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.BorderColor = System.Drawing.Color.Bisque;
            chartArea2.Name = "ChartArea1";
            this.chartTop5.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartTop5.Legends.Add(legend2);
            this.chartTop5.Location = new System.Drawing.Point(775, 202);
            this.chartTop5.Name = "chartTop5";
            this.chartTop5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTop5.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTop5.Series.Add(series2);
            this.chartTop5.Size = new System.Drawing.Size(375, 546);
            this.chartTop5.TabIndex = 10;
            this.chartTop5.Text = "Top 5 món ăn bán chạy ";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Top 5 món bán chạy nhất";
            this.chartTop5.Titles.Add(title2);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd,MMM,yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(220, 31);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(119, 22);
            this.dtpStartDate.TabIndex = 12;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd,MMM,yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(359, 32);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 22);
            this.dtpEndDate.TabIndex = 13;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(1021, 29);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 36);
            this.btnThisMonth.TabIndex = 14;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLastMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLastMonth.Location = new System.Drawing.Point(911, 29);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(111, 36);
            this.btnLastMonth.TabIndex = 15;
            this.btnLastMonth.Text = "Tháng trước";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastWeek.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLastWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLastWeek.Location = new System.Drawing.Point(802, 29);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(110, 36);
            this.btnLastWeek.TabIndex = 16;
            this.btnLastWeek.Text = "Tuần trước";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(697, 29);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(106, 36);
            this.btnToday.TabIndex = 17;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(577, 29);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(121, 36);
            this.btnCustomDate.TabIndex = 18;
            this.btnCustomDate.Text = "Tùy chỉnh";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbNumofOrder);
            this.panel2.Controls.Add(this.lbNumofOrders);
            this.panel2.Location = new System.Drawing.Point(25, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 93);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Supermarket.Properties.Resources.invoices;
            this.pictureBox2.Location = new System.Drawing.Point(8, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 76);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // lbNumofOrder
            // 
            this.lbNumofOrder.AutoSize = true;
            this.lbNumofOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbNumofOrder.Location = new System.Drawing.Point(102, 50);
            this.lbNumofOrder.Name = "lbNumofOrder";
            this.lbNumofOrder.Size = new System.Drawing.Size(67, 28);
            this.lbNumofOrder.TabIndex = 1;
            this.lbNumofOrder.Text = "00000";
            // 
            // lbNumofOrders
            // 
            this.lbNumofOrders.AutoSize = true;
            this.lbNumofOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbNumofOrders.Location = new System.Drawing.Point(94, 17);
            this.lbNumofOrders.Name = "lbNumofOrders";
            this.lbNumofOrders.Size = new System.Drawing.Size(168, 25);
            this.lbNumofOrders.TabIndex = 0;
            this.lbNumofOrders.Text = "Số đơn trong ngày";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbTotalRevenues);
            this.panel3.Controls.Add(this.lbTotalRevenue);
            this.panel3.Location = new System.Drawing.Point(400, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 93);
            this.panel3.TabIndex = 21;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Supermarket.Properties.Resources.profit;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 76);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotalRevenues
            // 
            this.lbTotalRevenues.AutoSize = true;
            this.lbTotalRevenues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbTotalRevenues.Location = new System.Drawing.Point(102, 50);
            this.lbTotalRevenues.Name = "lbTotalRevenues";
            this.lbTotalRevenues.Size = new System.Drawing.Size(67, 28);
            this.lbTotalRevenues.TabIndex = 1;
            this.lbTotalRevenues.Text = "00000";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTotalRevenue.Location = new System.Drawing.Point(90, 17);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(147, 25);
            this.lbTotalRevenue.TabIndex = 0;
            this.lbTotalRevenue.Text = "Tổng Doanh thu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lbTotalProfits);
            this.panel4.Controls.Add(this.lTotalProfit);
            this.panel4.Location = new System.Drawing.Point(776, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 93);
            this.panel4.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Supermarket.Properties.Resources.bar_charts;
            this.pictureBox3.Location = new System.Drawing.Point(11, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 76);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // lbTotalProfits
            // 
            this.lbTotalProfits.AutoSize = true;
            this.lbTotalProfits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbTotalProfits.Location = new System.Drawing.Point(130, 50);
            this.lbTotalProfits.Name = "lbTotalProfits";
            this.lbTotalProfits.Size = new System.Drawing.Size(67, 28);
            this.lbTotalProfits.TabIndex = 1;
            this.lbTotalProfits.Text = "00000";
            this.lbTotalProfits.Click += new System.EventHandler(this.lbTotalProfits_Click);
            // 
            // lTotalProfit
            // 
            this.lTotalProfit.AutoSize = true;
            this.lTotalProfit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lTotalProfit.Location = new System.Drawing.Point(117, 17);
            this.lTotalProfit.Name = "lTotalProfit";
            this.lTotalProfit.Size = new System.Drawing.Size(142, 25);
            this.lTotalProfit.TabIndex = 0;
            this.lTotalProfit.Text = "Tổng Lợi nhuận";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lbProductQuantity);
            this.panel5.Controls.Add(this.lbProducts);
            this.panel5.Controls.Add(this.lbNumSupplier);
            this.panel5.Controls.Add(this.lbSupplier);
            this.panel5.Controls.Add(this.lbNumCustomer);
            this.panel5.Controls.Add(this.lbCustom);
            this.panel5.Location = new System.Drawing.Point(24, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 230);
            this.panel5.TabIndex = 23;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Supermarket.Properties.Resources.inventories;
            this.pictureBox6.Location = new System.Drawing.Point(9, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Supermarket.Properties.Resources.procurements;
            this.pictureBox5.Location = new System.Drawing.Point(9, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Supermarket.Properties.Resources.users;
            this.pictureBox4.Location = new System.Drawing.Point(9, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Counter";
            // 
            // lbProductQuantity
            // 
            this.lbProductQuantity.AutoSize = true;
            this.lbProductQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.lbProductQuantity.Location = new System.Drawing.Point(64, 189);
            this.lbProductQuantity.Name = "lbProductQuantity";
            this.lbProductQuantity.Size = new System.Drawing.Size(55, 23);
            this.lbProductQuantity.TabIndex = 5;
            this.lbProductQuantity.Text = "00000";
            this.lbProductQuantity.Click += new System.EventHandler(this.lbProductQuantity_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbProducts.Location = new System.Drawing.Point(63, 162);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(173, 25);
            this.lbProducts.TabIndex = 4;
            this.lbProducts.Text = "Số lượng Sản phẩm";
            // 
            // lbNumSupplier
            // 
            this.lbNumSupplier.AutoSize = true;
            this.lbNumSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.lbNumSupplier.Location = new System.Drawing.Point(64, 126);
            this.lbNumSupplier.Name = "lbNumSupplier";
            this.lbNumSupplier.Size = new System.Drawing.Size(55, 23);
            this.lbNumSupplier.TabIndex = 3;
            this.lbNumSupplier.Text = "00000";
            // 
            // lbSupplier
            // 
            this.lbSupplier.AutoSize = true;
            this.lbSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbSupplier.Location = new System.Drawing.Point(63, 99);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(147, 25);
            this.lbSupplier.TabIndex = 2;
            this.lbSupplier.Text = "Số nhà cung cấp";
            // 
            // lbNumCustomer
            // 
            this.lbNumCustomer.AutoSize = true;
            this.lbNumCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.lbNumCustomer.Location = new System.Drawing.Point(64, 65);
            this.lbNumCustomer.Name = "lbNumCustomer";
            this.lbNumCustomer.Size = new System.Drawing.Size(55, 23);
            this.lbNumCustomer.TabIndex = 1;
            this.lbNumCustomer.Text = "00000";
            // 
            // lbCustom
            // 
            this.lbCustom.AutoSize = true;
            this.lbCustom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbCustom.Location = new System.Drawing.Point(64, 41);
            this.lbCustom.Name = "lbCustom";
            this.lbCustom.Size = new System.Drawing.Size(167, 23);
            this.lbCustom.TabIndex = 0;
            this.lbCustom.Text = "Tổng số Khách hàng";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel6.Controls.Add(this.dgvStock);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(316, 522);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 230);
            this.panel6.TabIndex = 24;
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(95)))));
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(137)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(132)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(129)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(134)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(16, 33);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 35;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(408, 179);
            this.dgvStock.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label13.Location = new System.Drawing.Point(18, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Hàng hóa dự trữ";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = global::Supermarket.Properties.Resources._checked;
            this.btnOk.Location = new System.Drawing.Point(503, 29);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 36);
            this.btnOk.TabIndex = 19;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbStartDate
            // 
            this.lbStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbStartDate.Location = new System.Drawing.Point(216, 29);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(124, 30);
            this.lbStartDate.TabIndex = 26;
            this.lbStartDate.Text = "15 Dec 2022";
            this.lbStartDate.Click += new System.EventHandler(this.lbStartDate_Click);
            // 
            // lbEndDate
            // 
            this.lbEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.lbEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbEndDate.Location = new System.Drawing.Point(355, 29);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(124, 30);
            this.lbEndDate.TabIndex = 27;
            this.lbEndDate.Text = "15 Dec 2022";
            this.lbEndDate.Click += new System.EventHandler(this.lbEndDate_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.chartTop5);
            this.Controls.Add(this.chartTotalRevenue);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1194, 764);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNumofOrder;
        private System.Windows.Forms.Label lbNumofOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotalRevenues;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTotalProfits;
        private System.Windows.Forms.Label lTotalProfit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbProductQuantity;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.Label lbNumSupplier;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label lbNumCustomer;
        private System.Windows.Forms.Label lbCustom;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
    }
}
