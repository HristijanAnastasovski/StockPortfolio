using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class Search_Result_Form : Form
    {
        public Search_Result_Form()
        {
            InitializeComponent();
        }

        public void Load_Search(string name)
        {
            LB_Company_Name.Text = name;
        }

        private void BTN_Close_Search_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
