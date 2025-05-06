namespace console_app;
public class Operations
{
    private List<double> Valores { get; set; } = [];

    public void ObterValor()
    {
        Console.WriteLine("Insira o valor da operação desejada, separando os centavos com vírgula:");
        var valor = Console.ReadLine();

        if (double.TryParse(valor, out var valorConvertido))
        {
            Valores.Add(valorConvertido);

            Console.WriteLine("*************************************************");
            Console.WriteLine($"Valor de {valorConvertido:N2} processado com sucesso.");
            Console.WriteLine("*************************************************");
            ConfirmarRepeticao();
        }
        else
        {
            Console.WriteLine("Valor inválido.");
            ObterValor();
        }
    }

    private void ConfirmarRepeticao()
    {
        Console.WriteLine();
        Console.WriteLine("Deseja informar outro valor? (S)im ou (N)ão");
        var keyInfo = Console.ReadKey(true);
      
        if (keyInfo.KeyChar is 'S' or 's' or (char)ConsoleKey.Enter)
        {
            ObterValor();
        }
        else if (keyInfo.KeyChar is 'N' or 'n')
        {
            Console.WriteLine();
            Console.WriteLine("Valores obtidos:");

            foreach (var valor in Valores)
            {
                Console.WriteLine(valor.ToString("N2"));
            }

            Console.WriteLine("Obrigado por sua participação. Até a próxima!");
        }
        else
        {
            Console.WriteLine("Desculpe, não entendi.");
            ConfirmarRepeticao();
        }
    }
}
