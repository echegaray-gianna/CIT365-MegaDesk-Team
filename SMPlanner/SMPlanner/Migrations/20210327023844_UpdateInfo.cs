using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMPlanner.Migrations
{
    public partial class UpdateInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignmentTopic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTopic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conductor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymnPage = table.Column<int>(type: "int", nullable: false),
                    Invocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentHymnPage = table.Column<int>(type: "int", nullable: false),
                    IntermediateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingHymnPage = table.Column<int>(type: "int", nullable: false),
                    Benediction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingID = table.Column<int>(type: "int", nullable: false),
                    AssignmentTopicID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speaker_AssignmentTopic_AssignmentTopicID",
                        column: x => x.AssignmentTopicID,
                        principalTable: "AssignmentTopic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_AssignmentTopicID",
                table: "Speaker",
                column: "AssignmentTopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingID",
                table: "Speaker",
                column: "MeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "AssignmentTopic");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
