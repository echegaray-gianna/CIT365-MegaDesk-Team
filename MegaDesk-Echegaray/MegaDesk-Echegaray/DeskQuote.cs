﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Echegaray
{
    class DeskQuote
    {
        Desk Desk = new Desk();
       

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

            //Open file and read rush prices to list
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

            //Determine rush price
            switch (shippingDays)
            {
                case "3":
                    if (areaDesk < 1000) { return rushPrices[0]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[1]; }
                    else if (areaDesk > 2000) { return rushPrices[2]; }
                    else { return 0; }
                case "5":
                    if (areaDesk < 1000) { return rushPrices[3]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[4]; }
                    else if (areaDesk > 2000) { return rushPrices[5]; }
                    else { return 0; }
                case "7":
                    if (areaDesk < 1000) { return rushPrices[6]; }
                    else if (areaDesk >= 1000 && areaDesk <= 2000) { return rushPrices[7]; }
                    else if (areaDesk > 2000) { return rushPrices[8]; }
                    else { return 0; }
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