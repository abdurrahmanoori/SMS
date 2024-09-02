using Entities.Data;
using RepositoryContracts.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        // private IPatientTypeRepository _patientTypeRepository;


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            // ProvinceRepository = new ProvinceRepository(db);
        }


        public async Task SaveChanges(CancellationToken cancellationToken)
        {
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
