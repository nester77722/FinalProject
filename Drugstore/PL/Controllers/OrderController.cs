using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class OrderController
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(IMapper mapper, IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<OrderViewModel> GetOrderAsync(int id)
        //{
        //    var store = await _orderService.GetOrderAsync(id);
        //    return _mapper.Map<OrderViewModel>(store);
        //}
        [HttpGet]
        [Authorize]
        [Route("{userId}")]
        public async Task<OrderResponseViewModel> GetOrdersAsync(string userName, int page = 1, int pageSize = 3)
        {
            var responseModel = await _orderService.GetOrdersAsync(page - 1, pageSize, userName);
            return _mapper.Map<OrderResponseViewModel>(responseModel);
        }
    }
}
