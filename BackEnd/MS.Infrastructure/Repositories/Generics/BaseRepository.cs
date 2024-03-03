using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Infrastructure.Contexts;
using System.Linq.Expressions;

namespace MS.Infrastructure.Repositories.Generics
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Vars / Props

        protected readonly Context _dbContext;

        #endregion

        #region Constructor(s)
        public BaseRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion


        #region Methods

        #endregion

        #region Actions
        public virtual async Task<T> GetByIdAsync(int id) =>
            await _dbContext.Set<T>().FindAsync(id);


        public IQueryable<T> GetTableNoTracking()=>
            _dbContext.Set<T>().AsNoTracking().AsQueryable();


        public virtual async Task AddRangeAsync(ICollection<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();

        }
        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();

        }

        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            foreach (T entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()=>
            await _dbContext.SaveChangesAsync();



        public IDbContextTransaction BeginTransaction() =>
            _dbContext.Database.BeginTransaction();

        public void Commit()=>
            _dbContext.Database.CommitTransaction();

        public void RollBack()=>
            _dbContext.Database.RollbackTransaction();

        public IQueryable<T> GetTableAsTracking()=> _dbContext.Set<T>().AsQueryable();


        public virtual async Task UpdateRangeAsync(ICollection<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        => await _dbContext.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetByNameAsync(Expression<Func<T, bool>> expression, string name)
         => await _dbContext.Set<T>().Where(expression).ToListAsync();

        public async Task<IEnumerable<T>> GetByExpressionAsync(Expression<Func<T, bool>> expression) 
            => await _dbContext.Set<T>().Where(expression).ToListAsync();

        #endregion
    }
}
