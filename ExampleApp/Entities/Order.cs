using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Entities;

namespace ExampleProject.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Guid CariId { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int Amount { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Cari? Cari { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
