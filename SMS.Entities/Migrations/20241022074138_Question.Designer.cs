﻿// <auto-generated />
using System;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SMS.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241022074138_Question")]
    partial class Question
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.Property<int>("AnswerOptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerOptionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("AnswersOptions");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOptionTranslation", b =>
                {
                    b.Property<int>("AnswerOptionTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnswerOptionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnswerOptionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerOptionTranslationID");

                    b.HasIndex("AnswerOptionID");

                    b.HasIndex("LanguageID");

                    b.ToTable("AnswersOptionsTranslation");
                });

            modelBuilder.Entity("SMS.Entities.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionID");

                    b.HasIndex("SurveyID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            IsRequired = true,
                            QuestionType = "MultipleChoice",
                            SurveyID = 1
                        },
                        new
                        {
                            QuestionID = 2,
                            IsRequired = false,
                            QuestionType = "MultipleChoice",
                            SurveyID = 2
                        },
                        new
                        {
                            QuestionID = 3,
                            IsRequired = true,
                            QuestionType = "Rating",
                            SurveyID = 3
                        });
                });

            modelBuilder.Entity("SMS.Entities.QuestionTranslation", b =>
                {
                    b.Property<int>("QuestionTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionTranslationID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuestionTranslations");
                });

            modelBuilder.Entity("SMS.Entities.Respondent", b =>
                {
                    b.Property<int>("RespondentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DateOfBirth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EducationLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RespondentID");

                    b.ToTable("Responsdent");

                    b.HasData(
                        new
                        {
                            RespondentID = 1,
                            DateOfBirth = 1990,
                            EducationLevel = "Bachelor's",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            LastName = "Doe",
                            Name = "John Doe",
                            PhoneNumber = "123-456-7890",
                            Province = "Ontario"
                        },
                        new
                        {
                            RespondentID = 2,
                            DateOfBirth = 1985,
                            EducationLevel = "Master's",
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            Gender = "Female",
                            LastName = "Smith",
                            Name = "Jane Smith",
                            PhoneNumber = "098-765-4321",
                            Province = "Quebec"
                        },
                        new
                        {
                            RespondentID = 3,
                            DateOfBirth = 1992,
                            EducationLevel = "PhD",
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            Gender = "Female",
                            LastName = "Johnson",
                            Name = "Alice Johnson",
                            PhoneNumber = "555-123-4567",
                            Province = "British Columbia"
                        });
                });

            modelBuilder.Entity("SMS.Entities.Survey", b =>
                {
                    b.Property<int>("SurveyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SurveyDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyID");

                    b.ToTable("Surveys");

                    b.HasData(
                        new
                        {
                            SurveyID = 1,
                            CreatedDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            SurveyDescription = "Customer Satisfaction Survey"
                        },
                        new
                        {
                            SurveyID = 2,
                            CreatedDate = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            SurveyDescription = "Customer Satisfaction Survey"
                        },
                        new
                        {
                            SurveyID = 3,
                            CreatedDate = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            SurveyDescription = "Customer Satisfaction Survey"
                        });
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.Property<int>("SurveyInstanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ActivationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeactivationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyInstanceID");

                    b.HasIndex("SurveyID");

                    b.ToTable("SurveyInstances");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstanceQuestion", b =>
                {
                    b.Property<int>("SurveyInstanceQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyInstanceID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyInstanceQuestionID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("SurveyInstanceID");

                    b.ToTable("SurveyInstanceQuestion");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.Property<int>("SurveyResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RespondentID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ResponseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyInstanceID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyResponseID");

                    b.HasIndex("RespondentID");

                    b.HasIndex("SurveyInstanceID");

                    b.ToTable("SurveyResponse");

                    b.HasData(
                        new
                        {
                            SurveyResponseID = 1,
                            RespondentID = 1,
                            ResponseDate = new DateTime(2024, 10, 22, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1563),
                            SurveyInstanceID = 1
                        },
                        new
                        {
                            SurveyResponseID = 2,
                            RespondentID = 2,
                            ResponseDate = new DateTime(2024, 10, 21, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1573),
                            SurveyInstanceID = 2
                        },
                        new
                        {
                            SurveyResponseID = 3,
                            RespondentID = 3,
                            ResponseDate = new DateTime(2024, 10, 20, 7, 41, 37, 391, DateTimeKind.Utc).AddTicks(1580),
                            SurveyInstanceID = 3
                        });
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponseDetail", b =>
                {
                    b.Property<int>("SurveyResponseDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AnswerOptionID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FreeTextAnswer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyInstanceQuestionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyResponseID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyResponseDetailID");

                    b.HasIndex("AnswerOptionID");

                    b.HasIndex("SurveyInstanceQuestionID");

                    b.HasIndex("SurveyResponseID");

                    b.ToTable("SurveyResponseDetails");

                    b.HasData(
                        new
                        {
                            SurveyResponseDetailID = 1,
                            AnswerOptionID = 1,
                            FreeTextAnswer = "I believe online learning offers flexibility and accessibility, but it can lack the personal interaction and engagement found in traditional classrooms.",
                            SurveyInstanceQuestionID = 1,
                            SurveyResponseID = 1
                        },
                        new
                        {
                            SurveyResponseDetailID = 2,
                            AnswerOptionID = 2,
                            FreeTextAnswer = "I am passionate about sustainable practices and believe this company aligns with my values and career goals.",
                            SurveyInstanceQuestionID = 2,
                            SurveyResponseID = 2
                        },
                        new
                        {
                            SurveyResponseDetailID = 3,
                            AnswerOptionID = 3,
                            FreeTextAnswer = "Traveling abroad taught me about different cultures and perspectives, which greatly expanded my worldview.",
                            SurveyInstanceQuestionID = 3,
                            SurveyResponseID = 3
                        });
                });

            modelBuilder.Entity("SMS.Entities.SurveyTranslation", b =>
                {
                    b.Property<int>("SurveyTranslationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyTranslationID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("SurveyID");

                    b.ToTable("SurveyTranslations");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOptionTranslation", b =>
                {
                    b.HasOne("SMS.Entities.AnswerOption", "AnswerOption")
                        .WithMany("Translations")
                        .HasForeignKey("AnswerOptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerOption");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.QuestionTranslation", b =>
                {
                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("Translations")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstanceQuestion", b =>
                {
                    b.HasOne("SMS.Entities.Question", "Question")
                        .WithMany("SurveyInstanceQuestions")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyInstance", "SurveyInstance")
                        .WithMany("SurveyInstanceQuestions")
                        .HasForeignKey("SurveyInstanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("SurveyInstance");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.HasOne("SMS.Entities.Respondent", "Respondent")
                        .WithMany()
                        .HasForeignKey("RespondentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyInstance", "SurveyInstance")
                        .WithMany("SurveyResponses")
                        .HasForeignKey("SurveyInstanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Respondent");

                    b.Navigation("SurveyInstance");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponseDetail", b =>
                {
                    b.HasOne("SMS.Entities.AnswerOption", "AnswerOption")
                        .WithMany()
                        .HasForeignKey("AnswerOptionID");

                    b.HasOne("SMS.Entities.SurveyInstanceQuestion", "SurveyInstanceQuestion")
                        .WithMany()
                        .HasForeignKey("SurveyInstanceQuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.SurveyResponse", "SurveyResponse")
                        .WithMany("SurveyResponseDetails")
                        .HasForeignKey("SurveyResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerOption");

                    b.Navigation("SurveyInstanceQuestion");

                    b.Navigation("SurveyResponse");
                });

            modelBuilder.Entity("SMS.Entities.SurveyTranslation", b =>
                {
                    b.HasOne("SMS.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Entities.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SMS.Entities.AnswerOption", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("SMS.Entities.Question", b =>
                {
                    b.Navigation("AnswerOptions");

                    b.Navigation("SurveyInstanceQuestions");

                    b.Navigation("Translations");
                });

            modelBuilder.Entity("SMS.Entities.SurveyInstance", b =>
                {
                    b.Navigation("SurveyInstanceQuestions");

                    b.Navigation("SurveyResponses");
                });

            modelBuilder.Entity("SMS.Entities.SurveyResponse", b =>
                {
                    b.Navigation("SurveyResponseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
