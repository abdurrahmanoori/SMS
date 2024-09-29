using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;

namespace Repositories
{
    public class EducationalDegreeRepository : GenericRepository<EducationalDegree>, IEducationalDegreeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EducationalDegreeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
