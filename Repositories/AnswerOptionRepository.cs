using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class AnswerOptionRepository : GenericRepository<AnswerOption>, ISurveyInstanceQuestionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AnswerOptionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
