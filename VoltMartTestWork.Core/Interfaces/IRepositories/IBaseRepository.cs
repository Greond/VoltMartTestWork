using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltMartTestWork.Core.Interfaces.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetEntities();
        Task<T> GetEntityById(int id);
        Task<T> CreateEntity(T entity);
        Task<T> UpdateEntity(T entity);
        Task DeleteEntity(T entity);
        Task<bool> IsExists  (int id);
    }
}
