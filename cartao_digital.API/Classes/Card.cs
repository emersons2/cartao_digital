namespace cartao_digital.API.Classes;

public class Card
{
    public int Id { get; set; }

    public string? CardNumber { get; set; }

    public string? CardHolderName { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string? Cvv { get; set; }

    public int CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public List<Transaction>? Transactions { get; set; }
}
