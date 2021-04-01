using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the Meeting Date.")]
        public int MeetingID { get; set; }

        [Required(ErrorMessage = "Please enter a Topic.")]
        public int AssignmentTopicID { get; set; }


        [Required(ErrorMessage = "Please enter the Speaker Name.")]
        public string Name { get; set; }


        public Meeting Meeting { get; set; }

        [Display(Name = "Assignment Topic")]
        public AssignmentTopic AssignmentTopic { get; set; }

       
    }
}
