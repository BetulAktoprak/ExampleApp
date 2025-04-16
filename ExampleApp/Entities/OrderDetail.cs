using ExampleApp.Entities;

namespace ExampleProject.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int KDV { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
