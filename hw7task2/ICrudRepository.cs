using System;
using System.Collections.Generic;
using System.Text;

namespace hw7task2
{
    public interface ICrudRepository<T>
    {
        T Create(T item);
        List<T> GetAll();
        T GetById(int id);
        T Update(int id, T item);
        void Delete(int id);
    }
}
