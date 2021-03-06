﻿using System;
using System.Collections.Generic;

namespace Store.Common
{
    public interface IGenericRepository<T>
    {
        void Insert(T obj);
        void Delete(Guid id);

        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
