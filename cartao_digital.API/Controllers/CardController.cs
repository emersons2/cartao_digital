using cartao_digital.API.Classes;
using Microsoft.AspNetCore.Mvc;

namespace cartao_digital.API.Controllers;

/// <summary>
/// Cria, consulta e excluí um cartão.
/// </summary>
[ApiController]
[Route("[controller]")]
public class CardController : ControllerBase
{
    /// <summary>
    /// Obtem um cartão associado a um cliente.
    /// </summary>
    /// <param name="customerId">Id do cliente</param>
    /// <returns>Detalhes do cartão</returns>
    [HttpGet("{customerId}/card")]
    public async Task<Card> GetCustomerCard(int customerId)
    {
        var card = new Card
        {
            Id = 1,
            CardNumber = "1234-5678-9012-3456",
            CardHolderName = "John Doe",
            ExpirationDate = DateTime.Now.AddYears(1),
            Cvv = "123",
            CustomerId = customerId
        };

        return await Task.FromResult(card);
    }

    /// <summary>
    /// Cria um cartão associado a um cliente.
    /// </summary>
    /// <param name="customerId">Id do cliente</param>
    /// <returns>Detalhes do cartão</returns>
    [HttpPost("{customerId}/card")]
    public async Task<Card> CreateCustomerCard(int customerId)
    {
        var card = new Card
        {
            Id = 1,
            CardNumber = "1234-5678-9012-3456",
            CardHolderName = "John Doe",
            ExpirationDate = DateTime.Now.AddYears(1),
            Cvv = "123",
            CustomerId = customerId
        };

        return await Task.FromResult(card);
    }

    /// <summary>
    /// Exclui um cartão associado a um cliente.
    /// </summary>
    /// <param name="customerId">Id do cliente</param>
    /// <param name="cardId">Id do cartão</param>
    /// <returns></returns>
    [HttpDelete("{customerId}/card/{cardId}")]
    public async Task DeleteCustomerCard(int customerId, int cardId)
    {
        await Task.CompletedTask;
    }
}
