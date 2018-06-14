using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockPortfolio.IEX_API;

namespace StockPortfolio
{
    public partial class Main_Menu : Form
    {
        public string search;

        public static string[] mostPopularCompanies = {"AAPL","MSFT","NIKE","TWTR","AMZN","FB", "TMUS", "NFLX", "RHT", "ORCL", "F", "MRVL", "SNE", "EA" };
        public Main_Menu()
        {
            InitializeComponent();
            InitializeStockSearchBox();
        }

        private void InitializeStockSearchBox()
        {
            //TB_Search_Stocks.CharacterCasing = CharacterCasing.Upper;
            AutoCompleteStringCollection searchableSymbols = new AutoCompleteStringCollection();
            searchableSymbols.AddRange(API.GetSymbols());
            TB_Search_Stocks.AutoCompleteCustomSource = searchableSymbols;
            TB_Search_Stocks.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Search_Stocks.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbLoading.Hide();
            Welcome_Form welcome_Form = new Welcome_Form();
            welcome_Form.ShowDialog();
            updateMostPopularList();
            pbLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            

        }

        private void BTN_Search_Stocks_Click(object sender, EventArgs e)
        {
            search = TB_Search_Stocks.Text;
            
           
            if (string.IsNullOrWhiteSpace(search) || API.GetQuote(getSymbol(search))==null || API.GetCompanyInfo(Main_Menu.getSymbol(search)) == null)
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

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_about_Click(object sender, EventArgs e)
        {
            About_Form af = new About_Form();
            af.ShowDialog();
        }

        private void PB_Main_Logo_Click(object sender, EventArgs e)
        {
            // nejke, glupost e, me mrzi da namestam relative path

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer
            //{
            //    SoundLocation = @"sound\money.wav"
            //};
            //player.Play();
            System.IO.Stream str = Properties.Resources.cash_register_sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            // TO DO
            // treba refresh na listite
            // ili neka bide avtomatsko so timer
            // ama moze i dvete za ako ne uspee
            // timer... force refresh
        }

        private void BTN_help_Click(object sender, EventArgs e)
        {
            Help_Form hf = new Help_Form();
            hf.ShowDialog();
        }

        //vrakja symbol za vlez {ime na firma (symbol)}
        public static string getSymbol(string s)
        {
            string pattern = @"\(([^()]+)\)";
            string input = s;
            string [] array = Regex.Split(input, pattern);
            if (array.Length > 1)
                return array[1];
            else
                return null;
            
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            StockCalculator sc = new StockCalculator();
            sc.ShowDialog();
        }

       







        private void updateMostPopularList()
        {
            lvMostPopular.Items.Clear();
            foreach (string symbol in mostPopularCompanies)
            {
                //API.GetQuote(symbol);
                if (API.FilteredGetQuote(symbol) != null)
                {
                    MostPopularStockElement p = new MostPopularStockElement(API.FilteredGetQuote(symbol));
                    
                    if(p.calculateDifference()>0)
                        lvMostPopular.Items.Add(p.ToString()).ForeColor=Color.Green;
                    else if(p.calculateDifference() < 0)
                        lvMostPopular.Items.Add(p.ToString()).ForeColor = Color.Red;
                    else
                        lvMostPopular.Items.Add(p.ToString()).ForeColor = Color.LightBlue;
                }
                
            }
          }

    }
}