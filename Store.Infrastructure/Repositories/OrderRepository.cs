using System.Collections.Generic;
using Store.Common;
using Store.Domain.Model.Order;
using Store.Domain.Repositories;
using System.Linq;

namespace Store.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public IEnumerable<Order> GetByStatus(StatusType status)
        {
            return _dictionary.Values
                .Where(x => x.StatusType.Equals(status));
        }
    }
}
