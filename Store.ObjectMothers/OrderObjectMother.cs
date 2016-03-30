using Store.Domain.Model.Client;
using Store.Domain.Model.Order;
using Store.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ObjectMothers
{
    public class OrderObjectMother
    {
        public static Order CreateOrder()
        {
            var order = new Order
            {
                Id = new Guid(),
                ProductList = new List<Product>(),
                Recipent = new Client(),
                PaymentNetto = 100.00,
                PaymentBrutto = 123.00,
                PaymentType = new PaymentType(),
                StatusType = new StatusType()
            };

            return order;
        }
    }
}
