

using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
