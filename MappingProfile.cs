using AutoMapper;
using ReportingAppServer.Models;
using ReportingAppServer.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Traffic, TrafficDto>();
        }
    }
}
