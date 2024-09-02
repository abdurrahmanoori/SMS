using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts.Generic
{
    public interface IUnitOfWork
    {
        //IProvinceRepository ProvinceRepository { get; }
        Task SaveChanges(CancellationToken cancellationToken);

    }
}
