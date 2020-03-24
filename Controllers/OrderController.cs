using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportingAppServer.Models.DataTransferObjects;
using ReportingAppServer.Repository;

namespace ReportingAppServer.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        public OrderController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _repository.Order.GetAllOrders();
                var ordersResult = _mapper.Map<IEnumerable<OrderDto>>(orders);
                return Ok(ordersResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}