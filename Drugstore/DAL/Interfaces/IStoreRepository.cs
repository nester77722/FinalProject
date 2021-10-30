using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IStoreRepository
    {
        Task<StoreResponse> GetStoresAsync(int page, int pageSize);
        Task<Store> GetStoreByIdAsync(int id);

        Task<ICollection<Stock>> GetStockByStoreIdAsync(int storeId);
    }
}
