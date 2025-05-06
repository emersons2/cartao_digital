using Microsoft.AspNetCore.Mvc;

namespace cartao_digital.API.Controllers;

/// <summary>
/// Endpoint de cálculo simples - Exercício de C# básico.
/// </summary>
[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    /// <summary>
    /// Soma dois valores informados.
    /// </summary>
    /// <param name="input1">Valor 1</param>
    /// <param name="input2">Valor 2</param>
    /// <returns>Resultado calculado</returns>
    [HttpGet("sum")]
    public string Sum(string input1, string input2)
    {
        var number1 = double.Parse(input1);
        var number2 = double.Parse(input2);
        var result = number1 + number2;
        return result.ToString("n2");
    }

    /// <summary>
    /// Multiplica dois valores informados.
    /// </summary>
    /// <param name="input1">Valor 1</param>
    /// <param name="input2">Valor 2</param>
    /// <returns>Resultado calculado</returns>
    [HttpPut("multiply")]
    public string Multiply(string input1, string input2)
    {
        var number1 = double.Parse(input1);
        var number2 = double.Parse(input2);
        var result = number1 * number2;
        return result.ToString("n2");
    }

    /// <summary>
    /// Divide um valor informado por outro.
    /// </summary>
    /// <param name="request">Objeto contendo dos valores a serem usados na operação.</param>
    /// <returns>Resultado calculado</returns>
    [HttpPost("divide")]
    public string Divide([FromBody] DivideRequest request)
    {
        var number1 = double.Parse(request.Input1);
        var number2 = double.Parse(request.Input2);
        var result = number1 / number2;
        return result.ToString("n2");
    }

    public class DivideRequest
    {
        public required string Input1 { get; set; }
        public required string Input2 { get; set; }
    }
}
