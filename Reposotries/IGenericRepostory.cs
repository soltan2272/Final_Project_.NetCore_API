using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposotries
{
    public interface IGenericRepostory<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIDAsync(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Remove(T entity);

    }
}
