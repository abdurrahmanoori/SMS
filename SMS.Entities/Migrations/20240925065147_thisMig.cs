using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class thisMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Responsdent",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "OptionText",
                table: "AnswersOptionsTranslation",
                newName: "AnswerOptionText");

            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth",
                table: "Responsdent",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EducationLevel",
                table: "Responsdent",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Responsdent",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Responsdent",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Responsdent",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Responsdent");

            migrationBuilder.DropColumn(
                name: "EducationLevel",
                table: "Responsdent");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Responsdent");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Responsdent");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Responsdent");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Responsdent",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AnswerOptionText",
                table: "AnswersOptionsTranslation",
                newName: "OptionText");
        }
    }
}
