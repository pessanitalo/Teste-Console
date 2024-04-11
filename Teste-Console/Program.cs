using Teste_Console.Context;

var context = new DataContext();

var cidades = context.Cidades.ToList();
foreach (var produto in cidades)
{
    Console.WriteLine($"Cidades: {produto.Cidades}");
}

Console.ReadLine();
