using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace StockPortfolio
{
    public partial class Search_Result_Form : Form
    {
        public String searchString { get; set; }
        Bitmap DrawArea;

        public Search_Result_Form()
        {
            InitializeComponent();
            InitializeStockSearchBox();
            pbLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLoading.Hide();
        }

        private async void Search_Result_Form_Load(object sender, EventArgs e)
        {
            await fillLabels(searchString);
            await paintGraph(searchString);

        }

        private async void InitializeStockSearchBox()
        {
            try
            {
                //TB_Search_Stocks.CharacterCasing = CharacterCasing.Upper;
                AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
                searchableSymbols.AddRange(await IEX_API.API.GetSymbols());
                TB_Search_Again.AutoCompleteCustomSource = searchableSymbols;
                TB_Search_Again.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Search_Again.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("BELJA " + e.Message);
            }
        }

        private void BTN_Close_Search_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            this.Close();
        }

        private async Task fillLabels(string str)
        {
            try
            {
                IEX_API.DTOs.QuoteDto qd = await IEX_API.API.GetQuote(Main_Menu.getSymbol(str));
                IEX_API.DTOs.CompanyInfoDto cid = await IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(str));
                if (cid != null && qd != null)
                {
                    LBL_Company_Name.Text =
                            qd.CompanyName != "" ? qd.CompanyName : "No Information";
                    LBL_Company_market.Text =
                            qd.PrimaryExchange.ToString() != "" ? qd.PrimaryExchange.ToString() : "No Information";
                    LBL_Company_Sector.Text =
                            qd.Sector.ToString() != "" ? qd.Sector.ToString() : "No Information";


                    if (qd.Open > qd.LatestPrice)
                        LBL_Company_Current_Price.Text =
                                LBL_Company_Current_Price.Text != "" ? "$" + qd.LatestPrice.ToString("0.##") + " ▼" : "No Information";
                    else
                        LBL_Company_Current_Price.Text =
                                LBL_Company_Current_Price.Text != "" ? "$" + qd.LatestPrice.ToString("0.##") + " ▲" : "No Information";

                    LBL_Company_Opening_price.Text =
                            LBL_Company_Opening_price.Text != "" ? "$" + qd.Open.ToString("0.##") : "No Information";

                    LBL_Company_CEO.Text = cid.Ceo != "" ? cid.Ceo : "No Information";
                    LBL_LINK.Text = cid.Website != "" ? cid.Website : "No Information";
                }
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("BELJA " + e.Message);
            }

        }

       

        private async void BTN_Search_Again_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            try
            {
                pbLoading.Show();
                pbLoading.Enabled = true;
                string search = TB_Search_Again.Text;
                if (string.IsNullOrWhiteSpace(search) || await IEX_API.API.GetQuote(Main_Menu.getSymbol(search)) == null
                    || await IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(search)) == null)
                {
                    ErrorProvider_Search_Error.SetError(TB_Search_Again, "Please enter a valid search");
                }
                else
                {
                    ErrorProvider_Search_Error.Clear();
                    await fillLabels(TB_Search_Again.Text);
                    await paintGraph(TB_Search_Again.Text);
                }
                pbLoading.Hide();
                pbLoading.Enabled = false;
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("BELJA " + ex.Message);
            }
        }

        private async Task paintGraph(string str)
        {
            try
            {
                foreach (var series in stocksChart.Series)
                {
                    series.Points.Clear();
                }
                IReadOnlyDictionary<DateTimeOffset, IEX_API.DTOs.HistoricalDataDto> dictionary =
                    await IEX_API.API.GetHistoricalData(Main_Menu.getSymbol(str));
                int i = 0;
                stocksChart.ChartAreas[0].AxisX.Minimum = 0;

                foreach (DateTimeOffset data in dictionary.Keys)
                {
                    stocksChart.Series["Price"].Points.AddXY(i, dictionary[data].High);
                    i++;
                }


            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("BELJA " + e.Message);
            }

        }

        private void LBL_LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LBL_LINK.Text);
        }
    }
}
