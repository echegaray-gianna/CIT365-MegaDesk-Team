using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMPlanner.Models
{
    public class AssignmentTopic
    {
        public int ID { get; set; }

        public string Topic { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
