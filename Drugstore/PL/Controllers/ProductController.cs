using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PL.ViewModels;

namespace PL.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;

        public ProductController(IMapper mapper, IProductService productService, IProductImageService productImageService)
        {
            _mapper = mapper;
            _productService = productService;
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<ProductResponseViewModel> GetProductsAsync(int page = 1, int pageSize = 3)
        {
            var responseModel = await _productService.GetProductsAsync(page - 1, pageSize);
            return _mapper.Map<ProductResponseViewModel>(responseModel);
        }

        [HttpGet]
        [Route("images")]
        public async Task<ProductImageViewModel> GetProductImageAsync(int productId)
        {
            var baseUrl = Request.Scheme + "://" + Request.Host + '/';
            var image = await _productImageService.GetProductImageAsync(productId);

            if(image == null)
            {
                return null;
            }

            image.Path = Path.Combine(baseUrl, image.Path);

            return _mapper.Map<ProductImageViewModel>(image);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ProductViewModel> GetProductByIdAsync(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        //[HttpGet]
        //[Route("{stocks/storeId}")]
        //public async Task<StockViewModel> GetStocksByStoreId(int storeId)
        //{
        //    var stocks = await _productService.GetStocksByStoreIdAsync(storeId);
        //    return _mapper.Map<StockViewModel>(stocks);
        //}
    }
}
