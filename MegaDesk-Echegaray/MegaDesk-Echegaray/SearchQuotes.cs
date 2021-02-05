using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MegaDesk_Echegaray
{
    public partial class SearchQuotes : Form
    {
        string listboxFormat = "{0,-15}\t{1,-20}\t{1,-20}\t{1,-20}\t{1,-20}";
        public SearchQuotes()
        {
            InitializeComponent();
            CreateHeadRowSearchListBox();
        }
        void CreateHeadRowSearchListBox()
        {
            searchListBox.Items.Clear();
            searchListBox.Items.Add(string.Format(listboxFormat,"Material", "Cusotmer Name","Quote Date","Desk Specs","Price"));
        }

        private void btnSearchQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void searchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string material = materialComboBox.Text;
            string path = @"C:\Users\Gianna\source\repos\CIT365-MegaDesk-Team\MegaDesk-Echegaray\MegaDesk-Echegaray\quotes.json";
            var json = System.IO.File.ReadAllText(path);
            List<DeskQuote> quotes = new List<DeskQuote>();
            quotes = JsonConvert.DeserializeObject<DeskQuote>(json);

        }
    }
}
