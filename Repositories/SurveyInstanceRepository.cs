using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyInstanceRepository : GenericRepository<SurveyInstance>, ISurveyInstanceRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyInstanceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
