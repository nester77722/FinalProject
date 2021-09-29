using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IProductImageRepository
    {
        Task<ProductImage> GetProductImageAsync(int productId);
    }
}
