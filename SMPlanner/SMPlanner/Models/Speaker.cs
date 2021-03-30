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

        public string Name { get; set; }

        

        public Meeting Meeting { get; set; }

        [Display(Name = "Assignment Topic")]
        public AssignmentTopic AssignmentTopic { get; set; }

       
    }
}
