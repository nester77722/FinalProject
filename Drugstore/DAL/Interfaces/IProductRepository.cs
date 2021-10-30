using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductResponse> GetProductsAsync(int page, int pageSize, Sortings sorting);
        Task<Product> GetProductByIdAsync(int id);
        Task<ICollection<Stock>> GetStocksByStoreIdAsync(int storeId);
    }
}
