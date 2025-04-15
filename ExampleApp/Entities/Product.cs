using ExampleApp.Entities;
using ExampleProject.Entities;

namespace ExampleProject
{
    public class Product : BaseEntity
    {
        public string Metarial { get; set; } = default!;
        public decimal UnitPrice { get; set; }
        public string Barcode { get; set; } = default!;
        public int Stock { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
