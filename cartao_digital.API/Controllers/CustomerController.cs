using cartao_digital.API.Classes;
using Microsoft.AspNetCore.Mvc;

namespace cartao_digital.API.Controllers;

/// <summary>
/// Cria, edita, consulta e excluí clientes pessoa física e jurídica.
/// </summary>
[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    /// <summary>
    /// Obtem todos os clientes pessoa jurídica cadastrados.
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    [HttpGet("Companies")]
    public async Task<IEnumerable<CustomerCompany>> GetCustomerCompanies()
    {
        var customers = new List<CustomerCompany>
        {
            new CustomerCompany
            {
                CompanyName = "Tech Corp",
                FoundationDate = DateTime.Now,
                NationalId = "12345678000195"
            },
            new CustomerCompany
            {
                CompanyName = "Tech Corp2",
                FoundationDate = DateTime.Now,
                NationalId = "12345678000195"
            }
        };

        return await Task.FromResult(customers);
    }

    /// <summary>
    /// Atualiza um cliente pessoa jurídica.
    /// </summary>
    /// <param name="customerCompany">Detalhes do cliente a ser atualizado</param>
    /// <returns>Cliente atualizado</returns>
    [HttpPut("Companies")]
    public async Task<CustomerCompany> UpdateCustomerCompany([FromBody] CustomerCompany customerCompany)
    {
        return await Task.FromResult(customerCompany);
    }

    /// <summary>
    /// Cria um novo cliente pessoa jurídica.
    /// </summary>
    /// <param name="customerCompany">Detalhes do cliente a ser criado</param>
    /// <returns>Detalhes do cliente criado</returns>
    [HttpPost("Companies")]
    public async Task<CustomerCompany> CreateCustomerCompany([FromBody] CustomerCompany customerCompany)
    {
        return await Task.FromResult(customerCompany);
    }

    /// <summary>
    /// Exclui um cliente pessoa jurídica.
    /// </summary>
    /// <param name="id">Id do cliente a ser excluido</param>
    /// <returns></returns>
    [HttpDelete("Companies")]
    public async Task DeleteCustomerCompany(int id)
    {
         await Task.CompletedTask;
    }

    /// <summary>
    /// Obtem todos os clientes pessoa física cadastrados.
    /// </summary>
    /// <returns>Lista de clientes.</returns>
    [HttpGet("Persons")]
    public async Task<IEnumerable<CustomerPerson>> GetCustomerPersons()
    {
        var customers = new List<CustomerPerson>
        {
            new CustomerPerson
            {
                Name = "John Doe",
                BirthDate = DateTime.Now,
                PersonalId = "12345678900",
                Address = "123 Main St, Springfield, USA",
                Email = "jd@company.org",
            },
            new CustomerPerson
            {
                Name = "Jane Doe",
                BirthDate = DateTime.Now,
                PersonalId = "12345678900",
                Address = "123 Main St, Springfield, USA",
                Email = "jd@company.org",
            }
        };

        return await Task.FromResult(customers);
    }

    /// <summary>
    /// Atualiza um cliente pessoa física.
    /// </summary>
    /// <param name="customerPerson">Detalhes do cliente a ser atualizado</param>
    /// <returns>Cliente atualizado</returns>
    [HttpPut("Persons")]
    public async Task<CustomerPerson> UpdateCustomerPerson([FromBody] CustomerPerson customerPerson)
    {
        return await Task.FromResult(customerPerson);
    }

    /// <summary>
    /// Cria um novo cliente pessoa física.
    /// </summary>
    /// <param name="customerPerson">Detalhes do cliente a ser criado</param>
    /// <returns>Detalhes do cliente criado</returns>
    [HttpPost("Persons")]
    public async Task<CustomerPerson> CreateCustomerPerson([FromBody] CustomerPerson customerPerson)
    {
        return await Task.FromResult(customerPerson);
    }

    /// <summary>
    /// Exclui um cliente pessoa física.
    /// </summary>
    /// <param name="id">Id do cliente a ser excluido</param>
    /// <returns></returns>
    [HttpDelete("Persons")]
    public async Task DeleteCustomerPerson(int id)
    {
        await Task.CompletedTask;
    }
}
