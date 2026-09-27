namespace Exercicio3;

// Contém somente os dados que serão apresentados no relatório.
public record RelatorioReservaDto(
    string NomeHospede,
    int NumeroQuarto,
    int QuantidadeDiarias,
    decimal ValorTotal,
    string Situacao
);
