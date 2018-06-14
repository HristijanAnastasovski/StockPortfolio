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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.PB_PAINT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).BeginInit();
            this.SearchAgain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PAINT)).BeginInit();
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
            this.TB_Search_Again.Location = new System.Drawing.Point(7, 42);
            this.TB_Search_Again.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Search_Again.MaxLength = 1000;
            this.TB_Search_Again.Name = "TB_Search_Again";
            this.TB_Search_Again.Size = new System.Drawing.Size(196, 21);
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
            this.BTN_Search_Again.Location = new System.Drawing.Point(251, 34);
            this.BTN_Search_Again.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Search_Again.Name = "BTN_Search_Again";
            this.BTN_Search_Again.Size = new System.Drawing.Size(100, 38);
            this.BTN_Search_Again.TabIndex = 3;
            this.BTN_Search_Again.Text = "Search";
            this.BTN_Search_Again.UseVisualStyleBackColor = true;
            this.BTN_Search_Again.Click += new System.EventHandler(this.BTN_Search_Again_Click);
            // 
            // LB_Company
            // 
            this.LB_Company.AutoSize = true;
            this.LB_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company.Location = new System.Drawing.Point(16, 19);
            this.LB_Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company.Name = "LB_Company";
            this.LB_Company.Size = new System.Drawing.Size(71, 17);
            this.LB_Company.TabIndex = 4;
            this.LB_Company.Text = "Company:";
            // 
            // LBL_Company_Name
            // 
            this.LBL_Company_Name.AutoSize = true;
            this.LBL_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Name.Location = new System.Drawing.Point(145, 19);
            this.LBL_Company_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Name.Name = "LBL_Company_Name";
            this.LBL_Company_Name.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_Name.TabIndex = 5;
            this.LBL_Company_Name.Text = "***";
            // 
            // LB_Company_Sector
            // 
            this.LB_Company_Sector.AutoSize = true;
            this.LB_Company_Sector.Location = new System.Drawing.Point(16, 132);
            this.LB_Company_Sector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Sector.Name = "LB_Company_Sector";
            this.LB_Company_Sector.Size = new System.Drawing.Size(53, 17);
            this.LB_Company_Sector.TabIndex = 6;
            this.LB_Company_Sector.Text = "Sector:";
            // 
            // LBL_Company_Sector
            // 
            this.LBL_Company_Sector.AutoSize = true;
            this.LBL_Company_Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Sector.Location = new System.Drawing.Point(145, 132);
            this.LBL_Company_Sector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Sector.Name = "LBL_Company_Sector";
            this.LBL_Company_Sector.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_Sector.TabIndex = 7;
            this.LBL_Company_Sector.Text = "***";
            // 
            // LB_Company_Primary_Market
            // 
            this.LB_Company_Primary_Market.AutoSize = true;
            this.LB_Company_Primary_Market.Location = new System.Drawing.Point(16, 168);
            this.LB_Company_Primary_Market.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Primary_Market.Name = "LB_Company_Primary_Market";
            this.LB_Company_Primary_Market.Size = new System.Drawing.Size(107, 17);
            this.LB_Company_Primary_Market.TabIndex = 8;
            this.LB_Company_Primary_Market.Text = "Primary market:";
            // 
            // LBL_Company_market
            // 
            this.LBL_Company_market.AutoSize = true;
            this.LBL_Company_market.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_market.Location = new System.Drawing.Point(145, 168);
            this.LBL_Company_market.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_market.Name = "LBL_Company_market";
            this.LBL_Company_market.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_market.TabIndex = 9;
            this.LBL_Company_market.Text = "***";
            // 
            // LB_Company_Open
            // 
            this.LB_Company_Open.AutoSize = true;
            this.LB_Company_Open.Location = new System.Drawing.Point(16, 212);
            this.LB_Company_Open.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Open.Name = "LB_Company_Open";
            this.LB_Company_Open.Size = new System.Drawing.Size(101, 17);
            this.LB_Company_Open.TabIndex = 10;
            this.LB_Company_Open.Text = "Opening price:";
            // 
            // LB_Company_Current_Price
            // 
            this.LB_Company_Current_Price.AutoSize = true;
            this.LB_Company_Current_Price.Location = new System.Drawing.Point(16, 259);
            this.LB_Company_Current_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Current_Price.Name = "LB_Company_Current_Price";
            this.LB_Company_Current_Price.Size = new System.Drawing.Size(94, 17);
            this.LB_Company_Current_Price.TabIndex = 11;
            this.LB_Company_Current_Price.Text = "Current price:";
            // 
            // LBL_Company_Opening_price
            // 
            this.LBL_Company_Opening_price.AutoSize = true;
            this.LBL_Company_Opening_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Opening_price.Location = new System.Drawing.Point(145, 212);
            this.LBL_Company_Opening_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Opening_price.Name = "LBL_Company_Opening_price";
            this.LBL_Company_Opening_price.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_Opening_price.TabIndex = 12;
            this.LBL_Company_Opening_price.Text = "***";
            // 
            // LBL_Company_Current_Price
            // 
            this.LBL_Company_Current_Price.AutoSize = true;
            this.LBL_Company_Current_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_Current_Price.Location = new System.Drawing.Point(145, 259);
            this.LBL_Company_Current_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_Current_Price.Name = "LBL_Company_Current_Price";
            this.LBL_Company_Current_Price.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_Current_Price.TabIndex = 13;
            this.LBL_Company_Current_Price.Text = "***";
            // 
            // LB_Company_CEO
            // 
            this.LB_Company_CEO.AutoSize = true;
            this.LB_Company_CEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_CEO.Location = new System.Drawing.Point(16, 56);
            this.LB_Company_CEO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_CEO.Name = "LB_Company_CEO";
            this.LB_Company_CEO.Size = new System.Drawing.Size(41, 17);
            this.LB_Company_CEO.TabIndex = 15;
            this.LB_Company_CEO.Text = "CEO:";
            // 
            // LB_Company_Website
            // 
            this.LB_Company_Website.AutoSize = true;
            this.LB_Company_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Website.Location = new System.Drawing.Point(16, 92);
            this.LB_Company_Website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Website.Name = "LB_Company_Website";
            this.LB_Company_Website.Size = new System.Drawing.Size(63, 17);
            this.LB_Company_Website.TabIndex = 16;
            this.LB_Company_Website.Text = "Website:";
            // 
            // LBL_Company_CEO
            // 
            this.LBL_Company_CEO.AutoSize = true;
            this.LBL_Company_CEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Company_CEO.Location = new System.Drawing.Point(145, 56);
            this.LBL_Company_CEO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Company_CEO.Name = "LBL_Company_CEO";
            this.LBL_Company_CEO.Size = new System.Drawing.Size(23, 17);
            this.LBL_Company_CEO.TabIndex = 17;
            this.LBL_Company_CEO.Text = "***";
            // 
            // LBL_LINK
            // 
            this.LBL_LINK.AutoSize = true;
            this.LBL_LINK.Location = new System.Drawing.Point(145, 92);
            this.LBL_LINK.Name = "LBL_LINK";
            this.LBL_LINK.Size = new System.Drawing.Size(72, 17);
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
            this.SearchAgain.Location = new System.Drawing.Point(701, 19);
            this.SearchAgain.Name = "SearchAgain";
            this.SearchAgain.Size = new System.Drawing.Size(375, 90);
            this.SearchAgain.TabIndex = 20;
            this.SearchAgain.TabStop = false;
            this.SearchAgain.Text = "Search for stocks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "VALUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "TIME (LAST 30 DAYS)";
            // 
            // pbLoading
            // 
            this.pbLoading.Enabled = false;
            this.pbLoading.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.pbLoading.Location = new System.Drawing.Point(627, 37);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(68, 54);
            this.pbLoading.TabIndex = 21;
            this.pbLoading.TabStop = false;
            // 
            // PB_PAINT
            // 
            this.PB_PAINT.BackColor = System.Drawing.Color.White;
            this.PB_PAINT.Location = new System.Drawing.Point(118, 294);
            this.PB_PAINT.Name = "PB_PAINT";
            this.PB_PAINT.Size = new System.Drawing.Size(624, 300);
            this.PB_PAINT.TabIndex = 14;
            this.PB_PAINT.TabStop = false;
            this.PB_PAINT.WaitOnLoad = true;
            // 
            // Search_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.SearchAgain);
            this.Controls.Add(this.LBL_LINK);
            this.Controls.Add(this.LBL_Company_CEO);
            this.Controls.Add(this.LB_Company_Website);
            this.Controls.Add(this.LB_Company_CEO);
            this.Controls.Add(this.PB_PAINT);
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_PAINT)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_PAINT;
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
    }
}