using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models
{
    [Table("traffic")]
    public class Traffic
    {
        [Column("traffic_id")]
        public int TrafficId { get; set; }
        [Required(ErrorMessage = "Type is required")]
        [Column("type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Source is required")]
        [Column("source")]
        public string Source { get; set; }
        [Required(ErrorMessage = "Country is required")]
        [Column("country")]
        public string Country { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Sessions field is required")]
        [Column("sessions")]
        public int Sessions { get; set; }

        [Required(ErrorMessage = "Clicks field is required")]
        [Column("clicks")]
        public int Clicks { get; set; }

        [Column("campaign_cost")]
        public decimal CampaignCost { get; set; }
        [Column("purchase_cost")]
        public decimal PurchaseCost { get; set; }
        [Column("sales")]
        public int Sales { get; set; }
        [Column("opportunities")]
        public int Opportunities { get; set; }
        [Column("leads")]
        public int Leads { get; set; }

    }
}
