
using GestaoFuncionarios;

// Cria lista de funcionarios
List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Funcionario("Maria", new DateTime(2000, 10, 18), 2009.44m, "Operador"),
            new Funcionario("João", new DateTime(1990, 5, 12), 2284.38m, "Operador"),
            new Funcionario("Caio", new DateTime(1961, 5, 2), 9836.14m, "Coordenador"),
            new Funcionario("Miguel", new DateTime(1988, 10, 14), 19119.88m, "Diretor"),
            new Funcionario("Alice", new DateTime(1995, 1, 5), 2234.68m, "Recepcionista"),
            new Funcionario("Heitor", new DateTime(1999, 11, 19), 1582.72m, "Operador"),
            new Funcionario("Arthur", new DateTime(1993, 3, 31), 4071.84m, "Contador"),
            new Funcionario("Laura", new DateTime(1994, 7, 8), 3017.45m, "Gerente"),
            new Funcionario("Heloísa", new DateTime(2003, 5, 24), 1606.85m, "Eletricista"),
            new Funcionario("Helena", new DateTime(1996, 9, 2), 2799.93m, "Gerente")
        };

// Removendo funcionário João
funcionarios.RemoveAll(func => func.Nome == "João");

// Exibindo a lista dos funcionários
Console.WriteLine("Lista de Funcionários Atualizada:");
funcionarios.ForEach(Console.WriteLine);

// Reajuste do salário em 10%
funcionarios.ForEach(func => func.Salario *= 1.10m);

// Agrupando funcionários por função
Console.WriteLine("\nFuncionários agrupados por função:");
var agrupadosPorFuncao = funcionarios.GroupBy(f => f.Funcao);
foreach (var grupo in agrupadosPorFuncao)
{
    Console.WriteLine($"\n{grupo.Key}:");
    grupo.ToList().ForEach(Console.WriteLine);
}

// Aniversariantes de outubro(10) e dezembro(12)
Console.WriteLine("\nAniversariantes de Outubro e Dezembro:");
funcionarios.Where(f => f.DataNascimento.Month == 10 || f.DataNascimento.Month == 12)
            .ToList().ForEach(Console.WriteLine);

// Funcionário com maior idade
var maisVelho = funcionarios.OrderBy(f => f.DataNascimento).First();
Console.WriteLine($"\nFuncionário com maior idade: {maisVelho.Nome}, Idade: {maisVelho.CalcularIdade()} anos");

// Lista de funcionários em ordem alfabética
Console.WriteLine("\nFuncionários em ordem alfabética:");
funcionarios.OrderBy(f => f.Nome).ToList().ForEach(Console.WriteLine);

// Total dos salários(soma)
var totalSalarios = funcionarios.Sum(f => f.Salario);
Console.WriteLine($"\nTotal dos salários: {totalSalarios:C}");

// Quantos salários mínimos cada funcionário ganha
const decimal salarioMinimo = 1212.00m;
Console.WriteLine("\nSalários mínimos por funcionário:");
funcionarios.ForEach(f => Console.WriteLine($"{f.Nome} ganha {(f.Salario / salarioMinimo):F2} salários mínimos"));

