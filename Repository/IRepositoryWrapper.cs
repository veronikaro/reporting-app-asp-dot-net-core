using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Repository
{
    public interface IRepositoryWrapper
    {
        IOrderRepository Order { get; }
        IEmployeeRepository Employee { get; }
        ITrafficRepository Traffic { get; }
        void Save();
    }
}
