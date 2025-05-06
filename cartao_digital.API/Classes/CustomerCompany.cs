namespace cartao_digital.API.Classes;

public class CustomerCompany : Customer
{
    public string? CompanyName { get; set; }

    public DateTime FoundationDate { get; set; }

    public string? NationalId { get; set; } // CNPJ 
}
