using ReportingAppServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Repository
{
    public class TrafficRepository : RepositoryBase<Traffic>, ITrafficRepository
    {
        public TrafficRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Traffic> GetAllTraffic()
        {
            return FindAll()
                .OrderBy(tr => tr.Type)
                .ToList();
        }
    }
}
