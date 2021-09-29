using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Mvc;
using PL.ViewModels;

namespace PL.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStoreService _storeService;

        public StoreController(IMapper mapper, IStoreService storeService)
        {
            _mapper = mapper;
            _storeService = storeService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<StoreViewModel> GetStoreAsync(int id)
        {
            var store = await _storeService.GetStoreAsync(id);
            return _mapper.Map<StoreViewModel>(store);
        }

        [HttpGet]
        public async Task<StoreResponseViewModel> GetStoresAsync(int page = 1, int pageSize = 3)
        {
            var responseModel = await _storeService.GetStoresAsync(page - 1, pageSize);
            return _mapper.Map<StoreResponseViewModel>(responseModel);
        }
    }
}
