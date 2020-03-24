using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models.DataTransferObjects
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime OrderDate { get; set; }
        public string ContactName { get; set; }
        public int Quantity { get; set; }
        public string RetailCategory { get; set; }
        public decimal Price { get; set; }
    }
}
