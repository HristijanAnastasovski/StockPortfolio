namespace StockPortfolio
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.BTN_Search_Stocks = new System.Windows.Forms.Button();
            this.TB_Search_Stocks = new System.Windows.Forms.TextBox();
            this.ErrorProvider_Search_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox_Top_All_Time = new System.Windows.Forms.GroupBox();
            this.lvMostPopular = new System.Windows.Forms.ListView();
            this.GroupBox_Top_Today = new System.Windows.Forms.GroupBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.PB_Main_Logo = new System.Windows.Forms.PictureBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Loading_Most_Popular = new System.Windows.Forms.PictureBox();
            this.UrlNews1 = new System.Windows.Forms.LinkLabel();
            this.UrlNews2 = new System.Windows.Forms.LinkLabel();
            this.UrlNews3 = new System.Windows.Forms.LinkLabel();
            this.Loading_Recent_News = new System.Windows.Forms.PictureBox();
            this.GroupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).BeginInit();
            this.GroupBox_Top_All_Time.SuspendLayout();
            this.GroupBox_Top_Today.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main_Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Most_Popular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Recent_News)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.BTN_Search_Stocks);
            this.GroupBox_Search.Controls.Add(this.TB_Search_Stocks);
            this.GroupBox_Search.Location = new System.Drawing.Point(779, 39);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(331, 57);
            this.GroupBox_Search.TabIndex = 5;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search for stocks";
            // 
            // BTN_Search_Stocks
            // 
            this.BTN_Search_Stocks.Location = new System.Drawing.Point(237, 16);
            this.BTN_Search_Stocks.Name = "BTN_Search_Stocks";
            this.BTN_Search_Stocks.Size = new System.Drawing.Size(75, 25);
            this.BTN_Search_Stocks.TabIndex = 1;
            this.BTN_Search_Stocks.Text = "Search";
            this.BTN_Search_Stocks.UseVisualStyleBackColor = true;
            this.BTN_Search_Stocks.Click += new System.EventHandler(this.BTN_Search_Stocks_Click);
            // 
            // TB_Search_Stocks
            // 
            this.TB_Search_Stocks.Location = new System.Drawing.Point(6, 19);
            this.TB_Search_Stocks.MaxLength = 1000;
            this.TB_Search_Stocks.Name = "TB_Search_Stocks";
            this.TB_Search_Stocks.Size = new System.Drawing.Size(209, 20);
            this.TB_Search_Stocks.TabIndex = 0;
            // 
            // ErrorProvider_Search_Error
            // 
            this.ErrorProvider_Search_Error.ContainerControl = this;
            // 
            // GroupBox_Top_All_Time
            // 
            this.GroupBox_Top_All_Time.Controls.Add(this.Loading_Most_Popular);
            this.GroupBox_Top_All_Time.Controls.Add(this.lvMostPopular);
            this.GroupBox_Top_All_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Top_All_Time.Location = new System.Drawing.Point(12, 102);
            this.GroupBox_Top_All_Time.Name = "GroupBox_Top_All_Time";
            this.GroupBox_Top_All_Time.Size = new System.Drawing.Size(522, 393);
            this.GroupBox_Top_All_Time.TabIndex = 6;
            this.GroupBox_Top_All_Time.TabStop = false;
            this.GroupBox_Top_All_Time.Text = "Most popular";
            // 
            // lvMostPopular
            // 
            this.lvMostPopular.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.lvMostPopular.Location = new System.Drawing.Point(13, 22);
            this.lvMostPopular.Name = "lvMostPopular";
            this.lvMostPopular.Size = new System.Drawing.Size(497, 358);
            this.lvMostPopular.TabIndex = 3;
            this.lvMostPopular.UseCompatibleStateImageBehavior = false;
            this.lvMostPopular.View = System.Windows.Forms.View.List;
            this.lvMostPopular.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMostPopular_MouseDoubleClick_1);
            // 
            // GroupBox_Top_Today
            // 
            this.GroupBox_Top_Today.Controls.Add(this.Loading_Recent_News);
            this.GroupBox_Top_Today.Controls.Add(this.UrlNews3);
            this.GroupBox_Top_Today.Controls.Add(this.UrlNews2);
            this.GroupBox_Top_Today.Controls.Add(this.UrlNews1);
            this.GroupBox_Top_Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Top_Today.Location = new System.Drawing.Point(540, 102);
            this.GroupBox_Top_Today.Name = "GroupBox_Top_Today";
            this.GroupBox_Top_Today.Size = new System.Drawing.Size(570, 279);
            this.GroupBox_Top_Today.TabIndex = 7;
            this.GroupBox_Top_Today.TabStop = false;
            this.GroupBox_Top_Today.Text = "Recent News";
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Enabled = false;
            this.BTN_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.ForeColor = System.Drawing.Color.Black;
            this.BTN_Refresh.Location = new System.Drawing.Point(767, 433);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(124, 49);
            this.BTN_Refresh.TabIndex = 8;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Enabled = false;
            this.pbLoading.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.pbLoading.Location = new System.Drawing.Point(713, 49);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(48, 47);
            this.pbLoading.TabIndex = 9;
            this.pbLoading.TabStop = false;
            // 
            // PB_Main_Logo
            // 
            this.PB_Main_Logo.BackColor = System.Drawing.Color.Green;
            this.PB_Main_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Main_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_Main_Logo.Image")));
            this.PB_Main_Logo.Location = new System.Drawing.Point(12, 39);
            this.PB_Main_Logo.Name = "PB_Main_Logo";
            this.PB_Main_Logo.Size = new System.Drawing.Size(102, 45);
            this.PB_Main_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Main_Logo.TabIndex = 4;
            this.PB_Main_Logo.TabStop = false;
            this.PB_Main_Logo.Click += new System.EventHandler(this.PB_Main_Logo_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(120, 39);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(102, 45);
            this.btnCalculator.TabIndex = 10;
            this.btnCalculator.Text = "Stock calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Loading_Most_Popular
            // 
            this.Loading_Most_Popular.BackColor = System.Drawing.Color.White;
            this.Loading_Most_Popular.Enabled = false;
            this.Loading_Most_Popular.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.Loading_Most_Popular.Location = new System.Drawing.Point(157, 136);
            this.Loading_Most_Popular.Name = "Loading_Most_Popular";
            this.Loading_Most_Popular.Size = new System.Drawing.Size(173, 173);
            this.Loading_Most_Popular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Loading_Most_Popular.TabIndex = 10;
            this.Loading_Most_Popular.TabStop = false;
            this.Loading_Most_Popular.Visible = false;
            // 
            // UrlNews1
            // 
            this.UrlNews1.AutoSize = true;
            this.UrlNews1.Location = new System.Drawing.Point(17, 47);
            this.UrlNews1.Name = "UrlNews1";
            this.UrlNews1.Size = new System.Drawing.Size(72, 17);
            this.UrlNews1.TabIndex = 2;
            this.UrlNews1.TabStop = true;
            this.UrlNews1.Text = "linkLabel1";
            this.UrlNews1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Url1_LinkClicked);
            // 
            // UrlNews2
            // 
            this.UrlNews2.AutoSize = true;
            this.UrlNews2.Location = new System.Drawing.Point(17, 127);
            this.UrlNews2.Name = "UrlNews2";
            this.UrlNews2.Size = new System.Drawing.Size(72, 17);
            this.UrlNews2.TabIndex = 3;
            this.UrlNews2.TabStop = true;
            this.UrlNews2.Text = "linkLabel1";
            this.UrlNews2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlNews2_LinkClicked);
            // 
            // UrlNews3
            // 
            this.UrlNews3.AutoSize = true;
            this.UrlNews3.Location = new System.Drawing.Point(17, 210);
            this.UrlNews3.Name = "UrlNews3";
            this.UrlNews3.Size = new System.Drawing.Size(72, 17);
            this.UrlNews3.TabIndex = 4;
            this.UrlNews3.TabStop = true;
            this.UrlNews3.Text = "linkLabel1";
            this.UrlNews3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlNews3_LinkClicked);
            // 
            // Loading_Recent_News
            // 
            this.Loading_Recent_News.BackColor = System.Drawing.Color.Transparent;
            this.Loading_Recent_News.Enabled = false;
            this.Loading_Recent_News.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.Loading_Recent_News.Location = new System.Drawing.Point(197, 54);
            this.Loading_Recent_News.Name = "Loading_Recent_News";
            this.Loading_Recent_News.Size = new System.Drawing.Size(173, 173);
            this.Loading_Recent_News.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Loading_Recent_News.TabIndex = 11;
            this.Loading_Recent_News.TabStop = false;
            this.Loading_Recent_News.Visible = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 514);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.GroupBox_Top_Today);
            this.Controls.Add(this.GroupBox_Top_All_Time);
            this.Controls.Add(this.GroupBox_Search);
            this.Controls.Add(this.PB_Main_Logo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).EndInit();
            this.GroupBox_Top_All_Time.ResumeLayout(false);
            this.GroupBox_Top_All_Time.PerformLayout();
            this.GroupBox_Top_Today.ResumeLayout(false);
            this.GroupBox_Top_Today.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main_Logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Most_Popular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Recent_News)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_Main_Logo;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.TextBox TB_Search_Stocks;
        private System.Windows.Forms.Button BTN_Search_Stocks;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Search_Error;
        private System.Windows.Forms.GroupBox GroupBox_Top_All_Time;
        private System.Windows.Forms.GroupBox GroupBox_Top_Today;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.ListView lvMostPopular;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox Loading_Most_Popular;
        private System.Windows.Forms.LinkLabel UrlNews1;
        private System.Windows.Forms.LinkLabel UrlNews3;
        private System.Windows.Forms.LinkLabel UrlNews2;
        private System.Windows.Forms.PictureBox Loading_Recent_News;
    }
}

