using Store.Common;
using Store.Domain.Model.Product;
using System.Collections.Generic;

namespace Store.Application
{
    public interface IProductService : IGenericService<Product>
    {
        IList<Product> GetByCategory(string categorySub);
    }
}
