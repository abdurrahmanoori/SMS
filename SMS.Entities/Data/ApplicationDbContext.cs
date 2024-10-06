
using Microsoft.EntityFrameworkCore;
using SMS.Entities;

namespace Entities.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyInstance> SurveyInstances { get; set; }
        public DbSet<SurveyInstanceQuestion> SurveyInstanceQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<AnswerOption> AnswersOptions { get; set; }
        public DbSet<AnswerOptionTranslation> AnswersOptionsTranslation { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<QuestionTranslation> QuestionTranslations { get; set; }
        public DbSet<Respondent> Responsdent { get; set; }

        public DbSet<SurveyInstanceQuestion> SurveyInstancesQuestion { get; set; }
        public DbSet<SurveyResponse> SurveyResponse { get; set; }

        public DbSet<SurveyResponseDetail> SurveyResponseDetails { get; set; }
        public DbSet<SurveyTranslation> SurveyTranslations { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }

    }
}
