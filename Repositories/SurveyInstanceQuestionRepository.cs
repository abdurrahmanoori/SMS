using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyInstanceQuestionRepository : GenericRepository<SurveyInstanceQuestion>, ISurveyInstanceQuestionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyInstanceQuestionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
