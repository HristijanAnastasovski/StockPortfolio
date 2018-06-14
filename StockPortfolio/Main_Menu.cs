using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockPortfolio.IEX_API;
using StockPortfolio.IEX_API.DTOs;

namespace StockPortfolio
{
    public partial class Main_Menu : Form
    {
        public string search;

        public static string[] mostPopularCompanies = {"AAPL","MSFT","NIKE","TWTR","AMZN","FB", "TMUS", "NFLX", "RHT", "ORCL", "F", "SNE", "EA"
                                                        ,"T", "DIS", "HPQ", "ORCL", "TWX"};
        public Main_Menu()
        {
            InitializeComponent();
            InitializeStockSearchBox();
        }

        private async void InitializeStockSearchBox()
        {
            //TB_Search_Stocks.CharacterCasing = CharacterCasing.Upper;
            try
            {
                AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
                searchableSymbols.AddRange(await API.GetSymbols());
                TB_Search_Stocks.AutoCompleteCustomSource = searchableSymbols;
                TB_Search_Stocks.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TB_Search_Stocks.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("B E L J A" + e.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pbLoading.Hide();
            Welcome_Form welcome_Form = new Welcome_Form();
            welcome_Form.ShowDialog();
            await updateMostPopularList();
            pbLoading.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void BTN_Search_Stocks_Click(object sender, EventArgs e)
        {
            search = TB_Search_Stocks.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(search) || API.GetQuote(getSymbol(search)) == null || API.GetCompanyInfo(Main_Menu.getSymbol(search)) == null)
                {
                    ErrorProvider_Search_Error.SetError(TB_Search_Stocks, "Please enter a valid search");

                }
                else
                {
                    pbLoading.Show();
                    ErrorProvider_Search_Error.Clear();
                    Search_Result_Form srf = new Search_Result_Form();
                    srf.searchString = TB_Search_Stocks.Text.ToString();

                    pbLoading.Hide();
                    srf.ShowDialog();


                }

            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("BELJA! " + ex.Message);
            }
        }

        private void PB_Main_Logo_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.cash_register_sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private async void BTN_Refresh_Click(object sender, EventArgs e)
        {
            await updateMostPopularList();
        }

        //vrakja symbol za vlez {ime na firma (symbol)}
        public static string getSymbol(string s)
        {
            string pattern = @"\(([^()]+)\)";
            string input = s;
            string [] array = Regex.Split(input, pattern);
            if (array.Length == 5)
                return array[3];
            else if (array.Length == 3)
                return array[1];
            else
                return null;
            
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            StockCalculator sc = new StockCalculator();
            sc.ShowDialog();
        }

        private async Task updateMostPopularList()
        {
            lvMostPopular.Items.Clear();
            var description = string.Format("{0, -32} {1, -15} {2, 10}", "Name", "Price", "Difference");
            lvMostPopular.Items.Add(description);
            List<MostPopularStockElement> mpc = new List<MostPopularStockElement>();

            try
            {
                foreach (string symbol in mostPopularCompanies)
                {
                    //API.GetQuote(symbol);
                    if (await API.FilteredGetQuote(symbol) != null)
                    {
                        QuoteDto q = await API.FilteredGetQuote(symbol);
                        MostPopularStockElement p = new MostPopularStockElement(q);
                        mpc.Add(p);
                    }

                }

                foreach (var p in mpc)
                {
                    if (p.calculateDifference() > 0)
                        lvMostPopular.Items.Add(p.ToString()).ForeColor = Color.Green;
                    else if (p.calculateDifference() < 0)
                        lvMostPopular.Items.Add(p.ToString()).ForeColor = Color.Red;
                    else
                        lvMostPopular.Items.Add(p.ToString()).ForeColor = Color.Black;
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

        private void lvMostPopular_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(lvMostPopular.SelectedItems[0].SubItems[0].Text);
            Search_Result_Form srf = new Search_Result_Form();
            var s = lvMostPopular.SelectedItems[0].SubItems[0].Text.ToString();
            srf.searchString = s.Substring(0, s.Length-7); //trgni procent vo zagrada da ne zamara za parsiranje so regex posle 
            srf.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form af = new About_Form();
            af.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Form hf = new Help_Form();
            hf.ShowDialog();
        }
    }
}