using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models
{
    [Table("order")]
    public class Order
    {
        [Column("order_id")]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Country is required")]
        [Column("country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "City is required")]
        [Column("city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Order Date is required")]
        [Column("order_date")]
        public DateTime OrderDate { get; set; }
        [Column("contact_name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Column("quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Retail Category is required")]
        [Column("retail_category")]
        public string RetailCategory { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Column("price")]
        public decimal Price { get; set; }

    }
}
