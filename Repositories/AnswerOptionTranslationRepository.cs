using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class AnswerOptionTranslationRepository : GenericRepository<AnswerOptionTranslation>, IAnswerOptionTranslationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AnswerOptionTranslationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }
    }
}
