using Store.Common;
using Store.Domain.Model.Order;
using System.Collections.Generic;

namespace Store.Application
{
    public interface IOrderService : IGenericService<Order>
    {
        IList<Order> GetByStatus(StatusType status);
    }
}
