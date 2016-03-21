using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        IList<Product> GetProductsByCategory(string category);

        void CreateNewProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
