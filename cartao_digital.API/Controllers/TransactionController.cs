using cartao_digital.API.Classes;
using Microsoft.AspNetCore.Mvc;


namespace cartao_digital.API.Controllers;

/// <summary>
/// Cria e estorna transações. Também exporta extratos de transações por período.
/// </summary>
[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    /// <summary>
    /// Cria nova transação
    /// </summary>
    /// <param name="transaction">Detalhes da transação a ser criada.</param>
    /// <returns>Detalhes da transação efetivada.</returns>
    [HttpPost("Create")]
    public async Task<Transaction> CreateTransaction([FromBody] Transaction transaction)
    {
        return await Task.FromResult(transaction);
    }

    /// <summary>
    /// Estorna uma transação existente
    /// </summary>
    /// <param name="transactionId">Id da transação a ser revertida</param>
    /// <returns>Detalhes da transação de reversão</returns>
    [HttpPost("Revert")]
    public async Task<Transaction> RevertTransaction([FromBody] int transactionId)
    {
        var transaction = new Transaction
        {
            Id = transactionId,
            Description = "Reverted Transaction",
            Amount = -100.00m,
            Date = DateTime.Now,
            CardId = 1,
            CustomerId = 1
        };

        return await Task.FromResult(transaction);
    }

    /// <summary>
    /// Exporta extrato de transações por período em formato CSV.
    /// </summary>
    /// <param name="startDate">Data de inicio</param>
    /// <param name="endDate">Data final</param>
    /// <returns></returns>
    [HttpGet("Export")]
    public IActionResult ExportTransactions(DateTime startDate, DateTime endDate)
    {
        return Ok("Transactions exported successfully.");
    }
}
