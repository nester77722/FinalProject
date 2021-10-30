using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly DrugstoreDBContext _dbContext;

        public StoreRepository(DrugstoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Store> GetStoreByIdAsync(int id)
        {
            return await _dbContext.Stores.FindAsync(id);
        }

        public async Task<StoreResponse> GetStoresAsync(int page, int pageSize)
        {
            IQueryable<Store> stores = _dbContext.Stores.AsNoTracking().OrderBy(store => store.Name);

            return new StoreResponse
            {
                TotalStores = await stores.CountAsync(),
                Stores = await stores.Skip(page * pageSize).Take(pageSize).ToListAsync()
            };
        }

        public async Task<ICollection<Stock>> GetStockByStoreIdAsync(int storeId)
        {
            var stocks = await _dbContext.Stocks.AsNoTracking().Where(stock => stock.StoreId == storeId).ToListAsync();

            return stocks;
        }
    }
}
