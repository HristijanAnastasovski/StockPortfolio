namespace StockPortfolio
{
    partial class Network_Check_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Network_Check_Form));
            this.LBL_No_NET = new System.Windows.Forms.Label();
            this.BTN_Retry_Reconnect = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Reconnect = new System.Windows.Forms.Label();
            this.PB_Load_Net = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LBL_Retry_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Load_Net)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_No_NET
            // 
            this.LBL_No_NET.AutoSize = true;
            this.LBL_No_NET.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_No_NET.Location = new System.Drawing.Point(3, 10);
            this.LBL_No_NET.Name = "LBL_No_NET";
            this.LBL_No_NET.Size = new System.Drawing.Size(281, 29);
            this.LBL_No_NET.TabIndex = 0;
            this.LBL_No_NET.Text = "No Internet Connection";
            // 
            // BTN_Retry_Reconnect
            // 
            this.BTN_Retry_Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Retry_Reconnect.Location = new System.Drawing.Point(91, 175);
            this.BTN_Retry_Reconnect.Name = "BTN_Retry_Reconnect";
            this.BTN_Retry_Reconnect.Size = new System.Drawing.Size(97, 40);
            this.BTN_Retry_Reconnect.TabIndex = 1;
            this.BTN_Retry_Reconnect.Text = "Retry";
            this.BTN_Retry_Reconnect.UseVisualStyleBackColor = true;
            this.BTN_Retry_Reconnect.Click += new System.EventHandler(this.BTN_Retry_Reconnect_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.Location = new System.Drawing.Point(91, 221);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(97, 40);
            this.BTN_Exit.TabIndex = 2;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Reconnect
            // 
            this.LBL_Reconnect.AutoSize = true;
            this.LBL_Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Reconnect.Location = new System.Drawing.Point(74, 51);
            this.LBL_Reconnect.Name = "LBL_Reconnect";
            this.LBL_Reconnect.Size = new System.Drawing.Size(207, 15);
            this.LBL_Reconnect.TabIndex = 3;
            this.LBL_Reconnect.Text = "Reconnection timed out.\\nTry again?";
            // 
            // PB_Load_Net
            // 
            this.PB_Load_Net.Enabled = false;
            this.PB_Load_Net.Image = global::StockPortfolio.Properties.Resources.Loading_icon21;
            this.PB_Load_Net.Location = new System.Drawing.Point(104, 111);
            this.PB_Load_Net.Name = "PB_Load_Net";
            this.PB_Load_Net.Size = new System.Drawing.Size(65, 47);
            this.PB_Load_Net.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Load_Net.TabIndex = 10;
            this.PB_Load_Net.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LBL_Retry_Count
            // 
            this.LBL_Retry_Count.AutoSize = true;
            this.LBL_Retry_Count.Location = new System.Drawing.Point(101, 86);
            this.LBL_Retry_Count.Name = "LBL_Retry_Count";
            this.LBL_Retry_Count.Size = new System.Drawing.Size(74, 13);
            this.LBL_Retry_Count.TabIndex = 11;
            this.LBL_Retry_Count.Text = "Retry count: 1";
            // 
            // Network_Check_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.LBL_Retry_Count);
            this.Controls.Add(this.PB_Load_Net);
            this.Controls.Add(this.LBL_Reconnect);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Retry_Reconnect);
            this.Controls.Add(this.LBL_No_NET);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Network_Check_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Network";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Network_Check_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Load_Net)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_No_NET;
        private System.Windows.Forms.Button BTN_Retry_Reconnect;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_Reconnect;
        private System.Windows.Forms.PictureBox PB_Load_Net;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LBL_Retry_Count;
    }
}