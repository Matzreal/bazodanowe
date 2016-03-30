using System;
using System.Collections.Generic;

namespace Store.Domain.Model.Order
{
    public class Order  // Entity
    {
        public Guid Id { get; set; }
        public List<Product.Product> ProductList { get; set; }
        public Client.Client Recipent { get; set; }
        public double PaymentNetto { get; set; }
        public double PaymentBrutto { get; set; }
        public PaymentType PaymentType { get; set; }
        public StatusType StatusType { get; set; }
    }
}
