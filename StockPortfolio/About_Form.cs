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
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
        }

        private void BTN_Close_About_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Form_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(3);
            if(num == 0)
            {
                LB_Name1.Text = "Бодан Мојсиловиќ";
                LB_Name2.Text = "Христијан Анастасовски";
                LB_Name3.Text = "Давор Баришиќ-Јаман";
            }
            else if(num == 1)
            {
                LB_Name2.Text = "Бодан Мојсиловиќ";
                LB_Name1.Text = "Христијан Анастасовски";
                LB_Name3.Text = "Давор Баришиќ-Јаман";
            }
            else if(num == 2)
            {
                LB_Name3.Text = "Бодан Мојсиловиќ";
                LB_Name2.Text = "Христијан Анастасовски";
                LB_Name1.Text = "Давор Баришиќ-Јаман";
            }
            else
            {
                LB_Name1.Text = "Бодан Мојсиловиќ";
                LB_Name2.Text = "Христијан Анастасовски";
                LB_Name3.Text = "Давор Баришиќ-Јаман";
            }
        }
    }
}
