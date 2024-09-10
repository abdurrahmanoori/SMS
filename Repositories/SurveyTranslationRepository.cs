using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyTranslationRepository : GenericRepository<SurveyTranslation>, ISurveyTranslationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyTranslationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
