using System;
using System.Collections.Generic;
using System.Text;

namespace Task26_27
{
    interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Delete(int index);

        void Update(int index, T entity);
    }
}
