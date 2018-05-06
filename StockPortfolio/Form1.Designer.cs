namespace StockPortfolio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_login_register = new System.Windows.Forms.Button();
            this.BTN_about = new System.Windows.Forms.Button();
            this.BTN_help = new System.Windows.Forms.Button();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_login_register
            // 
            this.BTN_login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login_register.Location = new System.Drawing.Point(772, 37);
            this.BTN_login_register.Name = "BTN_login_register";
            this.BTN_login_register.Size = new System.Drawing.Size(136, 35);
            this.BTN_login_register.TabIndex = 0;
            this.BTN_login_register.Text = "Login/Register";
            this.BTN_login_register.UseVisualStyleBackColor = true;
            // 
            // BTN_about
            // 
            this.BTN_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_about.Location = new System.Drawing.Point(772, 102);
            this.BTN_about.Name = "BTN_about";
            this.BTN_about.Size = new System.Drawing.Size(136, 35);
            this.BTN_about.TabIndex = 1;
            this.BTN_about.Text = "About";
            this.BTN_about.UseVisualStyleBackColor = true;
            // 
            // BTN_help
            // 
            this.BTN_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_help.Location = new System.Drawing.Point(772, 166);
            this.BTN_help.Name = "BTN_help";
            this.BTN_help.Size = new System.Drawing.Size(136, 35);
            this.BTN_help.TabIndex = 2;
            this.BTN_help.Text = "Help";
            this.BTN_help.UseVisualStyleBackColor = true;
            // 
            // BTN_exit
            // 
            this.BTN_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exit.Location = new System.Drawing.Point(772, 492);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(136, 35);
            this.BTN_exit.TabIndex = 3;
            this.BTN_exit.Text = "Exit";
            this.BTN_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 550);
            this.Controls.Add(this.BTN_exit);
            this.Controls.Add(this.BTN_help);
            this.Controls.Add(this.BTN_about);
            this.Controls.Add(this.BTN_login_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_login_register;
        private System.Windows.Forms.Button BTN_about;
        private System.Windows.Forms.Button BTN_help;
        private System.Windows.Forms.Button BTN_exit;
    }
}

