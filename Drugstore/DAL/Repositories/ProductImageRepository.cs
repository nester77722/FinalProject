using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly DrugstoreDBContext _dbContext;

        public ProductImageRepository(DrugstoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductImage> GetProductImageAsync(int productId)
        {
            return await _dbContext.ProductImages.FirstOrDefaultAsync(pI => pI.ProductId == productId);
        }
    }
}
