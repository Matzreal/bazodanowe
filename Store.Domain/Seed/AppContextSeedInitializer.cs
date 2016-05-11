using Store.Domain.Model.Client;
using Store.Domain.Model.Order;
using Store.Domain.Model.Product;
using Store.Domain.Model.Report;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Seed
{
    public class AppContextSeedInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            #region Clients
            context.Clients.Add(new Client
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "jan.kowalski@somemail.pl",
                PhoneNumber = "555-123-123",
                Address = new Address("Grunwaldzka", "Wrocław", "Dolnośląskie", "Polska", "50-357")
            });

            context.SaveChanges();
            #endregion

            #region Product
            double vat = 0.23;
            double netto = 300.00;
            context.Products.Add(new Product
            {
                Name = "Okulary przeciwsłoneczne Ray-Ban",
                Category = "Okulary",
                Netto = netto,
                Brutto = netto * vat,
                Description = "Sample description"
            });

            context.SaveChanges();
            #endregion

            #region Orders
            var productList = new List<Product>();
            productList.Add(context.Products.Single(x => x.Name == "Okulary przeciwsłoneczne Ray-Ban"));
            context.Orders.Add(new Order
            {
                ProductList = productList,
                Recipent = context.Clients.Single(x => x.FirstName == "Jan" && x.LastName == "Kowalski"),
                PaymentNetto = productList.Sum(x => x.Netto),
                PaymentBrutto = productList.Sum(x => x.Brutto),
                PaymentType = PaymentType.Card,
                StatusType = StatusType.PackageSent
            });

            context.SaveChanges();
            #endregion

            #region Report
            var orderList = new List<Order>();
            orderList.Add(context.Orders.Single(x => x.StatusType == StatusType.PackageSent));
            context.Reports.Add(new Report
            {
                OrderList = orderList,
                StartDateTime = DateTime.Now.AddDays(-7),
                EndDateTime = DateTime.Now
            });

            context.SaveChanges();
            #endregion
        }
    }
}
