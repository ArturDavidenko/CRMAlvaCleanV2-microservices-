using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.DTOs
{
    public class OrderDTO
    {
        public string OrderType { get; set; }

        public string CustomerId { get; set; }

        public string Status { get; set; }

        public string Address { get; set; }

        public string OrderPriceType { get; set; }

        public string? ClientComments { get; set; }

        public DateTime OrderStartDate { get; set; }

        public double Area { get; set; }

        public double Hour { get; set; }

        public string CustomerName { get; set; }

        public double Price { get; set; }
    }
}
