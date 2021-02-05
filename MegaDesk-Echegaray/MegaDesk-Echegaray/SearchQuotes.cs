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
        string listboxFormat = "{0,-15}\t{1,-20}\t{2,-20}\t{3,-20}\t{4,-20}\t{5,-20}";
        List<DeskQuote> searchedQuotes = new List<DeskQuote>();
        public SearchQuotes()
        {
            InitializeComponent();
            DeskQuote.GetQueryList();
            CreateHeadRowSearchListBox();
        }
        void CreateHeadRowSearchListBox()
        {
            searchListBox.Items.Clear();
            searchListBox.Items.Add(string.Format(listboxFormat,"Material", "Cusotmer Name","Quote Date","Desk Area","Desk Drawers","Price"));
        }

        private void btnSearchQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
        private string GetDeskAreaFromAreaTotal(string areaTotal)
        {
            int areaPrice = 0;
            string result = "";
            try
            {
                if(areaTotal != null || !areaTotal.Equals(""))
                {
                    areaPrice = Int32.Parse(areaTotal);
                    if (areaPrice == 200)
                    {
                        result = "maximum 1000(in*in)";
                    } else if (areaPrice > 200)
                    {
                        int extra = areaPrice - 200;
                        int extraIn = 1000 + extra;
                        result = extraIn.ToString();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Invalid Area");
            }
            return result;
        }
        private string GetDeskDrawerFromDrawerTotal(string drawerTotal)
        {
            int drawerPrice = 0;
            string result = "";
            try
            {
                if (drawerTotal != null || !drawerTotal.Equals(""))
                {
                    drawerPrice = Int32.Parse(drawerTotal);
                    int drawerCount = drawerPrice / 50;
                    result = drawerCount.ToString();
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show("Invalid Drawer count");
            }
            return result;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string material = materialComboBox.Items.ToString();
            foreach(DeskQuote quote in DeskQuote.dqList)
            {
                if(quote.materialSelected.Equals(material))
                {
                    searchedQuotes.Add(quote);
                }
            }
            foreach(DeskQuote quote in searchedQuotes)
            {
                string area = GetDeskAreaFromAreaTotal(quote.areaTotal);
                string drawerCount = GetDeskDrawerFromDrawerTotal(quote.drawerTotal);
                searchListBox.Items.Add(string.Format(listboxFormat,quote.customerInfo,quote.currentDate,area,drawerCount,quote.totalDesk));
            }
        }
    }
}
