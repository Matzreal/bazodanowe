using Store.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ObjectMothers
{
    public class ProductObjectMother
    {
        public static Product CreateProduct()
        {
            var product = new Product
            {
                Id = new Guid(),
                Name = "productName",
                Category = new Category("Top category", "Sub category"),
                Netto = 100.00,
                Brutto = 123.00,
                Description = "productDescription"
            };

            return product;
        }
    }
}
