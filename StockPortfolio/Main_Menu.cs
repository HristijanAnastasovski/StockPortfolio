using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string _newsSymbol;
        public List<string> links;

        public Main_Menu()
        {
            InitializeComponent();
            InitializeStockSearchBox();
            _newsSymbol = "TSLA";
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

                tbSearchNews.AutoCompleteCustomSource = searchableSymbols;
                tbSearchNews.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbSearchNews.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch(System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error" + e.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Proverva dali ima internet
            // na start na programata
            API.hasInternet();

            pbLoading.Hide();
            Welcome_Form welcome_Form = new Welcome_Form();
            welcome_Form.ShowDialog();
            UrlNews1.Text = "";
            UrlNews2.Text = "";
            UrlNews3.Text = "";
            links = new List<string>();
            await updateMostPopularList();
            pbLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            await updateNews(_newsSymbol);

           // UrlNews1.MaximumSize = new Size(550, 0);
           // UrlNews2.MaximumSize = new Size(550, 0);
           // UrlNews3.MaximumSize = new Size(550, 0);
           // NewsSummary1.MaximumSize = new Size(500, 300);
           // NewsSummary2.MaximumSize = new Size(500, 300);
           // NewsSummary3.MaximumSize = new Size(500, 300);
        }

        private void BTN_Search_Stocks_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
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
                MessageBox.Show("Error " + ex.Message);
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
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            await updateMostPopularList();
            await updateNews(_newsSymbol);
        }

        //vrakja symbol za vlez {ime na firma (symbol)}
        public static string getSymbol(string s)
        {
            string pattern = @"\(([^()]+)\)";
            string input = s;
            string [] array = Regex.Split(input, pattern);

            if (array.Length == 5)
            {
                return array[3];
            }
            else if (array.Length == 3)
            {
                return array[1];
            }
            else
            {
                return null;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            StockCalculator sc = new StockCalculator();
            sc.ShowDialog();
        }

        private async Task updateMostPopularList()
        {
            BTN_Refresh.Enabled = false;
            Loading_Most_Popular.Enabled = true;
            Loading_Most_Popular.Show();
            Loading_Recent_News.Enabled = true;
            Loading_Recent_News.Show();
            HideNewsLabels();

            lvMostPopular.Items.Clear();
            var description = string.Format("{0, -32} {1, -11} {2, -5}", "Name", "Price", "Difference");
            lvMostPopular.Items.Add(description);

            try
            {
                var data = await API.GetBatchQuoteData(mostPopularCompanies); //fraerski prakjame niza simboli
                foreach (var symbol in data.Values)
                {

                    if (symbol.Quote.calculateDifference() > 0)
                        lvMostPopular.Items.Add(symbol.Quote.ToString()).ForeColor = Color.Green;
                    else if (symbol.Quote.calculateDifference() < 0)
                        lvMostPopular.Items.Add(symbol.Quote.ToString()).ForeColor = Color.Red;
                    else
                        lvMostPopular.Items.Add(symbol.Quote.ToString()).ForeColor = Color.Black;
                }
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }

            BTN_Refresh.Enabled = true;
            Loading_Most_Popular.Enabled = false;
            Loading_Most_Popular.Hide();
            Loading_Recent_News.Enabled = false;
            Loading_Recent_News.Hide();
        }

        private void HideNewsLabels()
        {
            UrlNews1.Hide();
            UrlNews2.Hide();
            UrlNews3.Hide();

            NewsSummary1.Hide();
            NewsSummary2.Hide();
            NewsSummary3.Hide();

            label1.Hide();
            label2.Hide();
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

        private async Task updateNews(string symbol)
        {
            UrlNews1.LinkVisited = false;
            UrlNews2.LinkVisited = false;
            UrlNews3.LinkVisited = false;
            links.Clear();
            try
            {
                GroupBox_Top_Today.Text = $"Recent News ({symbol})";
                //UrlNews1.MaximumSize = new Size(320, 0);
                List<NewsDto> list = new List<NewsDto>();
                list.AddRange(await API.GetNews(symbol, 3));

                foreach(var dto in list)
                {
                    links.Add(dto.Url);
                }

                if (list.Count ==3)
                {
                    UrlNews1.Text = list[0].Headline;
                    UrlNews2.Text = list[1].Headline;
                    UrlNews3.Text = list[2].Headline;

                    NewsSummary1.Text = 
                        list[0].Summary != "No summary available." ? list[0].Summary : "       " + list[0].Summary;
                    NewsSummary2.Text = 
                        list[1].Summary != "No summary available." ? list[1].Summary : "       " + list[1].Summary;
                    NewsSummary3.Text = 
                        list[2].Summary != "No summary available." ? list[2].Summary : "       " + list[2].Summary;

                    label1.Show();
                    label2.Show();
                    UrlNews1.Show();                                                                           
                    NewsSummary1.Show();                                                                       
                    UrlNews2.Show();                                                                           
                    NewsSummary2.Show();                                                                       
                    UrlNews3.Show();                                                                           
                    NewsSummary3.Show();                                                                       
                }                                                                                              
                else if (list.Count == 2)                                                                      
                {                                                                                              
                    UrlNews1.Text = list[0].Headline;                                                          
                    UrlNews2.Text = list[1].Headline;                                                          
                                                                                                               
                    NewsSummary1.Text = list[0].Summary != "No summary available." ? list[0].Summary : "       " + list[0].Summary;
                    NewsSummary2.Text = list[1].Summary != "No summary available." ? list[1].Summary : "       " + list[0].Summary;

                    label1.Show();
                    UrlNews1.Show();
                    NewsSummary1.Show();
                    UrlNews2.Show();
                    NewsSummary2.Show();
                    UrlNews3.Hide();
                    NewsSummary3.Hide();
                }
                else if (list.Count == 1)
                {
                    UrlNews1.Text = list[0].Headline;
                    NewsSummary1.Text = list[0].Summary != "No summary available." ? list[0].Summary : "       " + list[0].Summary;

                    UrlNews1.Show();
                    NewsSummary1.Show();
                    UrlNews2.Hide();
                    NewsSummary2.Hide();
                    UrlNews3.Hide();
                    NewsSummary3.Hide();
                }
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void Url1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(links[0]!=null)
            {
                UrlNews1.LinkVisited = true;
                Process.Start(links[0]);
            }
        }

        private void UrlNews2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (links[1] != null)
            {
                UrlNews2.LinkVisited = true;
                Process.Start(links[1]);
            }
        }

        private void UrlNews3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (links[2] != null)
            {
                UrlNews3.LinkVisited = true;
                Process.Start(links[2]);
            }
        }

        private async void btnSearchNews_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Windows_Navigation_Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            var searchString = tbSearchNews.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(searchString) || await API.GetCompanyInfo(Main_Menu.getSymbol(searchString)) == null)
                {
                    newsSearchErrorProvider.SetError(tbSearchNews, "Please enter a valid search");
                }
                else
                {
                    newsSearchErrorProvider.Clear();
                    _newsSymbol = Main_Menu.getSymbol(searchString);
                    await updateNews(_newsSymbol);
                }
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something bad happened");
            }
        }
    }
}