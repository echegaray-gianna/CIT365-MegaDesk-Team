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

        public int MeetingID { get; set; }

        public int AssignmentTopicID { get; set; }

        [Required(ErrorMessage = "Please enter the Speaker Name.")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please a assign a meeting to the speaker. If the meeting is not in the list, add it first from the meeting planner tab ")]
        public Meeting Meeting { get; set; }

        [Display(Name = "Assignment Topic"), Required(ErrorMessage = "Please a assign a topic to the speaker. If the topic is not in the list, add it first from the topic tab ")]
        public AssignmentTopic AssignmentTopic { get; set; }

       
    }
}
