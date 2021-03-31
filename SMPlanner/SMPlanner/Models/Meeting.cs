using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }


        // Meeting Date
        [Display(Name = "Meeting Date")]
        [Required(ErrorMessage = "Please Enter a Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }


        //Conductor Leader
        [Required(ErrorMessage = "Please enter the First and Last name of the Leader Conductor.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and Last name must be capilatized.")]
        public string Conductor { get; set; }


        //Opening Hymn
        [Display(Name = "Opening Hymn"), Required(ErrorMessage = "Please enter the Opening Hymn Name.")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Hymn Page")]
        [Range(1, 341, ErrorMessage = "The Opening Hymn Page, must be between 1-341.")]
        public int OpeningHymnPage { get; set; }


        //Invocation
        [Required(ErrorMessage = "Please enter the First and Last name of the person.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and Last name must be capilatized.")]
        public string Invocation { get; set; }


        //Sacrament Hymn
        [Display(Name = "Sacrament Hymn"), Required(ErrorMessage = "Please enter the Sacrament Hymn Name.")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Hymn Page")]
        [Range(1, 341, ErrorMessage = "The Sacrament Hymn Page must be between 1- 341.")]
        public int SacramentHymnPage { get; set; }


        //Intermediate number or musical number
        [Display(Name = "Musical Number")]
        public string IntermediateNumber { get; set; }


        //Closing Hymn
        [Display(Name = "Closing Hymn"), Required(ErrorMessage = "Please enter the Closing Hymn Name.")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Hymn Page")]
        [Range(1, 341, ErrorMessage = "The Sacrament Hymn page must be between 1-341.")]
        public int ClosingHymnPage { get; set; }


        //Benediction
        [Required(ErrorMessage = "Please enter the First and Last name of the person.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and Last name must be capilatized.")]
        public string Benediction { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

 
    }
}
