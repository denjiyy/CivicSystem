using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivicSystem.Data.Repositories.Contracts
{
    public interface IRepository<TType, TId>
    {
        TType GetById(TId id);

        Task<TType> GetByIdAsync(TId id);

        ICollection<TType> GetAll();

        Task<ICollection<TType>> GetAllAsync();

        void Add(TType item);

        Task AddAsync(TType item);

        bool Delete(TId id);

        Task<bool> DeleteAsync(TId id);

        bool Update(TType item);

        Task<bool> UpdateAsync(TType item);
    }
}
