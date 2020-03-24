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
    [Route("api/traffic")]
    [ApiController]
    public class TrafficController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        public TrafficController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllTraffic()
        {
            try
            {
                var traffic = _repository.Traffic.GetAllTraffic();
                var trafficResult = _mapper.Map<IEnumerable<TrafficDto>>(traffic);
                return Ok(trafficResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}