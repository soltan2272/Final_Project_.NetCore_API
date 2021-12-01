using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposotries
{
    public class GenericRepostory<T> : IGenericRepostory<T> where T : BaseModel
    {
        Project_Context Context;
        DbSet<T> Table;
        public GenericRepostory(Project_Context context)
        {
            Context = context;
            Table = Context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return Table;
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            Table.Update(entity);
            return entity;
        }

        public async Task<T> Remove(T entity)
        {
            Table.Remove(entity);
            return entity;
        }

    }
}
