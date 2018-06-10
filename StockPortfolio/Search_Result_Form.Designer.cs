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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Result_Form));
            this.BTN_Close_Search = new System.Windows.Forms.Button();
            this.TB_Search_Again = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BTN_Search_Again = new System.Windows.Forms.Button();
            this.LB_Company = new System.Windows.Forms.Label();
            this.LB_Company_Name = new System.Windows.Forms.Label();
            this.LB_Ceo = new System.Windows.Forms.Label();
            this.LB_Ceo_Name = new System.Windows.Forms.Label();
            this.LB_Company_Net_Worth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Close_Search
            // 
            this.BTN_Close_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close_Search.Location = new System.Drawing.Point(459, 442);
            this.BTN_Close_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Close_Search.Name = "BTN_Close_Search";
            this.BTN_Close_Search.Size = new System.Drawing.Size(151, 39);
            this.BTN_Close_Search.TabIndex = 0;
            this.BTN_Close_Search.Text = "Close";
            this.BTN_Close_Search.UseVisualStyleBackColor = true;
            this.BTN_Close_Search.Click += new System.EventHandler(this.BTN_Close_Search_Click);
            // 
            // TB_Search_Again
            // 
            this.TB_Search_Again.Location = new System.Drawing.Point(16, 427);
            this.TB_Search_Again.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Search_Again.MaxLength = 1000;
            this.TB_Search_Again.Name = "TB_Search_Again";
            this.TB_Search_Again.Size = new System.Drawing.Size(169, 23);
            this.TB_Search_Again.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 496);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // BTN_Search_Again
            // 
            this.BTN_Search_Again.Location = new System.Drawing.Point(47, 459);
            this.BTN_Search_Again.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Search_Again.Name = "BTN_Search_Again";
            this.BTN_Search_Again.Size = new System.Drawing.Size(100, 28);
            this.BTN_Search_Again.TabIndex = 3;
            this.BTN_Search_Again.Text = "Search";
            this.BTN_Search_Again.UseVisualStyleBackColor = true;
            // 
            // LB_Company
            // 
            this.LB_Company.AutoSize = true;
            this.LB_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company.Location = new System.Drawing.Point(16, 11);
            this.LB_Company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company.Name = "LB_Company";
            this.LB_Company.Size = new System.Drawing.Size(71, 17);
            this.LB_Company.TabIndex = 4;
            this.LB_Company.Text = "Company:";
            // 
            // LB_Company_Name
            // 
            this.LB_Company_Name.AutoSize = true;
            this.LB_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Company_Name.Location = new System.Drawing.Point(119, 16);
            this.LB_Company_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Name.Name = "LB_Company_Name";
            this.LB_Company_Name.Size = new System.Drawing.Size(23, 17);
            this.LB_Company_Name.TabIndex = 5;
            this.LB_Company_Name.Text = "***";
            // 
            // LB_Ceo
            // 
            this.LB_Ceo.AutoSize = true;
            this.LB_Ceo.Location = new System.Drawing.Point(16, 47);
            this.LB_Ceo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Ceo.Name = "LB_Ceo";
            this.LB_Ceo.Size = new System.Drawing.Size(41, 17);
            this.LB_Ceo.TabIndex = 6;
            this.LB_Ceo.Text = "CEO:";
            // 
            // LB_Ceo_Name
            // 
            this.LB_Ceo_Name.AutoSize = true;
            this.LB_Ceo_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Ceo_Name.Location = new System.Drawing.Point(119, 47);
            this.LB_Ceo_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Ceo_Name.Name = "LB_Ceo_Name";
            this.LB_Ceo_Name.Size = new System.Drawing.Size(23, 17);
            this.LB_Ceo_Name.TabIndex = 7;
            this.LB_Ceo_Name.Text = "***";
            // 
            // LB_Company_Net_Worth
            // 
            this.LB_Company_Net_Worth.AutoSize = true;
            this.LB_Company_Net_Worth.Location = new System.Drawing.Point(16, 87);
            this.LB_Company_Net_Worth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Company_Net_Worth.Name = "LB_Company_Net_Worth";
            this.LB_Company_Net_Worth.Size = new System.Drawing.Size(76, 17);
            this.LB_Company_Net_Worth.TabIndex = 8;
            this.LB_Company_Net_Worth.Text = "Net Worth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "***";
            // 
            // Search_Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Company_Net_Worth);
            this.Controls.Add(this.LB_Ceo_Name);
            this.Controls.Add(this.LB_Ceo);
            this.Controls.Add(this.LB_Company_Name);
            this.Controls.Add(this.LB_Company);
            this.Controls.Add(this.BTN_Search_Again);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TB_Search_Again);
            this.Controls.Add(this.BTN_Close_Search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Result_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close_Search;
        private System.Windows.Forms.TextBox TB_Search_Again;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BTN_Search_Again;
        private System.Windows.Forms.Label LB_Company;
        private System.Windows.Forms.Label LB_Company_Name;
        private System.Windows.Forms.Label LB_Ceo;
        private System.Windows.Forms.Label LB_Ceo_Name;
        private System.Windows.Forms.Label LB_Company_Net_Worth;
        private System.Windows.Forms.Label label4;
    }
}