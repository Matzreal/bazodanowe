using System;
using System.Collections.Generic;

namespace Store.Common
{
    public interface IGenericService<T>
    {
        void Insert(T obj);
        void Delete(Guid id);

        T GetById(Guid id);
        IList<T> GetAll();
    }
}
