using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace StockPortfolio
{
    public partial class MyStocks : Form
    {
        public List<string> myStocks;
        public string FileName;
        public MyStocks()
        {
            InitializeComponent();
            myStocks = new List<string>();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            { // has not been saved yet
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Stocks file (*.s)|*.s";
                saveFileDialog1.Title = "Save a Stocks File";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileName = saveFileDialog1.FileName;
            }
            if (FileName != null)
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                using (var stream = File.OpenWrite(FileName))
                {
                    serializer.Serialize(stream, myStocks);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Stocks file (*.s)|*.s";
            openFileDialog1.Title = "Save a Stocks File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
            }
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.OpenRead(FileName))
            {
                var list = (List<string>)(serializer.Deserialize(stream));
                myStocks.Clear();
                myStocks.AddRange(list);
            }
            fillList();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillList()
        {
            foreach (string s in myStocks)
                myStocksList.Items.Add(s);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myStocks.Add(tbName.Text);
            myStocksList.Items.Add(tbName.Text);
            
        }
    }
}
