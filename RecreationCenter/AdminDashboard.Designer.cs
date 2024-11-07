namespace RecreationCenter
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogout = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ticket = new System.Windows.Forms.TabPage();
            this.adminTicketView = new System.Windows.Forms.DataGridView();
            this.adminViewTicket = new System.Windows.Forms.TextBox();
            this.adminViewTicketBtn = new System.Windows.Forms.Button();
            this.tickeRateFormClear = new System.Windows.Forms.Button();
            this.adminComboBox = new System.Windows.Forms.ComboBox();
            this.addTicketBtn = new System.Windows.Forms.Button();
            this.wholePricetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price4txt = new System.Windows.Forms.TextBox();
            this.price3txt = new System.Windows.Forms.TextBox();
            this.price2txt = new System.Windows.Forms.TextBox();
            this.price1txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dailyReport = new System.Windows.Forms.TabPage();
            this.adminViewReport1 = new System.Windows.Forms.Button();
            this.adminDailyReportViewTxt1 = new System.Windows.Forms.TextBox();
            this.adminDailyReportView = new System.Windows.Forms.DataGridView();
            this.adminGenerateReport1 = new System.Windows.Forms.Button();
            this.dateTimePickerAdmin1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.weeklyReport = new System.Windows.Forms.TabPage();
            this.adminSortOption = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.adminGenerateChart = new System.Windows.Forms.Button();
            this.adminViewReport2 = new System.Windows.Forms.Button();
            this.adminViewReportTxt2 = new System.Windows.Forms.TextBox();
            this.adminWeeklyReportView = new System.Windows.Forms.DataGridView();
            this.adminGenerateReport2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminTicketView)).BeginInit();
            this.dailyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDailyReportView)).BeginInit();
            this.weeklyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminWeeklyReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // adminLogout
            // 
            this.adminLogout.Location = new System.Drawing.Point(926, 34);
            this.adminLogout.Margin = new System.Windows.Forms.Padding(5);
            this.adminLogout.Name = "adminLogout";
            this.adminLogout.Size = new System.Drawing.Size(125, 35);
            this.adminLogout.TabIndex = 1;
            this.adminLogout.Text = "Log out";
            this.adminLogout.UseVisualStyleBackColor = true;
            this.adminLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ticket);
            this.tabControl1.Controls.Add(this.dailyReport);
            this.tabControl1.Controls.Add(this.weeklyReport);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(45, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 709);
            this.tabControl1.TabIndex = 23;
            // 
            // ticket
            // 
            this.ticket.Controls.Add(this.adminTicketView);
            this.ticket.Controls.Add(this.adminViewTicket);
            this.ticket.Controls.Add(this.adminViewTicketBtn);
            this.ticket.Controls.Add(this.tickeRateFormClear);
            this.ticket.Controls.Add(this.adminComboBox);
            this.ticket.Controls.Add(this.addTicketBtn);
            this.ticket.Controls.Add(this.wholePricetxt);
            this.ticket.Controls.Add(this.label8);
            this.ticket.Controls.Add(this.label7);
            this.ticket.Controls.Add(this.price4txt);
            this.ticket.Controls.Add(this.price3txt);
            this.ticket.Controls.Add(this.price2txt);
            this.ticket.Controls.Add(this.price1txt);
            this.ticket.Controls.Add(this.label6);
            this.ticket.Controls.Add(this.label5);
            this.ticket.Controls.Add(this.label4);
            this.ticket.Controls.Add(this.label3);
            this.ticket.Controls.Add(this.label2);
            this.ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket.Location = new System.Drawing.Point(4, 22);
            this.ticket.Name = "ticket";
            this.ticket.Padding = new System.Windows.Forms.Padding(3);
            this.ticket.Size = new System.Drawing.Size(998, 683);
            this.ticket.TabIndex = 0;
            this.ticket.Text = "Ticket";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // adminTicketView
            // 
            this.adminTicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminTicketView.Location = new System.Drawing.Point(433, 31);
            this.adminTicketView.Name = "adminTicketView";
            this.adminTicketView.Size = new System.Drawing.Size(535, 352);
            this.adminTicketView.TabIndex = 40;
            // 
            // adminViewTicket
            // 
            this.adminViewTicket.Location = new System.Drawing.Point(433, 432);
            this.adminViewTicket.Name = "adminViewTicket";
            this.adminViewTicket.Size = new System.Drawing.Size(349, 26);
            this.adminViewTicket.TabIndex = 39;
            // 
            // adminViewTicketBtn
            // 
            this.adminViewTicketBtn.Location = new System.Drawing.Point(821, 431);
            this.adminViewTicketBtn.Name = "adminViewTicketBtn";
            this.adminViewTicketBtn.Size = new System.Drawing.Size(147, 31);
            this.adminViewTicketBtn.TabIndex = 38;
            this.adminViewTicketBtn.Text = "View Ticket";
            this.adminViewTicketBtn.UseVisualStyleBackColor = true;
            this.adminViewTicketBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tickeRateFormClear
            // 
            this.tickeRateFormClear.Location = new System.Drawing.Point(238, 431);
            this.tickeRateFormClear.Name = "tickeRateFormClear";
            this.tickeRateFormClear.Size = new System.Drawing.Size(95, 31);
            this.tickeRateFormClear.TabIndex = 37;
            this.tickeRateFormClear.Text = "Clear";
            this.tickeRateFormClear.UseVisualStyleBackColor = true;
            this.tickeRateFormClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // adminComboBox
            // 
            this.adminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminComboBox.FormattingEnabled = true;
            this.adminComboBox.Items.AddRange(new object[] {
            "Child (5-12)",
            "Adult > 12",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.adminComboBox.Location = new System.Drawing.Point(171, 31);
            this.adminComboBox.Name = "adminComboBox";
            this.adminComboBox.Size = new System.Drawing.Size(162, 28);
            this.adminComboBox.TabIndex = 36;
            this.adminComboBox.SelectedIndexChanged += new System.EventHandler(this.adminComboBox_SelectedIndexChanged);
            // 
            // addTicketBtn
            // 
            this.addTicketBtn.Location = new System.Drawing.Point(32, 431);
            this.addTicketBtn.Name = "addTicketBtn";
            this.addTicketBtn.Size = new System.Drawing.Size(135, 31);
            this.addTicketBtn.TabIndex = 35;
            this.addTicketBtn.Text = "Add Ticket";
            this.addTicketBtn.UseVisualStyleBackColor = true;
            this.addTicketBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // wholePricetxt
            // 
            this.wholePricetxt.Location = new System.Drawing.Point(212, 358);
            this.wholePricetxt.Name = "wholePricetxt";
            this.wholePricetxt.Size = new System.Drawing.Size(121, 26);
            this.wholePricetxt.TabIndex = 34;
            this.wholePricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ticket Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Price for whole day";
            // 
            // price4txt
            // 
            this.price4txt.Location = new System.Drawing.Point(212, 311);
            this.price4txt.Name = "price4txt";
            this.price4txt.Size = new System.Drawing.Size(121, 26);
            this.price4txt.TabIndex = 31;
            this.price4txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            this.price4txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // price3txt
            // 
            this.price3txt.Location = new System.Drawing.Point(212, 266);
            this.price3txt.Name = "price3txt";
            this.price3txt.Size = new System.Drawing.Size(121, 26);
            this.price3txt.TabIndex = 30;
            this.price3txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // price2txt
            // 
            this.price2txt.Location = new System.Drawing.Point(213, 217);
            this.price2txt.Name = "price2txt";
            this.price2txt.Size = new System.Drawing.Size(121, 26);
            this.price2txt.TabIndex = 29;
            this.price2txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.price2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // price1txt
            // 
            this.price1txt.Location = new System.Drawing.Point(213, 167);
            this.price1txt.Name = "price1txt";
            this.price1txt.Size = new System.Drawing.Size(121, 26);
            this.price1txt.TabIndex = 28;
            this.price1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Price for 4 hrs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price for 3 hrs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Price for 2 hrs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price for 1 hr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ticket rate for";
            // 
            // dailyReport
            // 
            this.dailyReport.Controls.Add(this.adminViewReport1);
            this.dailyReport.Controls.Add(this.adminDailyReportViewTxt1);
            this.dailyReport.Controls.Add(this.adminDailyReportView);
            this.dailyReport.Controls.Add(this.adminGenerateReport1);
            this.dailyReport.Controls.Add(this.dateTimePickerAdmin1);
            this.dailyReport.Controls.Add(this.label14);
            this.dailyReport.Location = new System.Drawing.Point(4, 22);
            this.dailyReport.Name = "dailyReport";
            this.dailyReport.Padding = new System.Windows.Forms.Padding(3);
            this.dailyReport.Size = new System.Drawing.Size(998, 683);
            this.dailyReport.TabIndex = 1;
            this.dailyReport.Text = "Daily Report";
            this.dailyReport.UseVisualStyleBackColor = true;
            // 
            // adminViewReport1
            // 
            this.adminViewReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminViewReport1.Location = new System.Drawing.Point(714, 80);
            this.adminViewReport1.Name = "adminViewReport1";
            this.adminViewReport1.Size = new System.Drawing.Size(170, 29);
            this.adminViewReport1.TabIndex = 11;
            this.adminViewReport1.Text = "View Report";
            this.adminViewReport1.UseVisualStyleBackColor = true;
            this.adminViewReport1.Click += new System.EventHandler(this.button10_Click);
            // 
            // adminDailyReportViewTxt1
            // 
            this.adminDailyReportViewTxt1.Location = new System.Drawing.Point(75, 85);
            this.adminDailyReportViewTxt1.Name = "adminDailyReportViewTxt1";
            this.adminDailyReportViewTxt1.Size = new System.Drawing.Size(620, 20);
            this.adminDailyReportViewTxt1.TabIndex = 10;
            // 
            // adminDailyReportView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDailyReportView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminDailyReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminDailyReportView.DefaultCellStyle = dataGridViewCellStyle2;
            this.adminDailyReportView.Location = new System.Drawing.Point(75, 126);
            this.adminDailyReportView.Name = "adminDailyReportView";
            this.adminDailyReportView.Size = new System.Drawing.Size(836, 511);
            this.adminDailyReportView.TabIndex = 9;
            this.adminDailyReportView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // adminGenerateReport1
            // 
            this.adminGenerateReport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGenerateReport1.Location = new System.Drawing.Point(714, 28);
            this.adminGenerateReport1.Name = "adminGenerateReport1";
            this.adminGenerateReport1.Size = new System.Drawing.Size(170, 29);
            this.adminGenerateReport1.TabIndex = 8;
            this.adminGenerateReport1.Text = "Generate Report";
            this.adminGenerateReport1.UseVisualStyleBackColor = true;
            this.adminGenerateReport1.Click += new System.EventHandler(this.button6_Click);
            // 
            // dateTimePickerAdmin1
            // 
            this.dateTimePickerAdmin1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmin1.Location = new System.Drawing.Point(139, 34);
            this.dateTimePickerAdmin1.Name = "dateTimePickerAdmin1";
            this.dateTimePickerAdmin1.ShowUpDown = true;
            this.dateTimePickerAdmin1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAdmin1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Date";
            // 
            // weeklyReport
            // 
            this.weeklyReport.Controls.Add(this.adminSortOption);
            this.weeklyReport.Controls.Add(this.chart2);
            this.weeklyReport.Controls.Add(this.chart1);
            this.weeklyReport.Controls.Add(this.adminGenerateChart);
            this.weeklyReport.Controls.Add(this.adminViewReport2);
            this.weeklyReport.Controls.Add(this.adminViewReportTxt2);
            this.weeklyReport.Controls.Add(this.adminWeeklyReportView);
            this.weeklyReport.Controls.Add(this.adminGenerateReport2);
            this.weeklyReport.Controls.Add(this.label15);
            this.weeklyReport.Location = new System.Drawing.Point(4, 22);
            this.weeklyReport.Name = "weeklyReport";
            this.weeklyReport.Size = new System.Drawing.Size(998, 683);
            this.weeklyReport.TabIndex = 2;
            this.weeklyReport.Text = "Weekly Report";
            this.weeklyReport.UseVisualStyleBackColor = true;
            // 
            // adminSortOption
            // 
            this.adminSortOption.FormattingEnabled = true;
            this.adminSortOption.Items.AddRange(new object[] {
            "visitor",
            "earning"});
            this.adminSortOption.Location = new System.Drawing.Point(187, 22);
            this.adminSortOption.Name = "adminSortOption";
            this.adminSortOption.Size = new System.Drawing.Size(121, 21);
            this.adminSortOption.TabIndex = 37;
            this.adminSortOption.SelectedIndexChanged += new System.EventHandler(this.sortOption_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(569, 359);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "earning";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 36;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(148, 359);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "no_of_visitor";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // adminGenerateChart
            // 
            this.adminGenerateChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGenerateChart.Location = new System.Drawing.Point(399, 303);
            this.adminGenerateChart.Name = "adminGenerateChart";
            this.adminGenerateChart.Size = new System.Drawing.Size(170, 29);
            this.adminGenerateChart.TabIndex = 34;
            this.adminGenerateChart.Text = "Generate Chart";
            this.adminGenerateChart.UseVisualStyleBackColor = true;
            this.adminGenerateChart.Click += new System.EventHandler(this.button9_Click);
            // 
            // adminViewReport2
            // 
            this.adminViewReport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminViewReport2.Location = new System.Drawing.Point(814, 245);
            this.adminViewReport2.Name = "adminViewReport2";
            this.adminViewReport2.Size = new System.Drawing.Size(103, 31);
            this.adminViewReport2.TabIndex = 33;
            this.adminViewReport2.Text = "View";
            this.adminViewReport2.UseVisualStyleBackColor = true;
            this.adminViewReport2.Click += new System.EventHandler(this.button8_Click);
            // 
            // adminViewReportTxt2
            // 
            this.adminViewReportTxt2.Location = new System.Drawing.Point(81, 245);
            this.adminViewReportTxt2.Name = "adminViewReportTxt2";
            this.adminViewReportTxt2.Size = new System.Drawing.Size(701, 20);
            this.adminViewReportTxt2.TabIndex = 32;
            // 
            // adminWeeklyReportView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminWeeklyReportView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adminWeeklyReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminWeeklyReportView.DefaultCellStyle = dataGridViewCellStyle4;
            this.adminWeeklyReportView.Location = new System.Drawing.Point(81, 62);
            this.adminWeeklyReportView.Name = "adminWeeklyReportView";
            this.adminWeeklyReportView.Size = new System.Drawing.Size(836, 161);
            this.adminWeeklyReportView.TabIndex = 31;
            // 
            // adminGenerateReport2
            // 
            this.adminGenerateReport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGenerateReport2.Location = new System.Drawing.Point(727, 17);
            this.adminGenerateReport2.Name = "adminGenerateReport2";
            this.adminGenerateReport2.Size = new System.Drawing.Size(170, 29);
            this.adminGenerateReport2.TabIndex = 30;
            this.adminGenerateReport2.Text = "Generate Report";
            this.adminGenerateReport2.UseVisualStyleBackColor = true;
            this.adminGenerateReport2.Click += new System.EventHandler(this.button7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = "Sort By :";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 829);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.adminLogout);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.tabControl1.ResumeLayout(false);
            this.ticket.ResumeLayout(false);
            this.ticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminTicketView)).EndInit();
            this.dailyReport.ResumeLayout(false);
            this.dailyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDailyReportView)).EndInit();
            this.weeklyReport.ResumeLayout(false);
            this.weeklyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminWeeklyReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminLogout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ticket;
        private System.Windows.Forms.DataGridView adminTicketView;
        private System.Windows.Forms.TextBox adminViewTicket;
        private System.Windows.Forms.Button adminViewTicketBtn;
        private System.Windows.Forms.Button tickeRateFormClear;
        private System.Windows.Forms.ComboBox adminComboBox;
        private System.Windows.Forms.Button addTicketBtn;
        private System.Windows.Forms.TextBox wholePricetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price4txt;
        private System.Windows.Forms.TextBox price3txt;
        private System.Windows.Forms.TextBox price2txt;
        private System.Windows.Forms.TextBox price1txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dailyReport;
        private System.Windows.Forms.TabPage weeklyReport;
        private System.Windows.Forms.Button adminViewReport1;
        private System.Windows.Forms.TextBox adminDailyReportViewTxt1;
        private System.Windows.Forms.DataGridView adminDailyReportView;
        private System.Windows.Forms.Button adminGenerateReport1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmin1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox adminSortOption;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button adminGenerateChart;
        private System.Windows.Forms.Button adminViewReport2;
        private System.Windows.Forms.TextBox adminViewReportTxt2;
        private System.Windows.Forms.DataGridView adminWeeklyReportView;
        private System.Windows.Forms.Button adminGenerateReport2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}