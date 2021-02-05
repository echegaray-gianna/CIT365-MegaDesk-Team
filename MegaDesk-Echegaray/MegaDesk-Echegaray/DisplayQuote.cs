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

        AddQuote addQuote = new AddQuote();
        DeskQuote DeskQuote = new DeskQuote();

        public string date { get; set; }
        public string clientName { get; set; }


        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            string currentDate = addQuote.currentDateInfo();
            string custtomerInfo = addQuote.customerInfo();
            string areaTotal = Convert.ToString(addQuote.getInput());
            string drawerTotal = Convert.ToString(addQuote.DrawersCalc());
            string materialSelected = addQuote.DesktopMaterial_SelectedIndexChanged();
            string materialTotal = Convert.ToString(addQuote.deskMaterial());
            string shippingSelected = addQuote.shippingDays_Selected();
            string shippingTotal = Convert.ToString(addQuote.shippingDays_SelectedIndexChanged());
            string deskTotal = Convert.ToString(addQuote.totalMath());

            DeskQuote.currentDate = addQuote.currentDateInfo();
            DeskQuote.customerInfo = addQuote.customerInfo();
            DeskQuote.areaTotal = Convert.ToString(addQuote.getInput());
            DeskQuote.drawerTotal = Convert.ToString(addQuote.DrawersCalc());
            DeskQuote.materialSelected = addQuote.DesktopMaterial_SelectedIndexChanged();
            DeskQuote.materialTotal = Convert.ToString(addQuote.deskMaterial());
            DeskQuote.shippingSelected = addQuote.shippingDays_Selected();
            DeskQuote.shippingTotal = Convert.ToString(addQuote.shippingDays_SelectedIndexChanged());
            DeskQuote.totalDesk = Convert.ToString(addQuote.totalMath());

            quoteDate.Text = currentDate;
            custName.Text = custtomerInfo;
            areaCost.Text = areaTotal;
            drawerCost.Text = drawerTotal;
            materialName.Text = materialSelected;
            materialCost.Text = materialTotal;
            shippingMethod.Text = shippingSelected;
            shippingCost.Text = shippingTotal;
            totalCost.Text = deskTotal;




            // This is used to create the JSON FILE to store the info 
            DeskQuote DeskQuoteInfo = new DeskQuote();

            DeskQuoteInfo.currentDate = currentDate;
            DeskQuoteInfo.customerInfo = custtomerInfo;
            DeskQuoteInfo.areaTotal = areaTotal;
            DeskQuoteInfo.drawerTotal = drawerTotal;
            DeskQuoteInfo.materialSelected = materialSelected;
            DeskQuoteInfo.materialTotal = materialTotal;
            DeskQuoteInfo.shippingSelected = shippingSelected;
            DeskQuoteInfo.shippingTotal = shippingTotal;
            DeskQuoteInfo.totalDesk = deskTotal;

            try
            {
                string jsonData = JsonConvert.SerializeObject(DeskQuoteInfo, Formatting.Indented);
                string path = "quotes.json";



                if (jsonData != null && jsonData != "")
                {
                    File.AppendAllText(path, jsonData + Environment.NewLine);
                }
                else
                {
                    File.WriteAllText(path, jsonData);
                }



            }
            catch (IOException e)
            {

            }

        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            Close();
        }
    }
}
