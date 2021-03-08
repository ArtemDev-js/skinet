using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> Complete(); //Entity Framework will truck all the changes (Add, remowe from the lists) and then 
                              //Complete Task will save the changes for our UnitOfWort into our DB, 
                              //and returt number of changes as Int
    }
}
