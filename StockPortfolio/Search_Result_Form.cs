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
            DrawArea = new Bitmap(PB_PAINT.Size.Width, PB_PAINT.Size.Height);
            PB_PAINT.Image = DrawArea;
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
            //TB_Search_Stocks.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
            searchableSymbols.AddRange(await IEX_API.API.GetSymbols());
            TB_Search_Again.AutoCompleteCustomSource = searchableSymbols;
            TB_Search_Again.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Search_Again.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BTN_Close_Search_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task fillLabels(string str)
        {
            IEX_API.DTOs.QuoteDto qd = await IEX_API.API.GetQuote(Main_Menu.getSymbol(str));
            IEX_API.DTOs.CompanyInfoDto cid = await IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(str));
            if(cid!=null && qd!=null)
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

       

        private async void BTN_Search_Again_Click(object sender, EventArgs e)
        {
            pbLoading.Show();
            pbLoading.Enabled = true;
            string search = TB_Search_Again.Text;
            if (string.IsNullOrWhiteSpace(search) || await IEX_API.API.GetQuote(Main_Menu.getSymbol(search)) == null
                || await IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(search))==null)
            {
                ErrorProvider_Search_Error.SetError(TB_Search_Again, "Please enter a valid search");
            }
            else
            {
                ErrorProvider_Search_Error.Clear();
                await fillLabels(TB_Search_Again.Text);
                DrawArea = new Bitmap(PB_PAINT.Size.Width, PB_PAINT.Size.Height);
                await paintGraph(TB_Search_Again.Text);
            }
            pbLoading.Hide();
            pbLoading.Enabled = false;
        }

        private async Task paintGraph(string str)
        {
            IReadOnlyDictionary<DateTimeOffset, IEX_API.DTOs.HistoricalDataDto> dictionary = 
                await IEX_API.API.GetHistoricalData(Main_Menu.getSymbol(str));

            Graphics g;
            g = Graphics.FromImage(DrawArea);
            
            Pen black = new Pen(Color.Black,2);

            float max=0;
            float height = PB_PAINT.Height;
            double[] array = new double[dictionary.Values.Count()];           
            int i = 0;
            foreach (DateTimeOffset data in dictionary.Keys)
            {
                if (max < dictionary[data].High)
                    max = (float)dictionary[data].High;
                array[i] = dictionary[data].High;
                i++;
            }

            float coef = 1;
            if(max>height)
            {
                coef = height / max;
            }

            
            int x = 0;
            for(int j=0;j<array.Count()-1;j++)
            {
                
                g.DrawLine(black, x,(float)(height-(array[j]*coef)), x + 30, (float)(height - (array[j+1] * coef)));
                
                x +=30;
                
            }

            black.Dispose();
            g.Dispose();
        }

        private void LBL_LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LBL_LINK.Text);
        }
    }
}
