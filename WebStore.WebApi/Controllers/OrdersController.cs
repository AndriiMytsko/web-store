﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;

namespace WebStore.WebApi.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task Post([FromBody]IEnumerable<OrderDetailsDto> orderDetails)
        {
            await _orderService.CreateAsync(orderDetails);
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDto>> Get()
        {
            return await _orderService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<OrderDto> Get(int id)
        {
            return await _orderService.GetAsync(id);
        }

        [HttpGet("{id}/details")]
        public async Task<IEnumerable<OrderDetailsDto>> GetOrderWithProducts(int id)
        {
            return await _orderService.GetOrderWithProductsAsync(id);
        }

        [HttpPut("{id}")]
        public async Task Put(OrderDto order)
        {
            await _orderService.UpdateAsync(order);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _orderService.DeleteAsync(id);
        }
    }
}