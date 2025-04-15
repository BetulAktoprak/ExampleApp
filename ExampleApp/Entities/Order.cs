using ExampleApp.Entities;

namespace ExampleProject.Entities
{
    public class Order : BaseEntity
    {
        public Guid CariId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int FisNo { get; set; } = default!;
        public virtual Cari? Cari { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
