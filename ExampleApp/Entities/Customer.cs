using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Entities;

namespace ExampleProject.Entities
{
    public sealed class Customer : BaseEntity
    {
        public string FullName { get; set; } = default!;
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
    }
}
