using Entities.Data;
using Repositories.Generic;
using RepositoryContracts;
using SMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DistrictRepository:GenericRepository<District>,IDistrictRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public DistrictRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
