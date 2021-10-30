using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStoreService
    {
        Task<StoreResponseModel> GetStoresAsync(int page, int pageSize);
        Task<StoreModel> GetStoreAsync(int id);
    }
}
