namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        Aluno alunoAutorizado = new Aluno
        {
            Nome = "Ana",
            Matricula = "A001",
            QuantidadeEmprestimosAtivos = 2
        };

        Aluno alunoNoLimite = new Aluno
        {
            Nome = "Bruno",
            Matricula = "A002",
            QuantidadeEmprestimosAtivos = 3
        };

        Professor professorAutorizado = new Professor
        {
            Nome = "Carla",
            Departamento = "Informática",
            QuantidadeEmprestimosAtivos = 4
        };

        Professor professorNoLimite = new Professor
        {
            Nome = "Daniel",
            Departamento = "Matemática",
            QuantidadeEmprestimosAtivos = 5
        };

        Visitante visitante = new Visitante
        {
            Nome = "Eva",
            Documento = "V001",
            QuantidadeEmprestimosAtivos = 0
        };

        UsuarioBiblioteca usuarioGenerico = new UsuarioBiblioteca
        {
            Nome = "Felipe",
            QuantidadeEmprestimosAtivos = 0
        };

        Console.WriteLine("=== Verificação de empréstimos ===");
        Console.WriteLine($"Aluno com 2 empréstimos: {VerificarEmprestimo(alunoAutorizado)}");
        Console.WriteLine($"Aluno com 3 empréstimos: {VerificarEmprestimo(alunoNoLimite)}");
        Console.WriteLine($"Professor com 4 empréstimos: {VerificarEmprestimo(professorAutorizado)}");
        Console.WriteLine($"Professor com 5 empréstimos: {VerificarEmprestimo(professorNoLimite)}");
        Console.WriteLine($"Visitante: {VerificarEmprestimo(visitante)}");
        Console.WriteLine($"Usuário genérico: {VerificarEmprestimo(usuarioGenerico)}");
        Console.WriteLine($"Objeto nulo: {VerificarEmprestimo(null)}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    public static string VerificarEmprestimo(object? obj)
    {
        return obj switch
        {
            null => "Usuário inválido",
            Aluno { QuantidadeEmprestimosAtivos: < 3 } => "Empréstimo autorizado para aluno",
            Aluno { QuantidadeEmprestimosAtivos: >= 3 } => "Limite de empréstimos atingido para aluno",
            Professor { QuantidadeEmprestimosAtivos: < 5 } => "Empréstimo autorizado para professor",
            Professor { QuantidadeEmprestimosAtivos: >= 5 } => "Limite de empréstimos atingido para professor",
            Visitante => "Visitantes não podem realizar empréstimos",
            _ => "Usuário não classificado"
        };
    }
}
