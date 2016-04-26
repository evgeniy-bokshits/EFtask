using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Task13_EntityFramework.DAL.Interfaces;

namespace Task13_EntityFramework.DAL
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public OrderStatus OrderDetails
        {
            get
            {
                if (RequiredDate == null || RequiredDate < DateTime.Now)
                {
                    return OrderStatus.InProgress;
                }
                return OrderStatus.Completed;
            }
        }

        [Required]
        public virtual Customer Customer { get; set; }
    }

    public enum OrderStatus
    {
        InProgress,
        Completed
    }
}
