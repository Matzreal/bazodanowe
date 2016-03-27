using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Common
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private Dictionary<Guid, T> _dictionary = new Dictionary<Guid, T>();

        public void Delete(Guid id)
        {
            _dictionary.Remove(id);
        }

        public T GetById(Guid id)
        {
            return _dictionary.First(x => x.Key == id).Value;
        }

        public IEnumerable<T> GetAll()
        {
            return _dictionary.Values;
        }

        public void Insert(T obj)
        {
            _dictionary.Add(new Guid(), obj);
        }
    }
}
