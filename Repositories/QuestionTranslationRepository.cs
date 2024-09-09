using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class QuestionTranslationRepository : GenericRepository<QuestionTranslation>, IQuestionTranslationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public QuestionTranslationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
