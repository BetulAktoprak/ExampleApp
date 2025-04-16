namespace ExampleApp.Entities;
public class AppUser : BaseEntity
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
    public Guid? CariId { get; set; }
    public virtual Cari? Cari { get; set; }
}
