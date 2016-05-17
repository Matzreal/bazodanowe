using System;
using System.Collections.Generic;
using Store.Common;
using Store.Domain.Model.Product;
using Store.Domain.Repositories;
using System.Linq;

namespace Store.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByCategory(string categorySub)
        {
            return _dictionary.Values
                .Where(x => x.Category.Sub == categorySub);
        }
    }
}
