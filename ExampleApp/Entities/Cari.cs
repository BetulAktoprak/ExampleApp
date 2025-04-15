using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleProject;

namespace ExampleApp.Entities
{
    public class Cari : BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
