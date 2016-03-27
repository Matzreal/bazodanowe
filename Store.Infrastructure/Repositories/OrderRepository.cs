using Store.Common;
using Store.Domain.Model.Order;
using Store.Domain.Repositories;

namespace Store.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
    }
}
