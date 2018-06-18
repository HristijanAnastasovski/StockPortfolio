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
using System.Windows.Forms.DataVisualization.Charting;

namespace StockPortfolio
{
    public partial class Search_Result_Form : Form
    {
        public String searchString { get; set; }
        

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
                MessageBox.Show("Error " + e.Message);
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
                IEX_API.DTOs.FinancialDataDto fd = await IEX_API.API.GetFinancialData(Main_Menu.getSymbol(str));
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
                                qd.LatestPrice.ToString() != null ? "$" + qd.LatestPrice.ToString("0.##") + " ▼" : "No Information";
                    else
                        LBL_Company_Current_Price.Text =
                                qd.LatestPrice.ToString() != null ? "$" + qd.LatestPrice.ToString("0.##") + " ▲" : "No Information";

                    LBL_Company_Opening_price.Text =
                            qd.Open.ToString() != null ? "$" + qd.Open.ToString("0.##") : "No Information";

                    LBL_Company_CEO.Text = cid.Ceo != "" ? cid.Ceo : "No Information";
                    LBL_LINK.Text = cid.Website != "" ? cid.Website : "No Information";

                    LB_DESCRIPTION.Text = LB_DESCRIPTION.Text != "" ? $"{cid.Description}" : "No Information";
                    LB_DAY_RANGE.Text =
                        qd.Low.ToString() != null && qd.High.ToString() != null ? $"{qd.Low.ToString("0.##")} - {qd.High.ToString("0.##")}" : "No Information";
                    LB_WEEK_RANGE.Text =
                        qd.Week52Low.ToString() != null && qd.Week52High.ToString() != null ? $"{qd.Week52Low.ToString("0.##")} - {qd.Week52High.ToString("0.##")}" : "No Information";

                    LB_PE_RATIO.Text = qd.PeRatio.ToString() != null ? $"{qd.PeRatio}" : "No Information";

                    LB_BETA.Text = fd.Beta != 0 ?  $"{fd.Beta}" : "No Information";
                    LB_REVENUE.Text = fd.Revenue != 0 ? $"{fd.Revenue.ToString("#,##0,,M")}" : "No Information";
                    LB_REV_PER_EMPLOYEE.Text = fd.RevenuePerEmployee!= 0 ? $"{fd.RevenuePerEmployee.ToString("#,##0,K")}" : "No Information";
                    LB_MARKETCAP.Text = fd.Marketcap != 0 ? $"{fd.Marketcap.ToString("#,##0,,M")}" : "No Information";
                }
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error " + e.Message);
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
                if (!Main_Menu.searchableNames.Contains(search))
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
                MessageBox.Show("Error " + ex.Message);
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
                MessageBox.Show("Error " + e.Message);
            }

        }

        private void LBL_LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LBL_LINK.Text);
        }

        private Point? prevPosition = null;
        private ToolTip toolTip = new ToolTip();
        private void stocksChart_MouseMove(object sender, MouseEventArgs e)
        {
            var position = e.Location;
            if (prevPosition.HasValue && position == prevPosition.Value)
                return;
            toolTip.RemoveAll();
            prevPosition = position;

            var results = stocksChart.HitTest(position.X, position.Y, false, ChartElementType.DataPoint);

            foreach (var r in results)
            {
                if (r.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = r.Object as DataPoint;

                    if (prop != null)
                    {
                        var pointX = r.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointY = r.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        if (Math.Abs(position.X - pointX) < 8 &&
                            Math.Abs(position.Y - pointY) < 8)
                        {
                            toolTip.Show("$" + prop.YValues[0].ToString("0.##"), this.stocksChart,
                                        position.X, position.Y - 15);
                        }
                    }
                }
            }
        }
    }
}
