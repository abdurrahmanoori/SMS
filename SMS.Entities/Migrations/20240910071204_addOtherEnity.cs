using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class addOtherEnity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyDescription",
                table: "Surveys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyDescription",
                table: "Surveys");
        }
    }
}
