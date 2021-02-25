using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDesk.Models
{
    public class DeskQuote
    {
        //Quote ID
        public int ID { get; set; }

        //Quote Date
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //CustomerName
        [Display(Name = "Customer Name"), RegularExpression(@"^[a-zA-Z\s]+$"), StringLength(int.MaxValue, MinimumLength = 3), Required]
        public string CustomerName { get; set; }

        // Desk Width

        [Range(24, 96)]
        [Column(TypeName = "decimal(4, 2)"), Required]
        public decimal Width { get; set; }

        // Desk Deep
        [Range(12, 46)]
        [Column(TypeName = "decimal(4, 2)"), Required]
        public decimal Deep { get; set; }

        //Number of Drawers
        [Range(0, 7), Required]
        public int Drawers { get; set; }

        //Material
        [Required]
        public string Material { get; set; }

        //Shipping 
        [Required]
        public int Shipping { get; set; }

        //calculated area
        public decimal Area { get; set; }

        //desk cost
        public decimal Cost { get; set; }
        
        // Area Calculation 
        public decimal areaCalc() {
            Area = Width * Deep;
            if (Area > 1000) {
                decimal areaCost = 200 + (Area - 1000);
                return areaCost;
            }
            else {
                return 200;
            }
        }

        //Drawer Calculation
        public int drawersCalc() {
            int totalDrawers = Drawers * 50;
            return totalDrawers;
        }

        public int deskMaterialCalc() {
            switch (Material) {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    return 0;
            }
        }

        public decimal shippingCostCalc() {
            decimal areaDesk = (Area - 200) + 1000;
            int[] rushPrices = {60,70,80, 40,50,60, 30,35,40};
            switch (Shipping)
            {
                case 3:
                    if (areaDesk < 1000) { return rushPrices[0]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[1]; }
                    else if (areaDesk > 2000) { return rushPrices[2]; }
                    else { return 0; }

                case 5:
                    if (areaDesk < 1000) { return rushPrices[3]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[4]; }
                    else if (areaDesk > 2000) { return rushPrices[5]; }
                    else { return 0; }

                case 7:
                    if (areaDesk < 1000) { return rushPrices[6]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[7]; }
                    else if (areaDesk > 2000) { return rushPrices[8]; }
                    else { return 0; }

                case 14:
                    return 0;

                default:
                    return 0;
            }
        }
        //Total Cost Calculation
        public void totalCalc() {

            Cost = areaCalc() + drawersCalc() + deskMaterialCalc() + shippingCostCalc();

        }
    }
}
