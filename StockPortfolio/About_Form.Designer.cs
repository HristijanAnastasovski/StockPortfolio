namespace StockPortfolio
{
    partial class About_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Form));
            this.BTN_Close_About = new System.Windows.Forms.Button();
            this.LB_About = new System.Windows.Forms.Label();
            this.LB_Name1 = new System.Windows.Forms.Label();
            this.LB_Name2 = new System.Windows.Forms.Label();
            this.LB_Name3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Close_About
            // 
            this.BTN_Close_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close_About.Location = new System.Drawing.Point(82, 212);
            this.BTN_Close_About.Name = "BTN_Close_About";
            this.BTN_Close_About.Size = new System.Drawing.Size(111, 29);
            this.BTN_Close_About.TabIndex = 0;
            this.BTN_Close_About.Text = "Close";
            this.BTN_Close_About.UseVisualStyleBackColor = true;
            this.BTN_Close_About.Click += new System.EventHandler(this.BTN_Close_About_Click);
            // 
            // LB_About
            // 
            this.LB_About.AutoSize = true;
            this.LB_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_About.Location = new System.Drawing.Point(12, 9);
            this.LB_About.Name = "LB_About";
            this.LB_About.Size = new System.Drawing.Size(247, 25);
            this.LB_About.TabIndex = 1;
            this.LB_About.Text = "This program was made by";
            // 
            // LB_Name1
            // 
            this.LB_Name1.AutoSize = true;
            this.LB_Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name1.Location = new System.Drawing.Point(14, 59);
            this.LB_Name1.Name = "LB_Name1";
            this.LB_Name1.Size = new System.Drawing.Size(23, 17);
            this.LB_Name1.TabIndex = 2;
            this.LB_Name1.Text = "***";
            // 
            // LB_Name2
            // 
            this.LB_Name2.AutoSize = true;
            this.LB_Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name2.Location = new System.Drawing.Point(14, 100);
            this.LB_Name2.Name = "LB_Name2";
            this.LB_Name2.Size = new System.Drawing.Size(23, 17);
            this.LB_Name2.TabIndex = 3;
            this.LB_Name2.Text = "***";
            // 
            // LB_Name3
            // 
            this.LB_Name3.AutoSize = true;
            this.LB_Name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name3.Location = new System.Drawing.Point(14, 141);
            this.LB_Name3.Name = "LB_Name3";
            this.LB_Name3.Size = new System.Drawing.Size(23, 17);
            this.LB_Name3.TabIndex = 4;
            this.LB_Name3.Text = "***";
            // 
            // About_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 253);
            this.Controls.Add(this.LB_Name3);
            this.Controls.Add(this.LB_Name2);
            this.Controls.Add(this.LB_Name1);
            this.Controls.Add(this.LB_About);
            this.Controls.Add(this.BTN_Close_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close_About;
        private System.Windows.Forms.Label LB_About;
        private System.Windows.Forms.Label LB_Name1;
        private System.Windows.Forms.Label LB_Name2;
        private System.Windows.Forms.Label LB_Name3;
    }
}