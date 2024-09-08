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
        
        Task SaveChanges(CancellationToken cancellationToken);

    }
}
