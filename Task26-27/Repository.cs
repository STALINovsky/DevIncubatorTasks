using System;
using System.Collections.Generic;
using System.Text;

namespace Task26_27
{
    /// <summary>
    /// Class for memory repository 
    /// </summary>
    /// <typeparam name="T">needs to be Entity</typeparam>
    class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _data = new List<T>();
        public IReadOnlyList<T> Data => _data;

        private bool IsIndexValid(int index) => index < 0 || index >= _data.Count;

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public void Delete(int index)
        {
            if (!IsIndexValid(index))
            {
                throw new ArgumentOutOfRangeException(nameof(index), index, "Invalid value of Id");
            }

            _data.RemoveAt(index);
        }

        public void Update(int index, T entity)
        {
            if (!IsIndexValid(index))
            {
                throw new ArgumentOutOfRangeException(nameof(index), index, "Invalid value of Id");
            }

            _data[index] = entity;
        }
    }
}
