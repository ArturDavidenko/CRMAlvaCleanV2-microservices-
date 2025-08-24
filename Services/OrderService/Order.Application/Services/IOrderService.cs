using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Application.DTOs;
using Order.Application.RegisterModels;
using Order.Domain.Entities;
using OrderEntity = Order.Domain.Entities.Order;

namespace Order.Application.Services
{
    public interface IOrderService
    {
        public Task<OrderEntity> GetOrder(string orderId);

        public Task DeleteOrder(string orderId);

        public Task CreateOrder(RegisterOrderModel order, string customerId);

        public Task<List<OrderEntity>> GetOrdersList();

        public Task UpdateOrder(OrderDTO orderUpdatedData, string orderId);

        public Task AddOrderToEmployeer(string orderId, string employeerId);

        public Task DeleteOrderFromEmployeer(string orderId, string employeerId);

        public Task<List<OrderEntity>> GetAllOrdersOfEmployeer(string employeerId);

        public Task<List<OrderEntity>> GetAllOrdersOfCustomer(string customerId);

        public Task<List<OrderEntity>> GetListOfAllCompletedOrders();

        public Task<List<OrderEntity>> GetListOfAllCompletedOrdersOfEmployeer(string employeerId);

        public Task<List<OrderEntity>> GetListOfAllCompletedOrdersOfCustomer(string customerId);
    }
}
