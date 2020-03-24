using ReportingAppServer.Models;
using ReportingAppServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Repository
{
    public interface ITrafficRepository : IRepositoryBase<Traffic>
    {
        IEnumerable<Traffic> GetAllTraffic();
    }
}
