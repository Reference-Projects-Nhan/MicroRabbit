namespace MicroRabbit.Banking.Domain.Models;

public class Account
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal AccountBalance { get; set; }
}
