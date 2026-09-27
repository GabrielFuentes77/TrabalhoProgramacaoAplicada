using System.Globalization;

namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Reserva reserva = new Reserva
        {
            Id = 1,
            NomeHospede = "Ana Silva",
            NumeroQuarto = 203,
            QuantidadeDiarias = 3,
            ValorDiaria = 250m,
            StatusInterno = "Pagamento aprovado",
            ObservacaoInterna = "Cadastro conferido pela recepção"
        };

        RelatorioReservaDto relatorio = Mapear(reserva);
        ExibirRelatorio(relatorio);

        Console.WriteLine("\nPressione qualquer tecla para finalizar...");
        Console.ReadKey(true);
    }

    public static RelatorioReservaDto Mapear(Reserva reserva)
    {
        return new RelatorioReservaDto(
            reserva.NomeHospede,
            reserva.NumeroQuarto,
            reserva.QuantidadeDiarias,
            reserva.QuantidadeDiarias * reserva.ValorDiaria,
            "Reserva confirmada"
        );
    }

    public static void ExibirRelatorio(RelatorioReservaDto relatorio)
    {
        Console.WriteLine("=== Relatório de reserva ===");
        Console.WriteLine($"Hóspede: {relatorio.NomeHospede}");
        Console.WriteLine($"Quarto: {relatorio.NumeroQuarto}");
        Console.WriteLine($"Quantidade de diárias: {relatorio.QuantidadeDiarias}");
        Console.WriteLine($"Valor total: {relatorio.ValorTotal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
        Console.WriteLine($"Situação: {relatorio.Situacao}");
    }
}
