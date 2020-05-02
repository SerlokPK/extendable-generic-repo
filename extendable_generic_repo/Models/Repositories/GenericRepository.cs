using extendable_generic_repo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace extendable_generic_repo.Models.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbContext _entities;
        protected readonly DbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }
        public T Add(T entity)
        {
            return _dbset.Add(entity).Entity;
        }

        public T Delete(T entity)
        {
            // We can use this to change status to D if we don't want physical delete
            return _dbset.Remove(entity).Entity;
        }

        public void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
