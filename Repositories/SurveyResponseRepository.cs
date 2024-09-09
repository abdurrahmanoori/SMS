using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyResponseRepository : GenericRepository<SurveyResponse>, ISurveyResponseRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyResponseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
