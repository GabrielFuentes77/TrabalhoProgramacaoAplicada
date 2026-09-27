using System.Reflection;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        Equipamento equipamento = new Equipamento
        {
            Id = 1,
            Nome = "Notebook",
            Fabricante = "Dell",
            NumeroSerie = "ABC123",
            Valor = 3500m,
            Localizacao = "Laboratório de Informática"
        };

        Console.WriteLine("=== Reflection aberta ===");
        ExibirDadosAberto(equipamento);

        Console.WriteLine();
        Console.WriteLine("=== Reflection controlada ===");
        ExibirDadosControlado(equipamento);

        Console.WriteLine("\nPressione qualquer tecla para finalizar...");
        Console.ReadKey(true);
    }

    public static void ExibirDadosAberto(object objeto)
    {
        var tipo = objeto.GetType();
        var propriedades = tipo.GetProperties();

        foreach (var propriedade in propriedades)
        {
            var valor = propriedade.GetValue(objeto);
            Console.WriteLine($"{propriedade.Name}: {valor}");
        }
    }

    public static void ExibirDadosControlado(object objeto)
    {
        var tipo = objeto.GetType();
        var propriedades = tipo.GetProperties();

        foreach (var propriedade in propriedades)
        {
            var atributo = propriedade.GetCustomAttribute<ExibirAttribute>();

            if (atributo != null)
            {
                var valor = propriedade.GetValue(objeto);
                Console.WriteLine($"{propriedade.Name}: {valor}");
            }
        }
    }
}
