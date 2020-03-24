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
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        public EmployeeController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _repository.Employee.GetAllEmployees();
                var employeesResult = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
                return Ok(employeesResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}