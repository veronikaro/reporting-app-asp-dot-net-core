using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReportingAppServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace ReportingAppServer
{
    public class RepositoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Order> Orders { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Employee> Employees { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Traffic> Traffic { get; set; }
    }
}
