using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Order  // Entity (Aggregate)
    {
        public Guid Id { get; set; }
        public List<Product> ProductList { get; set; }
        public Client Recipent { get; set; }
        public double PaymentNetto { get; set; }
        public double PaymentBrutto { get; set; }
        public PaymentType PaymentType { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public StatusType StatusType { get; set; }
    }
}
