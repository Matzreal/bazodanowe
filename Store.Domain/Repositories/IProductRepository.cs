using Store.Common;
using Store.Domain.Model.Product;
using System.Collections.Generic;

namespace Store.Domain.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetByCategory(string category);
    }
}
