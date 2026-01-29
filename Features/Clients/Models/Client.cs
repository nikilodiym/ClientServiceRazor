namespace ClientServiceRazor.Features.Clients.Models;

public class Client
{
    public int Id { get; set; }
    public string Surname { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? Patronymic { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public ICollection<Phone> Phones { get; set; } = new List<Phone>();
    public Address? Address { get; set; } 
}