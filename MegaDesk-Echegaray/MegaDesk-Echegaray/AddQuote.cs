using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;





namespace MegaDesk_Echegaray
{
    public partial class AddQuote : Form
    {
        DeskQuote dq = new DeskQuote();


        public AddQuote()
        {
            InitializeComponent();
            DesktopMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterialList));

        }

        //Add Current Date
        public void AddQuote_Load(object sender, EventArgs e)
        {
            currentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");

        }

        // VALIDATION!!!
        private void InputWidth_Validating(object sender, CancelEventArgs e)
        {

            try
            {

                if (!InputWidth.Text.All(Char.IsDigit) && !InputWidth.Text.All(Char.IsControl))
                {
                    InputWidth.Text = "";
                    InputWidth.BackColor = Color.Red;
                    string message = "Please enter a number";
                    string title = "Error";
                    MessageBox.Show(message, title);

                }
                else if (double.Parse(InputWidth.Text) < Desk.minWidth)
                {
                    InputWidth.Text = "";
                    InputWidth.BackColor = Color.Red;
                    string message = "The minimun width size is 24 in.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
                else if (double.Parse(InputWidth.Text) > Desk.maxWidth)
                {
                    InputWidth.Text = "";
                    InputWidth.BackColor = Color.Red;
                    string message = "The maximun width size is 96 in.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
                else
                {
                    InputWidth.BackColor = Color.Green;

                }


            }
            catch
            {
                InputWidth.Text = "";
                InputWidth.BackColor = Color.Red;
                string message = "Invalid input. Please try again ";
                string title = "Error";
                MessageBox.Show(message, title);
            }

        }

        private void InputDepth_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                InputDepth.BackColor = Color.Red;
                string message = "Please enter a number";
                string title = "Error";
                MessageBox.Show(message, title);
            }


        }

        private void InputDepth_Validated(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(InputDepth.Text) < Desk.minDepth)
                {
                    InputDepth.Text = "";
                    InputDepth.BackColor = Color.Red;
                    string message = "The minimun depth size is 12 in.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
                else if (double.Parse(InputDepth.Text) > Desk.maxDepth)
                {
                    InputDepth.Text = "";
                    InputDepth.BackColor = Color.Red;
                    string message = "The maximun depth size is 48 in.";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }
                else
                {
                    InputDepth.BackColor = Color.Green;
                }

            }
            catch
            {
                InputDepth.Text = "";
                InputDepth.BackColor = Color.Red;
                string message = "Invalid input. Please try again ";
                string title = "Error";
                MessageBox.Show(message, title);
            }


        }

        // END OF VALIDATION!!!


        // Getting information and send them to desk Quote for calculation

        //Area Cost
        public int getInput()
        {
            int inputwidth = Int32.Parse(InputWidth.Text);
            int inputDepth = Int32.Parse(InputDepth.Text);
            int areaCost = dq.areaCalc(inputwidth, inputDepth);
            return areaCost;

        }


        //Drawers Cost
        public int DrawersCalc()
        {
            int drawers = Int32.Parse(DrawersNumber.Text);
            int drawerCost = dq.drawersCalc(drawers);
            return drawerCost;
        }


        //Desk Material Selected
        public string DesktopMaterial_SelectedIndexChanged()
        {
            string materialName = DesktopMaterial.SelectedItem.ToString();

            return materialName;

        }


        //Desk Material Cost
        public int deskMaterial()
        {
            string materialChosen = DesktopMaterial_SelectedIndexChanged();
            string material = materialChosen;
            int materialPrice = dq.deskMaterialCalc(material);

            return materialPrice;
        }


        //Shipping Selected
        public string shippingDays_Selected()
        {
            string shippingMethod = shippingDays.SelectedItem.ToString();

            return shippingMethod;
        }


        //Shipping Cost
        public int shippingDays_SelectedIndexChanged()
        {
            string RushDays = shippingDays.Text.ToString();
            int areaCost = getInput();
            int shippingCost = dq.shippingCost(RushDays, areaCost);
            return shippingCost;
        }


        //Total Cost 

        public int totalMath()
        {
            //price for  area
            int areaCost = getInput();

            //price for drawers
            int drawerCost = DrawersCalc();

            //price for material 
            int materialPrice = deskMaterial();

            //price for Shipping
            int shippingCost = shippingDays_SelectedIndexChanged();

            //Taking all the prices and send them to dq to calculation
            int totalCost = dq.totalCalc(areaCost, drawerCost, materialPrice, shippingCost);

            return totalCost;
        }

        // Submit Botton 
        public void btnAddQuoteSbt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(customerName.Text) || string.IsNullOrEmpty(InputWidth.Text) ||
                string.IsNullOrEmpty(InputDepth.Text) || string.IsNullOrEmpty(DesktopMaterial.Text) ||
                 string.IsNullOrEmpty(shippingDays.Text) || string.IsNullOrEmpty(DrawersNumber.Text))
            {
                string message = "Please enter all the inputs.";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                //Display the the results and selected options in the display quote
                string currentDateInfo = currentDate.Text;
                string customerInfo = customerName.Text;
                string areaTotal = Convert.ToString(getInput());
                string drawerTotal = Convert.ToString(DrawersCalc());
                string materialSelected = DesktopMaterial_SelectedIndexChanged();
                string materialTotal = Convert.ToString(deskMaterial());
                string shippingSelected = shippingDays_Selected();
                string shippingTotal = Convert.ToString(shippingDays_SelectedIndexChanged());
                string deskTotal = Convert.ToString(totalMath());

                dq.currentDate = currentDateInfo;
                dq.customerInfo = customerInfo;
                dq.areaTotal = areaTotal;
                dq.drawerTotal = drawerTotal;
                dq.materialSelected = materialSelected;
                dq.materialTotal = materialTotal;
                dq.shippingSelected = shippingSelected;
                dq.shippingTotal = "$" + shippingTotal;
                dq.totalDesk = "$" + deskTotal;

                DeskQuote.dqList.Add(dq);




                File.WriteAllText("myobjects.json", JsonConvert.SerializeObject(DeskQuote.dqList));


                DisplayQuote viewDisplayQuote = new DisplayQuote(currentDateInfo, customerInfo, areaTotal, drawerTotal, materialSelected, materialTotal, shippingSelected, shippingTotal, deskTotal);
                viewDisplayQuote.Tag = this;
                viewDisplayQuote.Show(this);
                Hide();

            }

        }

        //Go back Botton 
        private void btnAddQuoteClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
