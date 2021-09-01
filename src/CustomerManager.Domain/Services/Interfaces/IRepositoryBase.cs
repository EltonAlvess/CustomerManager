﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace CustomerManager.Domain.Services.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindById(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}