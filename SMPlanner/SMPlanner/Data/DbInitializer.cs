using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMPlanner.Models;

namespace SMPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any speaker.
            if (context.Speakers.Any())
            {
                return;   // DB has been seeded
            }


            var assignmenttopics = new AssignmentTopic[]
{
            new AssignmentTopic{Topic="Obedience"},
            new AssignmentTopic{Topic="Service"},
            new AssignmentTopic{Topic="Charity"},
};
            foreach (AssignmentTopic e in assignmenttopics)
            {
                context.AssignmentTopics.Add(e);
            }
            context.SaveChanges();



            var meetings = new Meeting[]
{
            new Meeting{MeetingDate=DateTime.Parse("2021-02-07"),Conductor="Jacob Taylor",OpeningHymn="The Voice of God Again Is Heard",OpeningHymnPage=18,Invocation="Susan Bre",SacramentHymn="To Think about Jesus",SacramentHymnPage=71,IntermediateNumber="Go the Second Mile. By Brother Walk",ClosingHymn="Beauty Everywhere",ClosingHymnPage=232,Benediction="Robert Harris"},
            new Meeting{MeetingDate=DateTime.Parse("2020-02-14"),Conductor="Will Brown",OpeningHymn="They, the Builders of the Nation",OpeningHymnPage=36,Invocation="Thomas Cummin",SacramentHymn="The Sacrament",SacramentHymnPage=72,IntermediateNumber="",ClosingHymn="When I Go to Church",ClosingHymnPage=157, Benediction="Marissa Rice"},
};
            foreach (Meeting c in meetings)
            {
                context.Meetings.Add(c);
            }
            context.SaveChanges();




            var speakers = new Speaker[]
            {
            new Speaker{MeetingID=1, AssignmentTopicID=1, Name="David Morris"},
            new Speaker{MeetingID=1, AssignmentTopicID=2, Name="Jason Smith"},
            new Speaker{MeetingID=4, AssignmentTopicID=3, Name="Oliver Rea"},
            };
            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

        }
    }
}
