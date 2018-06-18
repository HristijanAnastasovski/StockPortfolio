namespace StockPortfolio
{
    partial class Search_Result_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Result_Form));
            this.BTN_Close_Search = new System.Windows.Forms.Button();
            this.TB_Search_Again = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BTN_Search_Again = new System.Windows.Forms.Button();
            this.LB_Company = new System.Windows.Forms.Label();
            this.LBL_Company_Name = new System.Windows.Forms.Label();
            this.LB_Company_Sector = new System.Windows.Forms.Label();
            this.LBL_Company_Sector = new System.Windows.Forms.Label();
            this.LB_Company_Primary_Market = new System.Windows.Forms.Label();
            this.LBL_Company_market = new System.Windows.Forms.Label();
            this.LB_Company_Open = new System.Windows.Forms.Label();
            this.LB_Company_Current_Price = new System.Windows.Forms.Label();
            this.LBL_Company_Opening_price = new System.Windows.Forms.Label();
            this.LBL_Company_Current_Price = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LB_Company_CEO = new System.Windows.Forms.Label();
            this.LB_Company_Website = new System.Windows.Forms.Label();
            this.LBL_Company_CEO = new System.Windows.Forms.Label();
            this.LBL_LINK = new System.Windows.Forms.LinkLabel();
            this.ErrorProvider_Search_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.SearchAgain = new System.Windows.Forms.GroupBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stocksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbDayRange = new System.Windows.Forms.Label();
            this.lbWeekRange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPeRatio = new System.Windows.Forms.Label();
            this.LB_DAY_RANGE = new System.Windows.Forms.Label();
            this.LB_WEEK_RANGE = new System.Windows.Forms.Label();
            this.LB_PE_RATIO = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.LB_REV_PER_EMPLOYEE = new System.Windows.Forms.Label();
            this.LB_REVENUE = new System.Windows.Forms.Label();
            this.LB_MARKETCAP = new System.Windows.Forms.Label();
            this.LB_BETA = new System.Windows.Forms.Label();
            this.LB_DESCRIPTION = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).BeginInit();
            this.SearchAgain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Close_Search
            // 
            this.BTN_Close_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close_Search.Location = new System.Drawing.Point(925, 573);
            this.BTN_Close_Search.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Close_Search.Name = "BTN_Close_Search";
            this.BTN_Close_Search.Size = new System.Drawing.Size(151, 39);
            this.BTN_Close_Search.TabIndex = 0;
            this.BTN_Close_Search.Text = "Close";
            this.BTN_Close_Search.UseVisualStyleBackColor = true;
            this.BTN_Close_Search.Click += new System.EventHandler(this.BTN_Close_Search_Click);
            // 
            // TB_Search_Again
            // 
            this.TB_Search_Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search_Again.Location = new System.Drawing.Point(7, 37);
            this.TB_Search_Again.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Search_Again.MaxLength = 1000;
            this.TB_Search_Again.Name = "TB_Search_Again";
            this.TB_Search_Again.Size = new System.Drawing.Size(209, 21);
            this.TB_Search_Again.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 627);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // BTN_Search_Again
            // 
            this.BTN_Search_Again.Location = new System.Drawing.Point(242, 33);
            this.BTN_Search_Again.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Search_Again.Name = "BTN_Search_Again";
            this.BTN_Search_Again.Size = new System.Drawing.Size(76, 30);
            this.BTN_Search_Again.TabIndex = 3;
            this.BTN_Search_Again.Text = "Search";
            this.BTN_Search_Again.UseVisualStyleBackColor = true;
            this.BTN_Search_Again.Click += new System.EventHandler(this.BTN_Search_Again_Click);
            // 
            // LB_Company
            // 
            this.LB_Company.AutoSize = true;
            this.LB_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company.Location = new System.Drawing.Point(16, 19);
            this.LB_Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company.Name = "LB_Company";
            this.LB_Company.Size = new System.Drawing.Size(77, 16);
            this.LB_Company.TabIndex = 4;
            this.LB_Company.Text = "Company:";
            // 
            // LBL_Company_Name
            // 
            this.LBL_Company_Name.AutoEllipsis = true;
            this.LBL_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Name.Location = new System.Drawing.Point(145, 19);
            this.LBL_Company_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Name.Name = "LBL_Company_Name";
            this.LBL_Company_Name.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_Name.TabIndex = 5;
            this.LBL_Company_Name.Text = "***";
            // 
            // LB_Company_Sector
            // 
            this.LB_Company_Sector.AutoSize = true;
            this.LB_Company_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Sector.Location = new System.Drawing.Point(16, 132);
            this.LB_Company_Sector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Sector.Name = "LB_Company_Sector";
            this.LB_Company_Sector.Size = new System.Drawing.Size(57, 16);
            this.LB_Company_Sector.TabIndex = 6;
            this.LB_Company_Sector.Text = "Sector:";
            // 
            // LBL_Company_Sector
            // 
            this.LBL_Company_Sector.AutoEllipsis = true;
            this.LBL_Company_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Sector.Location = new System.Drawing.Point(145, 132);
            this.LBL_Company_Sector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Sector.Name = "LBL_Company_Sector";
            this.LBL_Company_Sector.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_Sector.TabIndex = 7;
            this.LBL_Company_Sector.Text = "***";
            // 
            // LB_Company_Primary_Market
            // 
            this.LB_Company_Primary_Market.AutoSize = true;
            this.LB_Company_Primary_Market.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Primary_Market.Location = new System.Drawing.Point(16, 168);
            this.LB_Company_Primary_Market.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Primary_Market.Name = "LB_Company_Primary_Market";
            this.LB_Company_Primary_Market.Size = new System.Drawing.Size(116, 16);
            this.LB_Company_Primary_Market.TabIndex = 8;
            this.LB_Company_Primary_Market.Text = "Primary market:";
            // 
            // LBL_Company_market
            // 
            this.LBL_Company_market.AutoEllipsis = true;
            this.LBL_Company_market.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_market.Location = new System.Drawing.Point(145, 168);
            this.LBL_Company_market.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_market.Name = "LBL_Company_market";
            this.LBL_Company_market.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_market.TabIndex = 9;
            this.LBL_Company_market.Text = "***";
            // 
            // LB_Company_Open
            // 
            this.LB_Company_Open.AutoSize = true;
            this.LB_Company_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Open.Location = new System.Drawing.Point(16, 212);
            this.LB_Company_Open.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Open.Name = "LB_Company_Open";
            this.LB_Company_Open.Size = new System.Drawing.Size(109, 16);
            this.LB_Company_Open.TabIndex = 10;
            this.LB_Company_Open.Text = "Opening price:";
            // 
            // LB_Company_Current_Price
            // 
            this.LB_Company_Current_Price.AutoSize = true;
            this.LB_Company_Current_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Current_Price.Location = new System.Drawing.Point(16, 259);
            this.LB_Company_Current_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Current_Price.Name = "LB_Company_Current_Price";
            this.LB_Company_Current_Price.Size = new System.Drawing.Size(100, 16);
            this.LB_Company_Current_Price.TabIndex = 11;
            this.LB_Company_Current_Price.Text = "Current price:";
            // 
            // LBL_Company_Opening_price
            // 
            this.LBL_Company_Opening_price.AutoEllipsis = true;
            this.LBL_Company_Opening_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Opening_price.Location = new System.Drawing.Point(145, 212);
            this.LBL_Company_Opening_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Opening_price.Name = "LBL_Company_Opening_price";
            this.LBL_Company_Opening_price.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_Opening_price.TabIndex = 12;
            this.LBL_Company_Opening_price.Text = "***";
            // 
            // LBL_Company_Current_Price
            // 
            this.LBL_Company_Current_Price.AutoEllipsis = true;
            this.LBL_Company_Current_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Current_Price.Location = new System.Drawing.Point(145, 259);
            this.LBL_Company_Current_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Current_Price.Name = "LBL_Company_Current_Price";
            this.LBL_Company_Current_Price.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_Current_Price.TabIndex = 13;
            this.LBL_Company_Current_Price.Text = "***";
            // 
            // LB_Company_CEO
            // 
            this.LB_Company_CEO.AutoSize = true;
            this.LB_Company_CEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_CEO.Location = new System.Drawing.Point(16, 56);
            this.LB_Company_CEO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_CEO.Name = "LB_Company_CEO";
            this.LB_Company_CEO.Size = new System.Drawing.Size(43, 16);
            this.LB_Company_CEO.TabIndex = 15;
            this.LB_Company_CEO.Text = "CEO:";
            // 
            // LB_Company_Website
            // 
            this.LB_Company_Website.AutoSize = true;
            this.LB_Company_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Website.Location = new System.Drawing.Point(16, 92);
            this.LB_Company_Website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Website.Name = "LB_Company_Website";
            this.LB_Company_Website.Size = new System.Drawing.Size(69, 16);
            this.LB_Company_Website.TabIndex = 16;
            this.LB_Company_Website.Text = "Website:";
            // 
            // LBL_Company_CEO
            // 
            this.LBL_Company_CEO.AutoEllipsis = true;
            this.LBL_Company_CEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_CEO.Location = new System.Drawing.Point(145, 56);
            this.LBL_Company_CEO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_CEO.Name = "LBL_Company_CEO";
            this.LBL_Company_CEO.Size = new System.Drawing.Size(219, 17);
            this.LBL_Company_CEO.TabIndex = 17;
            this.LBL_Company_CEO.Text = "***";
            // 
            // LBL_LINK
            // 
            this.LBL_LINK.AutoEllipsis = true;
            this.LBL_LINK.Location = new System.Drawing.Point(145, 92);
            this.LBL_LINK.Name = "LBL_LINK";
            this.LBL_LINK.Size = new System.Drawing.Size(219, 17);
            this.LBL_LINK.TabIndex = 19;
            this.LBL_LINK.TabStop = true;
            this.LBL_LINK.Text = "linkLabel1";
            this.LBL_LINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBL_LINK_LinkClicked);
            // 
            // ErrorProvider_Search_Error
            // 
            this.ErrorProvider_Search_Error.ContainerControl = this;
            // 
            // SearchAgain
            // 
            this.SearchAgain.Controls.Add(this.TB_Search_Again);
            this.SearchAgain.Controls.Add(this.BTN_Search_Again);
            this.SearchAgain.Controls.Add(this.pbLoading);
            this.SearchAgain.Location = new System.Drawing.Point(701, 19);
            this.SearchAgain.Name = "SearchAgain";
            this.SearchAgain.Size = new System.Drawing.Size(392, 90);
            this.SearchAgain.TabIndex = 20;
            this.SearchAgain.TabStop = false;
            this.SearchAgain.Text = "Search for stocks";
            // 
            // pbLoading
            // 
            this.pbLoading.Enabled = false;
            this.pbLoading.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.pbLoading.Location = new System.Drawing.Point(325, 22);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(50, 46);
            this.pbLoading.TabIndex = 21;
            this.pbLoading.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "VALUE ($)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "TIME (LAST MONTH)";
            // 
            // stocksChart
            // 
            this.stocksChart.BackColor = System.Drawing.Color.Transparent;
            this.stocksChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.stocksChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.stocksChart.Legends.Add(legend1);
            this.stocksChart.Location = new System.Drawing.Point(106, 298);
            this.stocksChart.Name = "stocksChart";
            this.stocksChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Price";
            this.stocksChart.Series.Add(series1);
            this.stocksChart.Size = new System.Drawing.Size(754, 300);
            this.stocksChart.TabIndex = 24;
            this.stocksChart.Text = "chart1";
            this.stocksChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stocksChart_MouseMove);
            // 
            // lbDayRange
            // 
            this.lbDayRange.AutoSize = true;
            this.lbDayRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayRange.Location = new System.Drawing.Point(359, 168);
            this.lbDayRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDayRange.Name = "lbDayRange";
            this.lbDayRange.Size = new System.Drawing.Size(90, 16);
            this.lbDayRange.TabIndex = 25;
            this.lbDayRange.Text = "Day Range:";
            // 
            // lbWeekRange
            // 
            this.lbWeekRange.AutoSize = true;
            this.lbWeekRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeekRange.Location = new System.Drawing.Point(359, 212);
            this.lbWeekRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWeekRange.Name = "lbWeekRange";
            this.lbWeekRange.Size = new System.Drawing.Size(122, 16);
            this.lbWeekRange.TabIndex = 26;
            this.lbWeekRange.Text = "52 Week Range:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Market Cap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Beta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Revenue per employee:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Revenue:";
            // 
            // lbPeRatio
            // 
            this.lbPeRatio.AutoSize = true;
            this.lbPeRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeRatio.Location = new System.Drawing.Point(359, 259);
            this.lbPeRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeRatio.Name = "lbPeRatio";
            this.lbPeRatio.Size = new System.Drawing.Size(78, 16);
            this.lbPeRatio.TabIndex = 31;
            this.lbPeRatio.Text = "P/E Ratio:";
            // 
            // LB_DAY_RANGE
            // 
            this.LB_DAY_RANGE.AutoEllipsis = true;
            this.LB_DAY_RANGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DAY_RANGE.Location = new System.Drawing.Point(526, 168);
            this.LB_DAY_RANGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_DAY_RANGE.Name = "LB_DAY_RANGE";
            this.LB_DAY_RANGE.Size = new System.Drawing.Size(214, 17);
            this.LB_DAY_RANGE.TabIndex = 32;
            this.LB_DAY_RANGE.Text = "***";
            // 
            // LB_WEEK_RANGE
            // 
            this.LB_WEEK_RANGE.AutoEllipsis = true;
            this.LB_WEEK_RANGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_WEEK_RANGE.Location = new System.Drawing.Point(526, 212);
            this.LB_WEEK_RANGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_WEEK_RANGE.Name = "LB_WEEK_RANGE";
            this.LB_WEEK_RANGE.Size = new System.Drawing.Size(219, 17);
            this.LB_WEEK_RANGE.TabIndex = 33;
            this.LB_WEEK_RANGE.Text = "***";
            // 
            // LB_PE_RATIO
            // 
            this.LB_PE_RATIO.AutoEllipsis = true;
            this.LB_PE_RATIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PE_RATIO.Location = new System.Drawing.Point(526, 259);
            this.LB_PE_RATIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_PE_RATIO.Name = "LB_PE_RATIO";
            this.LB_PE_RATIO.Size = new System.Drawing.Size(219, 17);
            this.LB_PE_RATIO.TabIndex = 34;
            this.LB_PE_RATIO.Text = "***";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(705, 132);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(52, 16);
            this.lbDescription.TabIndex = 35;
            this.lbDescription.Text = "About:";
            // 
            // LB_REV_PER_EMPLOYEE
            // 
            this.LB_REV_PER_EMPLOYEE.AutoEllipsis = true;
            this.LB_REV_PER_EMPLOYEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_REV_PER_EMPLOYEE.Location = new System.Drawing.Point(526, 132);
            this.LB_REV_PER_EMPLOYEE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_REV_PER_EMPLOYEE.Name = "LB_REV_PER_EMPLOYEE";
            this.LB_REV_PER_EMPLOYEE.Size = new System.Drawing.Size(164, 17);
            this.LB_REV_PER_EMPLOYEE.TabIndex = 36;
            this.LB_REV_PER_EMPLOYEE.Text = "***";
            // 
            // LB_REVENUE
            // 
            this.LB_REVENUE.AutoEllipsis = true;
            this.LB_REVENUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_REVENUE.Location = new System.Drawing.Point(526, 92);
            this.LB_REVENUE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_REVENUE.Name = "LB_REVENUE";
            this.LB_REVENUE.Size = new System.Drawing.Size(164, 17);
            this.LB_REVENUE.TabIndex = 37;
            this.LB_REVENUE.Text = "***";
            // 
            // LB_MARKETCAP
            // 
            this.LB_MARKETCAP.AutoEllipsis = true;
            this.LB_MARKETCAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MARKETCAP.Location = new System.Drawing.Point(526, 56);
            this.LB_MARKETCAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_MARKETCAP.Name = "LB_MARKETCAP";
            this.LB_MARKETCAP.Size = new System.Drawing.Size(164, 17);
            this.LB_MARKETCAP.TabIndex = 38;
            this.LB_MARKETCAP.Text = "***";
            // 
            // LB_BETA
            // 
            this.LB_BETA.AutoEllipsis = true;
            this.LB_BETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BETA.Location = new System.Drawing.Point(526, 19);
            this.LB_BETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_BETA.Name = "LB_BETA";
            this.LB_BETA.Size = new System.Drawing.Size(164, 17);
            this.LB_BETA.TabIndex = 39;
            this.LB_BETA.Text = "***";
            // 
            // LB_DESCRIPTION
            // 
            this.LB_DESCRIPTION.AutoEllipsis = true;
            this.LB_DESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DESCRIPTION.Location = new System.Drawing.Point(761, 132);
            this.LB_DESCRIPTION.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_DESCRIPTION.Name = "LB_DESCRIPTION";
            this.LB_DESCRIPTION.Size = new System.Drawing.Size(315, 144);
            this.LB_DESCRIPTION.TabIndex = 40;
            this.LB_DESCRIPTION.Text = "***";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "*hover over chart to view data";
            // 
            // Search_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 627);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_DESCRIPTION);
            this.Controls.Add(this.LB_BETA);
            this.Controls.Add(this.LB_MARKETCAP);
            this.Controls.Add(this.LB_REVENUE);
            this.Controls.Add(this.LB_REV_PER_EMPLOYEE);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.LB_PE_RATIO);
            this.Controls.Add(this.LB_WEEK_RANGE);
            this.Controls.Add(this.LB_DAY_RANGE);
            this.Controls.Add(this.lbPeRatio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbWeekRange);
            this.Controls.Add(this.lbDayRange);
            this.Controls.Add(this.stocksChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchAgain);
            this.Controls.Add(this.LBL_LINK);
            this.Controls.Add(this.LBL_Company_CEO);
            this.Controls.Add(this.LB_Company_Website);
            this.Controls.Add(this.LB_Company_CEO);
            this.Controls.Add(this.LBL_Company_Current_Price);
            this.Controls.Add(this.LBL_Company_Opening_price);
            this.Controls.Add(this.LB_Company_Current_Price);
            this.Controls.Add(this.LB_Company_Open);
            this.Controls.Add(this.LBL_Company_market);
            this.Controls.Add(this.LB_Company_Primary_Market);
            this.Controls.Add(this.LBL_Company_Sector);
            this.Controls.Add(this.LB_Company_Sector);
            this.Controls.Add(this.LBL_Company_Name);
            this.Controls.Add(this.LB_Company);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.BTN_Close_Search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Result_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Result";
            this.Load += new System.EventHandler(this.Search_Result_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).EndInit();
            this.SearchAgain.ResumeLayout(false);
            this.SearchAgain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close_Search;
        private System.Windows.Forms.TextBox TB_Search_Again;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BTN_Search_Again;
        private System.Windows.Forms.Label LB_Company;
        private System.Windows.Forms.Label LBL_Company_Name;
        private System.Windows.Forms.Label LB_Company_Sector;
        private System.Windows.Forms.Label LBL_Company_Sector;
        private System.Windows.Forms.Label LB_Company_Primary_Market;
        private System.Windows.Forms.Label LBL_Company_market;
        private System.Windows.Forms.Label LB_Company_Open;
        private System.Windows.Forms.Label LB_Company_Current_Price;
        private System.Windows.Forms.Label LBL_Company_Opening_price;
        private System.Windows.Forms.Label LBL_Company_Current_Price;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LB_Company_CEO;
        private System.Windows.Forms.Label LB_Company_Website;
        private System.Windows.Forms.Label LBL_Company_CEO;
        private System.Windows.Forms.LinkLabel LBL_LINK;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Search_Error;
        private System.Windows.Forms.GroupBox SearchAgain;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart stocksChart;
        private System.Windows.Forms.Label LB_DESCRIPTION;
        private System.Windows.Forms.Label LB_BETA;
        private System.Windows.Forms.Label LB_MARKETCAP;
        private System.Windows.Forms.Label LB_REVENUE;
        private System.Windows.Forms.Label LB_REV_PER_EMPLOYEE;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label LB_PE_RATIO;
        private System.Windows.Forms.Label LB_WEEK_RANGE;
        private System.Windows.Forms.Label LB_DAY_RANGE;
        private System.Windows.Forms.Label lbPeRatio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbWeekRange;
        private System.Windows.Forms.Label lbDayRange;
        private System.Windows.Forms.Label label3;
    }
}