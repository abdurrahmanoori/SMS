using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class SurveyResponseDetailRepository : GenericRepository<SurveyResponseDetail>, ISurveyResponseDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SurveyResponseDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }
    }
}
