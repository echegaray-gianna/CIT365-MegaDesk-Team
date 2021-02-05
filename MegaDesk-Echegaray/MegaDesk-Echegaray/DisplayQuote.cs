using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace MegaDesk_Echegaray
{
    public partial class DisplayQuote : Form
    {
        DeskQuote DeskQuote = new DeskQuote();
        
        AddQuote addQuote = new AddQuote();
        
      
        public string date { get; set; }
        public string clientName { get; set; }


        public DisplayQuote(string currentDateInfo, string customerInfo, string areaTotal, string drawerTotal, string materialSelected, string materialTotal, string shippingSelected, string shippingTotal, string totalDesk)
        {
            InitializeComponent();

            quoteDate.Text = currentDateInfo;
            custName.Text = customerInfo;
            areaCost.Text = areaTotal;
            drawerCost.Text = drawerTotal;
            materialName.Text = materialSelected;
            materialCost.Text = materialTotal;
            shippingMethod.Text = shippingSelected;
            shippingCost.Text = shippingTotal;
            totalCost.Text = totalDesk;



            // This is used to create the JSON FILE to store the info 
            DeskQuote DeskQuoteInfo = new DeskQuote();

            DeskQuoteInfo.currentDate = currentDateInfo;
            DeskQuoteInfo.customerInfo = customerInfo;
            DeskQuoteInfo.areaTotal = areaTotal;
            DeskQuoteInfo.drawerTotal = drawerTotal;
            DeskQuoteInfo.materialSelected = materialSelected;
            DeskQuoteInfo.materialTotal = materialTotal;
            DeskQuoteInfo.shippingSelected = shippingSelected;
            DeskQuoteInfo.shippingTotal = shippingTotal;
            DeskQuoteInfo.totalDesk = totalDesk;

            //try
            //{

            //    string jsonData = JsonConvert.SerializeObject(DeskQuoteInfo, Formatting.Indented);
            //    string path = "quotes.json";

            //    if (jsonData != null && jsonData != "")
            //    {
            //        File.AppendAllText(path, jsonData + Environment.NewLine);
            //    }
            //    else
            //    {
            //        File.WriteAllText(path, jsonData);
            //    }

            //}
            //catch (IOException e)
            //{

            //}

        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            Close();
        }
    }
}
