using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _mapper;

        public StoreService(IStoreRepository storeRepository, IMapper mapper)
        {
            _storeRepository = storeRepository;
            _mapper = mapper;
        }
        public async Task<StoreModel> GetStoreAsync(int id)
        {
            var store = await _storeRepository.GetStoreByIdAsync(id);
            return _mapper.Map<StoreModel>(store);
        }

        public async Task<StoreResponseModel> GetStoresAsync(int page, int pageSize)
        {
            var stores = await _storeRepository.GetStoresAsync(page, pageSize);

            foreach(var store in stores.Stores)
            {
                store.Stocks = await _storeRepository.GetStockByStoreIdAsync(store.Id);
            }

            return _mapper.Map<StoreResponseModel>(stores);
        }
    }
}
