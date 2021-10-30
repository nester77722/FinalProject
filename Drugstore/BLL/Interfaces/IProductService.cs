using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponseModel> GetProductsAsync(int page, int pageSize, Sortings sorting = Sortings.SortByName);

        Task<ProductModel> GetProductByIdAsync(int id);
        Task<ICollection<StockModel>> GetStocksByStoreIdAsync(int storeId);
    }
}
