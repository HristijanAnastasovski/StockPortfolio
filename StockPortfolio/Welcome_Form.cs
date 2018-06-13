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
        public int time = 3;
        public Welcome_Form()
        {
            InitializeComponent();


            // sidenote: site ovie simboli "aapl", "msft" i slicno se case insensitive
            // nema vrska dali ke se povika so "AAPL" ili "AaPL" ili kao bilo

            API.GetHistoricalData("aapl"); // samo za test
            QuoteDto msft = API.GetQuote("msft"); // samo za test
            Debug.WriteLine(msft.Symbol); // samo za test
            List<NewsDto> news = API.GetNews(1).ToList<NewsDto>(); // samo za test

            CompanyInfoDto appleInfo = API.GetCompanyInfo("aapl"); // samo za test
            Debug.WriteLine("CEO: " + appleInfo.Ceo); // samo za test
            Debug.WriteLine("Industry: " + appleInfo.Industry); // samo za test
            Debug.WriteLine("Description: " + appleInfo.Description); // samo za test
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {
            LB_timeleft.Text = String.Format($"Continuing in {time}");
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            LB_timeleft.Text = String.Format($"Continuing in {time}");
            if(time <= 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Dispose();
                this.Close();
            }
        }
    }
}