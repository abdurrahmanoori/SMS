using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class provinces : Migration
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

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provinces");

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
