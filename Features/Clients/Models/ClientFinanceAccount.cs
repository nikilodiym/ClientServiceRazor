namespace ClientServiceRazor.Features.Clients.Models;

public class ClientFinanceAccount
{
    public int ClientId {get; set;}
    public Client _Client { get; set; }
    public int AccountId {get; set;}
    public int FinanceAccount { get; set; }
    public FinanceAccount _FinanceAccount { get; set; }
}