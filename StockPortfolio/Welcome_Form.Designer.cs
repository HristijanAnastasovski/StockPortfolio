namespace StockPortfolio
{
    partial class Welcome_Form
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
            this.LB_Welcome = new System.Windows.Forms.Label();
            this.LB_timeleft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LB_Welcome
            // 
            this.LB_Welcome.AutoSize = true;
            this.LB_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LB_Welcome.Location = new System.Drawing.Point(68, 9);
            this.LB_Welcome.Name = "LB_Welcome";
            this.LB_Welcome.Size = new System.Drawing.Size(91, 22);
            this.LB_Welcome.TabIndex = 0;
            this.LB_Welcome.Text = "Welcome";
            this.LB_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_timeleft
            // 
            this.LB_timeleft.AutoSize = true;
            this.LB_timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_timeleft.Location = new System.Drawing.Point(74, 40);
            this.LB_timeleft.Name = "LB_timeleft";
            this.LB_timeleft.Size = new System.Drawing.Size(80, 13);
            this.LB_timeleft.TabIndex = 1;
            this.LB_timeleft.Text = "*connecting*";
            this.LB_timeleft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(26, 72);
            this.pbLoading.Maximum = 3;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(187, 18);
            this.pbLoading.TabIndex = 2;
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(237, 110);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.LB_timeleft);
            this.Controls.Add(this.LB_Welcome);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Welcome;
        private System.Windows.Forms.Label LB_timeleft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}