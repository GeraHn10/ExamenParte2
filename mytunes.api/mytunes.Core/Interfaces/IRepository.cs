using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace mytunes.Core.Interfaces
{
    public interface IRepository<T>
    
    { 
        IEnumerable<T> GetAll();

        IEnumerable<T> Filter(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        T Add(T entity);

        void Update(T entity);

        int SaveChanges();
        
    }
}