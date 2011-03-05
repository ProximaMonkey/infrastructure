using System;

namespace InfrastructureBaselineSolution.Models
{
    public class ZeeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Stamp { get; set; }
        public DateTime SalesOpen { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }

    public class ZeeEntityChild
    {
        public Guid Id { get; set; }
        public Guid ZeeEntityId { get; set; }
        public Guid ZeeCustomerId { get; set; }
        public decimal SoldPrice { get; set; }
        public DateTime SellStamp { get; set; }
        public DateTime Stamp { get; set; }
    }

    public class ZeeCustomer
    {
        
    }
}