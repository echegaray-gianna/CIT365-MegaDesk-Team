using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMPlanner.Models;
using Microsoft.EntityFrameworkCore;
using SMPlanner.Data;


namespace SMPlanner.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<AssignmentTopic> AssignmentTopics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<AssignmentTopic>().ToTable("AssignmentTopic");
        }

    }
}
