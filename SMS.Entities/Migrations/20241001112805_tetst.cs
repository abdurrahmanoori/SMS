using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class tetst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 2, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 4, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 5, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 6, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 6);
        }
    }
}
