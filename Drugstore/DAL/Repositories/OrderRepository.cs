using DAL.Entities.Order;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DrugstoreDBContext _dbContext;

        public OrderRepository(DrugstoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _dbContext.Orders.FindAsync(id);
        }

        public async Task<OrderResponse> GetOrdersAsync(int page, int pageSize, string userName)
        {
            IQueryable<Order> orders = _dbContext.Orders
                .AsNoTracking()
                .Where(order => order.UserName == userName)
                .OrderBy(order => order.DateTime);

            return new OrderResponse
            {
                TotalOrders = await orders.CountAsync(),
                Orders = await orders.Skip(page * pageSize).Take(pageSize).ToListAsync()
            };
        }
    }
}
