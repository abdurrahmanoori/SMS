using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class Question : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Responsdent",
                keyColumn: "RespondentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 1,
                column: "SurveyID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 2,
                column: "SurveyID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 3,
                column: "SurveyID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 1,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 22, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 2,
                columns: new[] { "ResponseDate", "SurveyInstanceID" },
                values: new object[] { new DateTime(2024, 10, 21, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1573), 2 });

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 3,
                columns: new[] { "ResponseDate", "SurveyInstanceID" },
                values: new object[] { new DateTime(2024, 10, 20, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1580), 3 });

            migrationBuilder.UpdateData(
                table: "SurveyResponseDetails",
                keyColumn: "SurveyResponseDetailID",
                keyValue: 2,
                columns: new[] { "AnswerOptionID", "SurveyResponseID" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "SurveyResponseDetails",
                keyColumn: "SurveyResponseDetailID",
                keyValue: 3,
                columns: new[] { "AnswerOptionID", "SurveyInstanceQuestionID", "SurveyResponseID" },
                values: new object[] { 3, 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 1,
                column: "SurveyID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 2,
                column: "SurveyID",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 3,
                column: "SurveyID",
                value: 102);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "IsRequired", "QuestionType", "SurveyID" },
                values: new object[] { 4, true, "Text", 103 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "IsRequired", "QuestionType", "SurveyID" },
                values: new object[] { 5, false, "Text", 103 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "IsRequired", "QuestionType", "SurveyID" },
                values: new object[] { 6, true, "YesNo", 104 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "IsRequired", "QuestionType", "SurveyID" },
                values: new object[] { 7, true, "MultipleChoice", 105 });

            migrationBuilder.InsertData(
                table: "Responsdent",
                columns: new[] { "RespondentID", "DateOfBirth", "EducationLevel", "Email", "FirstName", "Gender", "LastName", "Name", "PhoneNumber", "Province" },
                values: new object[] { 4, 1988, "Diploma", "bob.brown@example.com", "Bob", "Male", "Brown", "Bob Brown", "555-765-4321", "Alberta" });

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 1,
                column: "ResponseDate",
                value: new DateTime(2024, 10, 22, 5, 27, 17, 713, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 2,
                columns: new[] { "ResponseDate", "SurveyInstanceID" },
                values: new object[] { new DateTime(2024, 10, 21, 5, 27, 17, 713, DateTimeKind.Utc).AddTicks(2816), 1 });

            migrationBuilder.UpdateData(
                table: "SurveyResponse",
                keyColumn: "SurveyResponseID",
                keyValue: 3,
                columns: new[] { "ResponseDate", "SurveyInstanceID" },
                values: new object[] { new DateTime(2024, 10, 20, 5, 27, 17, 713, DateTimeKind.Utc).AddTicks(2820), 2 });

            migrationBuilder.UpdateData(
                table: "SurveyResponseDetails",
                keyColumn: "SurveyResponseDetailID",
                keyValue: 2,
                columns: new[] { "AnswerOptionID", "SurveyResponseID" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "SurveyResponseDetails",
                keyColumn: "SurveyResponseDetailID",
                keyValue: 3,
                columns: new[] { "AnswerOptionID", "SurveyInstanceQuestionID", "SurveyResponseID" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 4, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "CreatedDate", "IsActive", "SurveyDescription" },
                values: new object[] { 5, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Customer Satisfaction Survey" });
        }
    }
}
