using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Entities.Migrations
{
    public partial class RestOfTheTAbleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyID = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionType = table.Column<string>(type: "TEXT", nullable: false),
                    IsRequired = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Surveys",
                        principalColumn: "SurveyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsdent",
                columns: table => new
                {
                    RespondentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsdent", x => x.RespondentID);
                });

            migrationBuilder.CreateTable(
                name: "SurveyInstances",
                columns: table => new
                {
                    SurveyInstanceID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyID = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeactivationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyInstances", x => x.SurveyInstanceID);
                    table.ForeignKey(
                        name: "FK_SurveyInstances_Surveys_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Surveys",
                        principalColumn: "SurveyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyTranslations",
                columns: table => new
                {
                    SurveyTranslationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyID = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyTranslations", x => x.SurveyTranslationID);
                    table.ForeignKey(
                        name: "FK_SurveyTranslations_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyTranslations_Surveys_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Surveys",
                        principalColumn: "SurveyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswersOptions",
                columns: table => new
                {
                    AnswerOptionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersOptions", x => x.AnswerOptionID);
                    table.ForeignKey(
                        name: "FK_AnswersOptions_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTranslations",
                columns: table => new
                {
                    QuestionTranslationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionText = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTranslations", x => x.QuestionTranslationID);
                    table.ForeignKey(
                        name: "FK_QuestionTranslations_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTranslations_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyInstanceQuestion",
                columns: table => new
                {
                    SurveyInstanceQuestionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyInstanceID = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyInstanceQuestion", x => x.SurveyInstanceQuestionID);
                    table.ForeignKey(
                        name: "FK_SurveyInstanceQuestion_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyInstanceQuestion_SurveyInstances_SurveyInstanceID",
                        column: x => x.SurveyInstanceID,
                        principalTable: "SurveyInstances",
                        principalColumn: "SurveyInstanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyResponse",
                columns: table => new
                {
                    SurveyResponseID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyInstanceID = table.Column<int>(type: "INTEGER", nullable: false),
                    RespondentID = table.Column<int>(type: "INTEGER", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponse", x => x.SurveyResponseID);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Responsdent_RespondentID",
                        column: x => x.RespondentID,
                        principalTable: "Responsdent",
                        principalColumn: "RespondentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_SurveyInstances_SurveyInstanceID",
                        column: x => x.SurveyInstanceID,
                        principalTable: "SurveyInstances",
                        principalColumn: "SurveyInstanceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswersOptionsTranslation",
                columns: table => new
                {
                    AnswerOptionTranslationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnswerOptionID = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false),
                    OptionText = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersOptionsTranslation", x => x.AnswerOptionTranslationID);
                    table.ForeignKey(
                        name: "FK_AnswersOptionsTranslation_AnswersOptions_AnswerOptionID",
                        column: x => x.AnswerOptionID,
                        principalTable: "AnswersOptions",
                        principalColumn: "AnswerOptionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswersOptionsTranslation_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyResponseDetails",
                columns: table => new
                {
                    SurveyResponseDetailID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurveyResponseID = table.Column<int>(type: "INTEGER", nullable: false),
                    SurveyInstanceQuestionID = table.Column<int>(type: "INTEGER", nullable: false),
                    AnswerOptionID = table.Column<int>(type: "INTEGER", nullable: true),
                    FreeTextAnswer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponseDetails", x => x.SurveyResponseDetailID);
                    table.ForeignKey(
                        name: "FK_SurveyResponseDetails_AnswersOptions_AnswerOptionID",
                        column: x => x.AnswerOptionID,
                        principalTable: "AnswersOptions",
                        principalColumn: "AnswerOptionID");
                    table.ForeignKey(
                        name: "FK_SurveyResponseDetails_SurveyInstanceQuestion_SurveyInstanceQuestionID",
                        column: x => x.SurveyInstanceQuestionID,
                        principalTable: "SurveyInstanceQuestion",
                        principalColumn: "SurveyInstanceQuestionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyResponseDetails_SurveyResponse_SurveyResponseID",
                        column: x => x.SurveyResponseID,
                        principalTable: "SurveyResponse",
                        principalColumn: "SurveyResponseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswersOptions_QuestionID",
                table: "AnswersOptions",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_AnswersOptionsTranslation_AnswerOptionID",
                table: "AnswersOptionsTranslation",
                column: "AnswerOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_AnswersOptionsTranslation_LanguageID",
                table: "AnswersOptionsTranslation",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTranslations_LanguageID",
                table: "QuestionTranslations",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTranslations_QuestionID",
                table: "QuestionTranslations",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyInstanceQuestion_QuestionID",
                table: "SurveyInstanceQuestion",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyInstanceQuestion_SurveyInstanceID",
                table: "SurveyInstanceQuestion",
                column: "SurveyInstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyInstances_SurveyID",
                table: "SurveyInstances",
                column: "SurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_RespondentID",
                table: "SurveyResponse",
                column: "RespondentID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_SurveyInstanceID",
                table: "SurveyResponse",
                column: "SurveyInstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponseDetails_AnswerOptionID",
                table: "SurveyResponseDetails",
                column: "AnswerOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponseDetails_SurveyInstanceQuestionID",
                table: "SurveyResponseDetails",
                column: "SurveyInstanceQuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponseDetails_SurveyResponseID",
                table: "SurveyResponseDetails",
                column: "SurveyResponseID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyTranslations_LanguageID",
                table: "SurveyTranslations",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyTranslations_SurveyID",
                table: "SurveyTranslations",
                column: "SurveyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswersOptionsTranslation");

            migrationBuilder.DropTable(
                name: "QuestionTranslations");

            migrationBuilder.DropTable(
                name: "SurveyResponseDetails");

            migrationBuilder.DropTable(
                name: "SurveyTranslations");

            migrationBuilder.DropTable(
                name: "AnswersOptions");

            migrationBuilder.DropTable(
                name: "SurveyInstanceQuestion");

            migrationBuilder.DropTable(
                name: "SurveyResponse");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Responsdent");

            migrationBuilder.DropTable(
                name: "SurveyInstances");
        }
    }
}
