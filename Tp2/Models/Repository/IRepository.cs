﻿namespace Tp2.Models.Repository
{
    public interface IRepository<T>
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        T Add(T t);
        T Update(T t);
        T Delete(int Id);
    }
}
