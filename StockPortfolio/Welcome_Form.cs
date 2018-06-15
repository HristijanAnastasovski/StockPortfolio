using StockPortfolio.IEX_API;
using StockPortfolio.IEX_API.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class Welcome_Form : Form
    {
        public int time =4;
        public Welcome_Form()
        {
            InitializeComponent();

            
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LB_timeleft.Text = "Loading";
            timer1.Enabled = true;
            timer1.Start();
            pbLoading.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            LB_timeleft.Text += ".";
            //LB_timeleft.Text = String.Format($"Continuing in {time}");
            if (time > 0)
                pbLoading.Value++;
                
            if (time <= 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Dispose();
                this.Close();
            }
        }
    }
}