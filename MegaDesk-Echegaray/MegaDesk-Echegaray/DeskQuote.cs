using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Echegaray
{
    class DeskQuote
    {
        //this is used to create the JSON FILE 
        public string currentDate { get; set; }
        public string customerInfo { get; set; }
        public string areaTotal { get; set; }
        public string drawerTotal { get; set; }
        public string materialSelected { get; set; }
        public string materialTotal { get; set; }
        public string shippingSelected { get; set; }
        public string shippingTotal { get; set; }
        public string totalDesk { get; set; }


        Desk Desk = new Desk();

        //constructor 
        public DeskQuote()
        {

        }
        public DeskQuote(string currentDate, string customerInfo, string areaTotal, string drawerTotal, string materialSelected, string materialTotal, 
            string shippingSelected, string shippingTotal, string totalDesk)
        {
            this.currentDate = currentDate;
            this.customerInfo = customerInfo;
            this.areaTotal = areaTotal;
            this.drawerTotal = drawerTotal;
            this.materialSelected = materialSelected;
            this.materialTotal = materialTotal;
            this.shippingSelected = shippingSelected;
            this.shippingTotal = shippingTotal;
            this.totalDesk = totalDesk;
        }

        // Area Calculation 
        public int areaCalc(int width, int depth)
        {

            int area = width * depth;
            
            if (area > 1000)
            {
                int areaCost = 200 + (area - 1000);
                return areaCost;
            }
            else
            {
                return 200;
            }

        }

        // Drawers Calculation
        public int drawersCalc(int drawers)
        {
            int totalDrawers = drawers * 50;
            return totalDrawers;
        }

        //Desk Material Calculation
        public int deskMaterialCalc(string material)
        {
            switch (Enum.Parse(typeof(DesktopMaterialList), material))
            {
                case DesktopMaterialList.Oak:
                    return (int)DesktopMaterialList.Oak;
                case DesktopMaterialList.Laminate:
                    return (int)DesktopMaterialList.Laminate;
                case DesktopMaterialList.Pine:
                    return (int)DesktopMaterialList.Pine;
                case DesktopMaterialList.Rosewood:
                    return (int)DesktopMaterialList.Rosewood;
                case DesktopMaterialList.Veneer:
                    return (int)DesktopMaterialList.Veneer;
                default:
                    return 0;
            }
        }

        //Shipping Cost Calculation
        public int shippingCost(string shippingDays, int area)
        {
            int areaDesk = (area - 200) + 1000;

            //open file
            List<int> rushPrices = new List<int>();
            String line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"rushOrderPrices.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                rushPrices.Add(Convert.ToInt32(line));
            }
            Console.WriteLine(rushPrices);
            file.Close();


            switch (shippingDays)
            {
                case "3":
                    if (areaDesk < 1000) return 60;
                    if (areaDesk >= 1000 && areaDesk <= 2000) return 70;
                    if (areaDesk > 2000) return 80;
                    return 0;

                case "5":
                    if (areaDesk < 1000) return 40;
                    if (areaDesk >= 1000 && areaDesk <= 2000) return 50;
                    if (areaDesk > 2000) return 60;
                    return 0;

                case "7":
                    if (areaDesk < 1000) return 30;
                    if (areaDesk >= 1000 && areaDesk <= 2000) return 35;
                    if (areaDesk > 2000) return 40;
                    return 0;

                case "14":
                    return 0;

                default:
                    return 0;
            }
        }

        //Total Cost Calculation

        public int totalCalc(int areaCost, int drawerCost, int materialPrice, int shippingCost)
        {

            int totalDesk = areaCost + drawerCost + materialPrice + shippingCost;


            return totalDesk;

        }

    }



}
