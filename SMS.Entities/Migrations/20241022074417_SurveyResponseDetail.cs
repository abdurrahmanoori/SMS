using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class SurveyResponseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 1,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 22, 7, 44, 17, 344, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 2,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 21, 7, 44, 17, 344, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 3,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 20, 7, 44, 17, 344, DateTimeKind.Utc).AddTicks(4978));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 1,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 22, 7, 43, 8, 356, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 2,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 21, 7, 43, 8, 356, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 3,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 20, 7, 43, 8, 356, DateTimeKind.Utc).AddTicks(5761));
        }
    }
}
