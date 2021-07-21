using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeList.Application.Interfaces;

namespace GradeList.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {

        private readonly GradeDbContext _gradeDbContext;

        public Repository(GradeDbContext gradeDbContext)
        {
            _gradeDbContext = gradeDbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _gradeDbContext.Set<TEntity>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _gradeDbContext.AddAsync(entity);
                await _gradeDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _gradeDbContext.Update(entity);
                await _gradeDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }

        public async Task UpdateRangeAsync(List<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException($"{nameof(UpdateRangeAsync)} entities must not be null");
            }

            try
            {
                _gradeDbContext.UpdateRange(entities);
                await _gradeDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entities)} could not be updated");
            }
        }
    }
}
