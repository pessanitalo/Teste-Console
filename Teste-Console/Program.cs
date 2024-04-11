using Teste_Console.Context;

var context = new DataContext();

var cidades = context.Cidades.ToList();
foreach (var produto in cidades)
{
    Console.WriteLine($"Cidades: {produto.Cidades}");
}

var arq1 = @"C:\Users\italo pessan\Desktop\Projeto\arquivo1.txt";
var arq2 = @"C:\Users\italo pessan\Desktop\Projeto\arquivo2.txt";

FileInfo fileInfo = new FileInfo(arq1);
fileInfo.CopyTo(arq2);

string[] lines = File.ReadAllLines(arq1);

foreach (string line in lines)
{
    Console.WriteLine(line);
}

Console.ReadLine();
