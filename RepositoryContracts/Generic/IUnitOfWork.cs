using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.Generic
{
    public interface IUnitOfWork
    {
        //IProvinceRepository ProvinceRepository { get; }
        ISurveyRepository SurveyRepository { get; }
        ILanguageRepository LanguageRepository { get;}
        ISurveyTranslationRepository SurveyTranslationRepository { get; }
        IAnswerOptionRepository AnswerOptionRepository { get; }
        IAnswerOptionTranslationRepository AnswerOptionTranslationRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IQuestionTranslationRepository QuestionTranslationRepository { get; }
        IRespondentRepository RespondentRepository { get; }
        ISurveyInstanceRepository SurveyInstanceRepository { get; }
        ISurveyInstanceQuestionRepository SurveyInstanceQuestionRepository { get; }
        ISurveyResponseRepository SurveyResponseRepository { get; }
        ISurveyResponseDetailRepository SurveyResponseDetailRepository { get; }
        IEducationalDegreeRepository EducationalDegreeRepository { get; }
        IProvinceRepository provincesRepository { get; }
        Task SaveChanges(CancellationToken cancellationToken);

    }
}
