using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using BLL.Interfaces;
using PL.ViewModels;
using BLL.Models;
using PL.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using PL.Models;
using DAL.Interfaces;
using DAL.Entities;
using PL.ViewModels.Order;

namespace PL.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(IMapper mapper, IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderAsync([FromBody] OrderViewModel orderDetails)
        {
            try
            {
                var orderModel = _mapper.Map<OrderModel>(orderDetails);
                var result = await _orderService.AddOrderAsync(orderModel);
                var mappedResults = _mapper.Map<OrderViewModel>(result);

                return Ok(mappedResults);
            }
            catch(Exception e)
            { 
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public async Task<OrderResponseViewModel> GetOrdersAsync(string userName, string page = "1", string pageSize = "3")
        {
            var parsedPage = int.Parse(page);
            var parsedPageSize = int.Parse(pageSize);
            var responseModel = await _orderService.GetOrdersAsync(parsedPage - 1, parsedPageSize, userName);
            return _mapper.Map<OrderResponseViewModel>(responseModel);
        }
    }
}
