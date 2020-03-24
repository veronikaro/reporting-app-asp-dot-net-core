using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models.DataTransferObjects
{
    public class TrafficDto
    {
        public int TrafficId { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public int Sessions { get; set; }
        public int Clicks { get; set; }
        public decimal CampaignCost { get; set; }
        public decimal PurchaseCost { get; set; }
        public int Sales { get; set; }
        public int Opportunities { get; set; }
        public int Leads { get; set; }
    }
}
