namespace ClientServiceRazor.Features.Clients.Models;

public class Phone
{
    public int Id { get; set; }
    public string Number { get; set; }
    public CountryCode CountryCode { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CLiendId { get; set; }
    public Client? _Client { get; set; }
}

public enum CountryCode
{
    UA = 380,
    US = 1, 
    GB = 44, 
    DE = 49,
    FR = 33
}

