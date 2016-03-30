using System;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Model.Order;
using Store.Domain.Repositories;

namespace Store.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Delete(Guid id)
        {
            _orderRepository.Delete(id);
        }

        public IList<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }

        public Order GetById(Guid id)
        {
            return _orderRepository.GetById(id);
        }

        public IList<Order> GetByStatus(StatusType status)
        {
            return _orderRepository.GetByStatus(status).ToList();
        }

        public void Insert(Order obj)
        {
            _orderRepository.Insert(obj);
        }
    }
}
