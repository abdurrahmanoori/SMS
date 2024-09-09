using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public QuestionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
