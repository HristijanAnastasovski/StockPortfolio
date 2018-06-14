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

        private void Search_Result_Form_Load(object sender, EventArgs e)
        {
            fillLabels(searchString);
            paintGraph(searchString);

        }

        private void InitializeStockSearchBox()
        {
            //TB_Search_Stocks.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
            searchableSymbols.AddRange(IEX_API.API.GetSymbols());
            TB_Search_Again.AutoCompleteCustomSource = searchableSymbols;
            TB_Search_Again.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Search_Again.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BTN_Close_Search_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillLabels(string str)
        {
            IEX_API.DTOs.QuoteDto qd = IEX_API.API.GetQuote(Main_Menu.getSymbol(str));
            IEX_API.DTOs.CompanyInfoDto cid = IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(str));
            if(cid!=null && qd!=null)
            { 
            LBL_Company_Name.Text = qd.CompanyName;
            LBL_Company_market.Text = qd.PrimaryExchange.ToString();
            LBL_Company_Sector.Text = qd.Sector.ToString();
            if (qd.Open > qd.LatestPrice)
                LBL_Company_Current_Price.Text = "$" + qd.LatestPrice.ToString("0.##") + " ▼";
            else
                LBL_Company_Current_Price.Text = "$" + qd.LatestPrice.ToString("0.##") + " ▲";
            LBL_Company_Opening_price.Text = "$" + qd.Open.ToString("0.##");
            LBL_Company_CEO.Text = cid.Ceo;
            LBL_LINK.Text = cid.Website;
            }

        }

       

        private void BTN_Search_Again_Click(object sender, EventArgs e)
        {
            pbLoading.Show();
            pbLoading.Enabled = true;
            string search = TB_Search_Again.Text;
            if (string.IsNullOrWhiteSpace(search) || IEX_API.API.GetQuote(Main_Menu.getSymbol(search)) == null || IEX_API.API.GetCompanyInfo(Main_Menu.getSymbol(search))==null)
            {
                ErrorProvider_Search_Error.SetError(TB_Search_Again, "Please enter a valid search");
            }
            else
            {
                ErrorProvider_Search_Error.Clear();
                fillLabels(TB_Search_Again.Text);
                DrawArea = new Bitmap(PB_PAINT.Size.Width, PB_PAINT.Size.Height);
                paintGraph(TB_Search_Again.Text);
            }
            pbLoading.Hide();
            pbLoading.Enabled = false;
        }

        private void paintGraph(string str)
        {
            IReadOnlyDictionary<DateTimeOffset, IEX_API.DTOs.HistoricalDataDto> dictionary = IEX_API.API.GetHistoricalData(Main_Menu.getSymbol(str));
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
            
        }

        private void LBL_LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(LBL_LINK.Text);
        }
    }
}
