using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Echegaray
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            dataGridDisplay.DataSource = DeskQuote.dqList;

        }

        private void btnViewAllQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        // Diego's code 
        private void ViewAllQuotes_Load(object sender, EventArgs e)
       {
            // Loads the grid display containing the added quotes

        //    DeskQuote u = new DeskQuote();


        }
    }
}
