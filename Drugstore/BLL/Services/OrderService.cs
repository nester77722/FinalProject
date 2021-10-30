using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities.Order;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository ordertRepository, IMapper mapper)
        {
            _orderRepository = ordertRepository;
            _mapper = mapper;
        }

        public async Task<OrderModel> AddOrderAsync(OrderModel order)
        {
            var orderEntity = _mapper.Map<Order>(order);
            return _mapper.Map<OrderModel>(await _orderRepository.AddOrderAsync(orderEntity));
        }

        public async Task<OrderModel> GetOrderAsync(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);
            return _mapper.Map<OrderModel>(order);
        }

        public async Task<OrderResponseModel> GetOrdersAsync(int page, int pageSize, string userName)
        {
            var orders = await _orderRepository.GetOrdersAsync(page, pageSize, userName);

            var result = _mapper.Map<OrderResponseModel>(orders);
            foreach (var order in result.Orders)
            {
                order.OrderItems = await GetOrderItemModelsAsync(order.Id);
            }
            return result;
        }

        private async Task<ICollection<OrderItemModel>> GetOrderItemModelsAsync(int orderId)
        {
            var orderItems = await _orderRepository.GetOrderItems(orderId);
            return _mapper.Map<ICollection<OrderItemModel>>(orderItems);
        }
    }
}
