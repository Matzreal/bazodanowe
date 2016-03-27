using Store.Common;
using Store.Domain.Model.Product;
using Store.Domain.Repositories;

namespace Store.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
    }
}
