﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("CustomerId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? CustomerId { get; set; }

        [BsonElement("OrderType")]
        public string OrderType { get; set; }

        [BsonElement("OrderStartDate")]
        public DateTime OrderStartDate { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("OrderPriceType")]
        public string OrderPriceType { get; set; }

        [BsonElement("CustomerName")]
        public string CustomerName { get; set; }

        [BsonElement("ClientComments")]
        public string ClientComments { get; set; }

        [BsonElement("Area")]
        public double Area { get; set; }

        [BsonElement("Hour")]
        public double Hour { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }

        [BsonElement("Employeers")]
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> Employeers { get; set; }
    }
}
