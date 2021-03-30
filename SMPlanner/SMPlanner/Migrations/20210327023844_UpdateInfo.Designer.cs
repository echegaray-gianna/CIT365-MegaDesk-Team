﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMPlanner.Data;

namespace SMPlanner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20210327023844_UpdateInfo")]
    partial class UpdateInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMPlanner.Models.AssignmentTopic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AssignmentTopic");
                });

            modelBuilder.Entity("SMPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Benediction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingHymnPage")
                        .HasColumnType("int");

                    b.Property<string>("Conductor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpeningHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningHymnPage")
                        .HasColumnType("int");

                    b.Property<string>("SacramentHymn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentHymnPage")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("SMPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentTopicID")
                        .HasColumnType("int");

                    b.Property<int>("MeetingID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentTopicID");

                    b.HasIndex("MeetingID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("SMPlanner.Models.Speaker", b =>
                {
                    b.HasOne("SMPlanner.Models.AssignmentTopic", "AssignmentTopic")
                        .WithMany("Speakers")
                        .HasForeignKey("AssignmentTopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMPlanner.Models.Meeting", "Meeting")
                        .WithMany("Speakers")
                        .HasForeignKey("MeetingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignmentTopic");

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("SMPlanner.Models.AssignmentTopic", b =>
                {
                    b.Navigation("Speakers");
                });

            modelBuilder.Entity("SMPlanner.Models.Meeting", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}
