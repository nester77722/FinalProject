using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IStoreRepository storeRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _storeRepository = storeRepository;
            _mapper = mapper;
        }

        public async Task<ProductResponseModel> GetProductsAsync(int page, int pageSize, Sortings sorting = Sortings.SortByName)
        {
            var products = await _productRepository.GetProductsAsync(page, pageSize, sorting);
            return _mapper.Map<ProductResponseModel>(products);
        }

        public async Task<ICollection<StockModel>> GetStocksByStoreIdAsync(int storeId)
        {
            var stocks = await _productRepository.GetStocksByStoreIdAsync(storeId);
            return _mapper.Map<ICollection<StockModel>>(stocks);

        }

        public async Task<ProductModel> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<ProductModel>(product);
        }
    }
}
