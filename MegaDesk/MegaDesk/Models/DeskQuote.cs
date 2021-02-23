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


    }

}
