using Entities.Data;
using RepositoryContracts;
using RepositoryContracts.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        //private readonly ISurveyRepository SurveyRepository;
        // private IPatientTypeRepository _patientTypeRepository;


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            SurveyRepository = new SurveyRepository(db);
            LanguageRepository = new LanguageRepository(db);
            SurveyTranslationRepository = new SurveyTranslationRepository(db);
            AnswerOptionRepository = new AnswerOptionRepository(db);
            AnswerOptionTranslationRepository = new AnswerOptionTranslationRepository(db);
            QuestionRepository = new QuestionRepository(db);
            QuestionTranslationRepository = new QuestionTranslationRepository(db);
            RespondentRepository = new RespondentRepository(db);
            SurveyInstanceRepository = new SurveyInstanceRepository(db);
            SurveyInstanceQuestionRepository = new SurveyInstanceQuestionRepository(db);
            SurveyResponseRepository = new SurveyResponseRepository(db);
            SurveyResponseDetailRepository = new SurveyResponseDetailRepository(db);
            EducationalDegreeRepository = new EducationalDegreeRepository(db);

            // ProvinceRepository = new ProvinceRepository(db);
        }

        public ISurveyRepository SurveyRepository {get; private set;}
        public ILanguageRepository LanguageRepository {get; private set;}
        public ISurveyTranslationRepository SurveyTranslationRepository { get; private set; }
        public IAnswerOptionRepository AnswerOptionRepository {get; private set;}
        public ISurveyInstanceQuestionRepository SurveyInstanceQuestionRepository { get; private set; }
        public IAnswerOptionTranslationRepository AnswerOptionTranslationRepository { get; private set; }
        public IQuestionRepository QuestionRepository { get; private set; }
        public IQuestionTranslationRepository QuestionTranslationRepository { get; private set; }
        public IRespondentRepository RespondentRepository { get; private set; }
        public ISurveyInstanceRepository SurveyInstanceRepository { get; private set; }
        public ISurveyResponseRepository SurveyResponseRepository { get; private set; }
        public ISurveyResponseDetailRepository SurveyResponseDetailRepository { get; private set; }
        public IEducationalDegreeRepository EducationalDegreeRepository { get; private set; }
       
        public async Task SaveChanges(CancellationToken cancellationToken)
        {
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
