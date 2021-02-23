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

        public int ID { get; set; }


        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string CustomerName { get; set; }



    }
}
