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
    public partial class Network_Check_Form : Form
    {
        // Kolku vreme da otcuka tajmerot
        public int Time = 5;

        // Kolku pati da proba samoto
        // za internet proverka
        public int Retries = 1;

        // nekoi properties za formata
        // niso bitno
        public Network_Check_Form()
        {
            InitializeComponent();
            this.ControlBox = false;
            LBL_Reconnect.Hide();
            PB_Load_Net.Hide();
            Timer.Enabled = false;
        }

        // Ja gasi programata ako stisne Quit
        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Proveruva za internet dali ima na sekoi 5s
        private void BTN_Retry_Reconnect_Click(object sender, EventArgs e)
        {
            Retries = 1;
            LBL_Retry_Count.Text = "Retry count: " + Retries.ToString();
            BTN_Retry_Reconnect.Enabled = false;
            Time = 5;
            LBL_Reconnect.Hide();
            PB_Load_Net.Enabled = true;
            PB_Load_Net.Show();
            Timer.Enabled = true;
            Timer.Start();
        }

        // Timer tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(API.hasInternet())
            {
                Timer.Stop();
                Timer.Enabled = false;
                this.Close();
                return;
            }

            Time--;
            if(Time <= 0)
            {
                BTN_Retry_Reconnect.Enabled = false;
                Retries++;
                LBL_Retry_Count.Text = "Retry count: " + Retries.ToString();
                Time = 5;
            }

            // Ako nadmine retry limit,
            // samiot da stisne korisnik retry
            if(Retries >= 5)
            {
                PB_Load_Net.Enabled = false;
                Timer.Stop();
                Timer.Enabled = false;
                LBL_Reconnect.Text = "Reconnection timed out.\n           Try again?";
                LBL_Reconnect.Show();
                BTN_Retry_Reconnect.Enabled = true;
            }
        }

        private void Network_Check_Form_Load(object sender, EventArgs e)
        {
            Retries = 1;
            PB_Load_Net.Enabled = true;
            PB_Load_Net.Show();
            Timer.Enabled = true;
            Timer.Start();
            BTN_Retry_Reconnect.Enabled = false;
        }
    }
}