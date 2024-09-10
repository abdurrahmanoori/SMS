using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class RespondentRepository : GenericRepository<Respondent>, IRespondentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RespondentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }
    }
}
