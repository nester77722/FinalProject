using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
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
        public async Task<OrderModel> GetOrderAsync(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);
            return _mapper.Map<OrderModel>(order);
        }

        public async Task<OrderResponseModel> GetOrdersAsync(int page, int pageSize, string userId)
        {
            var orders = await _orderRepository.GetOrdersAsync(page, pageSize, userId);
            return _mapper.Map<OrderResponseModel>(orders);
        }
    }
}
