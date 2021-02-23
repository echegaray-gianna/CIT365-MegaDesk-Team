using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;

namespace MegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public IndexModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }



        //Search By Customer Name
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchSelection { get; set; }


        //sort By Customer Name or Date

        public string CustomerNameSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            var quote = from m in _context.DeskQuote
                        select m;

            // search by C. Name
            if (!string.IsNullOrEmpty(SearchString))
            {
                quote = quote.Where(s => s.CustomerName.Contains(SearchString));
            }


            //Sort
            CustomerNameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {
                case "name_desc":
                    quote = quote.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    quote = quote.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    quote = quote.OrderByDescending(s => s.Date);
                    break;
                default:
                    quote = quote.OrderBy(s => s.CustomerName);
                    break;
            }

            DeskQuote = await quote.ToListAsync();
        }
    }
}
