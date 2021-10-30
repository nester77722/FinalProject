using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DrugstoreDBContext _dbContext;

        public ProductRepository(DrugstoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public async Task<ProductResponse> GetProductsAsync(int page, int pageSize, Sortings sorting)
        {
            var products = _dbContext.Products.AsNoTracking();

            switch (sorting)
            {
                case Sortings.SortByName:
                    products = products.OrderBy(products => products.Name);
                    break;
                case Sortings.SortByPrice:
                    products = products.OrderBy(products => products.Price);
                    break;
                default:
                    throw new ArgumentException("Sorting filter exception");
            }

            return new ProductResponse
            {
                TotalProducts = await products.CountAsync(),
                Products = await products
                            .Skip(page * pageSize)
                            .Take(pageSize)
                            .ToListAsync()
            };
        }

        public async Task<ICollection<Stock>> GetStocksByStoreIdAsync(int storeId)
        {
            return await _dbContext.Stocks.ToListAsync();
        }
    }
}
