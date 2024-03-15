﻿using System.Linq.Expressions;

namespace BusinessApplicationProject.Repository
{
    public interface ITemporalRepository<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> GetAllAsOf(DateTime timestamp);

        public IEnumerable<T> FindAsOf(DateTime timestamp, Expression<Func<T, bool>> condition);
    }
}