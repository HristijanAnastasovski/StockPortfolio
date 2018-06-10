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
            this.BTN_about = new System.Windows.Forms.Button();
            this.BTN_help = new System.Windows.Forms.Button();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.PB_Main_Logo = new System.Windows.Forms.PictureBox();
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.BTN_Search_Stocks = new System.Windows.Forms.Button();
            this.TB_Search_Stocks = new System.Windows.Forms.TextBox();
            this.ErrorProvider_Search_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox_Top_All_Time = new System.Windows.Forms.GroupBox();
            this.GroupBox_Top_Today = new System.Windows.Forms.GroupBox();
            this.PB_Top_All_Time = new System.Windows.Forms.PictureBox();
            this.PB_Top_Today = new System.Windows.Forms.PictureBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main_Logo)).BeginInit();
            this.GroupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).BeginInit();
            this.GroupBox_Top_All_Time.SuspendLayout();
            this.GroupBox_Top_Today.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top_All_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top_Today)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_about
            // 
            this.BTN_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_about.Location = new System.Drawing.Point(855, 514);
            this.BTN_about.Name = "BTN_about";
            this.BTN_about.Size = new System.Drawing.Size(136, 35);
            this.BTN_about.TabIndex = 1;
            this.BTN_about.Text = "About";
            this.BTN_about.UseVisualStyleBackColor = true;
            this.BTN_about.Click += new System.EventHandler(this.BTN_about_Click);
            // 
            // BTN_help
            // 
            this.BTN_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_help.Location = new System.Drawing.Point(855, 555);
            this.BTN_help.Name = "BTN_help";
            this.BTN_help.Size = new System.Drawing.Size(136, 35);
            this.BTN_help.TabIndex = 2;
            this.BTN_help.Text = "Help";
            this.BTN_help.UseVisualStyleBackColor = true;
            this.BTN_help.Click += new System.EventHandler(this.BTN_help_Click);
            // 
            // BTN_exit
            // 
            this.BTN_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exit.Location = new System.Drawing.Point(855, 596);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(136, 35);
            this.BTN_exit.TabIndex = 3;
            this.BTN_exit.Text = "Exit";
            this.BTN_exit.UseVisualStyleBackColor = true;
            this.BTN_exit.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // PB_Main_Logo
            // 
            this.PB_Main_Logo.BackColor = System.Drawing.Color.Green;
            this.PB_Main_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_Main_Logo.Image")));
            this.PB_Main_Logo.Location = new System.Drawing.Point(12, 12);
            this.PB_Main_Logo.Name = "PB_Main_Logo";
            this.PB_Main_Logo.Size = new System.Drawing.Size(200, 105);
            this.PB_Main_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Main_Logo.TabIndex = 4;
            this.PB_Main_Logo.TabStop = false;
            this.PB_Main_Logo.Click += new System.EventHandler(this.PB_Main_Logo_Click);
            // 
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.BTN_Search_Stocks);
            this.GroupBox_Search.Controls.Add(this.TB_Search_Stocks);
            this.GroupBox_Search.Location = new System.Drawing.Point(676, 12);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(315, 72);
            this.GroupBox_Search.TabIndex = 5;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search for stocks";
            // 
            // BTN_Search_Stocks
            // 
            this.BTN_Search_Stocks.Location = new System.Drawing.Point(221, 19);
            this.BTN_Search_Stocks.Name = "BTN_Search_Stocks";
            this.BTN_Search_Stocks.Size = new System.Drawing.Size(75, 37);
            this.BTN_Search_Stocks.TabIndex = 1;
            this.BTN_Search_Stocks.Text = "Search";
            this.BTN_Search_Stocks.UseVisualStyleBackColor = true;
            this.BTN_Search_Stocks.Click += new System.EventHandler(this.BTN_Search_Stocks_Click);
            // 
            // TB_Search_Stocks
            // 
            this.TB_Search_Stocks.Location = new System.Drawing.Point(16, 28);
            this.TB_Search_Stocks.MaxLength = 1000;
            this.TB_Search_Stocks.Name = "TB_Search_Stocks";
            this.TB_Search_Stocks.Size = new System.Drawing.Size(162, 20);
            this.TB_Search_Stocks.TabIndex = 0;
            // 
            // ErrorProvider_Search_Error
            // 
            this.ErrorProvider_Search_Error.ContainerControl = this;
            // 
            // GroupBox_Top_All_Time
            // 
            this.GroupBox_Top_All_Time.Controls.Add(this.PB_Top_All_Time);
            this.GroupBox_Top_All_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Top_All_Time.Location = new System.Drawing.Point(12, 141);
            this.GroupBox_Top_All_Time.Name = "GroupBox_Top_All_Time";
            this.GroupBox_Top_All_Time.Size = new System.Drawing.Size(296, 488);
            this.GroupBox_Top_All_Time.TabIndex = 6;
            this.GroupBox_Top_All_Time.TabStop = false;
            this.GroupBox_Top_All_Time.Text = "Top All-Time";
            // 
            // GroupBox_Top_Today
            // 
            this.GroupBox_Top_Today.Controls.Add(this.PB_Top_Today);
            this.GroupBox_Top_Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Top_Today.Location = new System.Drawing.Point(314, 142);
            this.GroupBox_Top_Today.Name = "GroupBox_Top_Today";
            this.GroupBox_Top_Today.Size = new System.Drawing.Size(290, 488);
            this.GroupBox_Top_Today.TabIndex = 7;
            this.GroupBox_Top_Today.TabStop = false;
            this.GroupBox_Top_Today.Text = "Top Today";
            // 
            // PB_Top_All_Time
            // 
            this.PB_Top_All_Time.Location = new System.Drawing.Point(6, 22);
            this.PB_Top_All_Time.Name = "PB_Top_All_Time";
            this.PB_Top_All_Time.Size = new System.Drawing.Size(284, 460);
            this.PB_Top_All_Time.TabIndex = 0;
            this.PB_Top_All_Time.TabStop = false;
            // 
            // PB_Top_Today
            // 
            this.PB_Top_Today.Location = new System.Drawing.Point(6, 22);
            this.PB_Top_Today.Name = "PB_Top_Today";
            this.PB_Top_Today.Size = new System.Drawing.Size(278, 459);
            this.PB_Top_Today.TabIndex = 0;
            this.PB_Top_Today.TabStop = false;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(610, 591);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(95, 38);
            this.BTN_Refresh.TabIndex = 8;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 636);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.GroupBox_Top_Today);
            this.Controls.Add(this.GroupBox_Top_All_Time);
            this.Controls.Add(this.GroupBox_Search);
            this.Controls.Add(this.PB_Main_Logo);
            this.Controls.Add(this.BTN_exit);
            this.Controls.Add(this.BTN_help);
            this.Controls.Add(this.BTN_about);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main_Logo)).EndInit();
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider_Search_Error)).EndInit();
            this.GroupBox_Top_All_Time.ResumeLayout(false);
            this.GroupBox_Top_Today.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top_All_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top_Today)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_about;
        private System.Windows.Forms.Button BTN_help;
        private System.Windows.Forms.Button BTN_exit;
        private System.Windows.Forms.PictureBox PB_Main_Logo;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.TextBox TB_Search_Stocks;
        private System.Windows.Forms.Button BTN_Search_Stocks;
        private System.Windows.Forms.ErrorProvider ErrorProvider_Search_Error;
        private System.Windows.Forms.GroupBox GroupBox_Top_All_Time;
        private System.Windows.Forms.GroupBox GroupBox_Top_Today;
        private System.Windows.Forms.PictureBox PB_Top_All_Time;
        private System.Windows.Forms.PictureBox PB_Top_Today;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}

