using MegaDesk.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskContext>>()))
            {
                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        CustomerName = "Nick Newman",
                        Date = DateTime.Parse("1998-2-18"),
                        Width = 35.23M,
                        Deep = 44.20M,
                        Drawers = 3,
                        Material = "Oak",
                        Shipping = 7,
                        Cost = 380.00M,
                        Area = 757.17M
                    },

                    new DeskQuote
                    {
                        CustomerName = "Carson Clay",
                        Date = DateTime.Parse("2005-6-30"),
                        Width = 45.30M,
                        Deep = 25.60M,
                        Drawers = 4,
                        Material = "Pine",
                        Shipping = 5,
                        Cost = 290.00M,
                        Area = 359.68M
                    },

                    new DeskQuote
                    {
                        CustomerName = "Mario Garcia",
                        Date = DateTime.Parse("2020-8-10"),
                        Width = 25.87M,
                        Deep = 15.37M,
                        Drawers = 6,
                        Material = "Rosewood",
                        Shipping = 3,
                        Cost = 660.00M,
                        Area = 200.00M
                    },

                    new DeskQuote
                    {
                        CustomerName = "Juan Rivera",
                        Date = DateTime.Parse("2015-2-22"),
                        Width = 28.550M,
                        Deep = 40.11M,
                        Drawers = 7,
                        Material = "Veneer",
                        Shipping = 14,
                        Cost = 475.00M,
                        Area = 345.14M
                    },

                    new DeskQuote
                    {
                        CustomerName = "George Anderson",
                        Date = DateTime.Parse("2018-12-31"),
                        Width = 90.210M,
                        Deep = 33.87M,
                        Drawers = 2,
                        Material = "Oak",
                        Shipping = 5,
                        Cost = 340.00M,
                        Area = 2255.41M
                    }



                );
                context.SaveChanges();


            }
        }


    }
}
