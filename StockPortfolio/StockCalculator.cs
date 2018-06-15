using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPortfolio
{
    public partial class StockCalculator : Form
    {
        public bool companyError;
        public bool numberError;
        public bool priceError;
        public bool voiceEnabled;
        
        public StockCalculator()
        {
            InitializeComponent();
            companyError = false;
            numberError = false;
            priceError = false;
            voiceEnabled = true;
            InitializeSearchBox();
            lblMessage.Text = "";
        }

        private async void InitializeSearchBox()
        {
            try
            {
                AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
                searchableSymbols.AddRange(await IEX_API.API.GetSymbols());
                tbCompany.AutoCompleteCustomSource = searchableSymbols;
                tbCompany.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbCompany.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            if (!companyError && !numberError && !priceError && !string.IsNullOrWhiteSpace(tbNumberBought.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                string company = tbCompany.Text;
                IEX_API.DTOs.QuoteDto qd = await IEX_API.API.GetQuote(Main_Menu.getSymbol(company));
                double price = qd.LatestPrice;
                int numberBought = Convert.ToInt32(tbNumberBought.Text);
                double priceBought = Convert.ToDouble(tbPrice.Text);

                double priceSumNow = price * numberBought;
                double priceSumThen = priceBought * numberBought;

                tbTotalEarnings.Text = "$" + (priceSumNow - priceSumThen).ToString("0.##");
                if (priceSumNow > priceSumThen)
                {
                    lblMessage.Text = "Congratulations!";
                    if (voiceEnabled)
                    {
                        Stream s = Properties.Resources.applause;
                        System.Media.SoundPlayer snds = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
                else
                {
                    lblMessage.Text = "We are sorry to hear that!";
                    if (voiceEnabled)
                    {
                        Stream strs = Properties.Resources.sadTrombone;
                        System.Media.SoundPlayer snds = new System.Media.SoundPlayer(str);
                        snd.Play();
                    }
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tbPrice.Text) && String.IsNullOrWhiteSpace(tbNumberBought.Text))
                {
                    errorProviderBuyingPrice.SetError(tbPrice, "Please enter a valid number");
                    errorProviderNumberStocks.SetError(tbNumberBought, "Please enter a valid number");
                }
                else if (String.IsNullOrWhiteSpace(tbPrice.Text) && !String.IsNullOrWhiteSpace(tbNumberBought.Text))
                {
                    errorProviderBuyingPrice.SetError(tbPrice, "Please enter a valid number");
                    errorProviderNumberStocks.Clear();
                }
                else if (String.IsNullOrWhiteSpace(tbNumberBought.Text) && !String.IsNullOrWhiteSpace(tbPrice.Text))
                {
                    errorProviderNumberStocks.SetError(tbNumberBought, "Please enter a valid number");
                    errorProviderBuyingPrice.Clear();
                }
            }
        }

        private void tbCompany_Validated(object sender, EventArgs e)
        {
            string company = tbCompany.Text;
            // dodadov ako e vneseno
            // null da ne frla exception
            // treba i za neso drugo sto ne e Firma
            // da ne go frla toj gnasniot exception
            if (string.IsNullOrWhiteSpace(company) || IEX_API.API.GetQuote(Main_Menu.getSymbol(company)) == null || company == "null")
            {
                errorProvider_company.SetError(tbCompany, "Please enter a valid search");
                companyError = true;
            }
            else
            {
                errorProvider_company.Clear();
                companyError = false;
            }
        }

        private void tbNumberBought_Validated(object sender, EventArgs e)
        {

            int n;
            bool isNumeric = int.TryParse(tbNumberBought.Text, out n);
            if (!isNumeric)
            {
                errorProviderNumberStocks.SetError(tbNumberBought, "Please enter a number");
                numberError = true;
            }
            else
            {
                errorProviderNumberStocks.Clear();
                numberError = false;
            }
        }

        private void tbPrice_Validated(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = double.TryParse(tbNumberBought.Text, out n);
            isNumeric = double.TryParse(tbPrice.Text, out n);
            if (!isNumeric)
            {
                errorProviderBuyingPrice.SetError(tbPrice, "Please enter a number");
                priceError = true;
            }
            else
            {
                errorProviderBuyingPrice.Clear();
                priceError = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            this.Close();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableToolStripMenuItem.Text == "Disable")
            {
                disableToolStripMenuItem.Text = "Enable";
                voiceEnabled = false;
            }
            else
            { 
                disableToolStripMenuItem.Text = "Disable";
                voiceEnabled = true;
            }
        }
    }
}
