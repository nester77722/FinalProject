using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IOrderService
    {
        Task<OrderResponseModel> GetOrdersAsync(int page, int pageSize, string userName);
        Task<OrderModel> GetOrderAsync(int id);
    }
}
