using Store.Common;
using Store.Domain.Model.Order;
using System.Collections.Generic;

namespace Store.Domain.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IEnumerable<Order> GetByStatus(StatusType status);
    }
}
