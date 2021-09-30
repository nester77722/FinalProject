using DAL.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderRepository
    {
        Task<OrderResponse> GetOrdersAsync(int page, int pageSize, string userName);
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> AddOrderAsync(Order order);
        Task<ICollection<OrderItem>> GetOrderItems(int orderId);
    }
}
