using ExampleProject;
using ExampleProject.Entities;

namespace ExampleApp.Entities
{
    public class Cari : BaseEntity
    {
        public string FullName { get; set; } = default!;
        public int TCNo { get; set; } = default!;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int VergiNo { get; set; }
        public string VergiDairesi { get; set; } = string.Empty;
        public ICollection<Order>? Orders { get; set; }
    }
}
