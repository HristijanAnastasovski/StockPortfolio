namespace StockPortfolio
{
    partial class Help_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Form));
            this.BTN_Close_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Close_Help
            // 
            this.BTN_Close_Help.Location = new System.Drawing.Point(90, 217);
            this.BTN_Close_Help.Name = "BTN_Close_Help";
            this.BTN_Close_Help.Size = new System.Drawing.Size(98, 32);
            this.BTN_Close_Help.TabIndex = 0;
            this.BTN_Close_Help.Text = "Close";
            this.BTN_Close_Help.UseVisualStyleBackColor = true;
            this.BTN_Close_Help.Click += new System.EventHandler(this.BTN_Close_Help_Click);
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTN_Close_Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close_Help;
    }
}