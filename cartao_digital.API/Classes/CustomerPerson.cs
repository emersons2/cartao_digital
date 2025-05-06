namespace cartao_digital.API.Classes;

public class CustomerPerson : Customer
{
    public string? Name { get; set; }

    public DateTime BirthDate { get; set; }

    public string? PersonalId { get; set; } // CPF 
}
