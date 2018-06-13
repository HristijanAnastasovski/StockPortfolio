using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockPortfolio.IEX_API;

namespace StockPortfolio
{
    public partial class Main_Menu : Form
    {
        public string search;

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
            Welcome_Form welcome_Form = new Welcome_Form();
            welcome_Form.ShowDialog();
        }

        private void BTN_Search_Stocks_Click(object sender, EventArgs e)
        {
            search = TB_Search_Stocks.Text;
            if(string.IsNullOrWhiteSpace(search))
            {
                ErrorProvider_Search_Error.SetError(TB_Search_Stocks, "Please enter a valid search");
            }
            else
            {
                ErrorProvider_Search_Error.Clear();
                // da se isprati podatokot vo Search_Form
                // Load_Search(search);
                Search_Result_Form srf = new Search_Result_Form();
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
    }
}