using Teste_Console.Models;
using Teste_Console.Services;

var arquivo = @"C:\Users\italo pessan\Desktop\Projeto\arquivo2.txt";

BuscarLista buscarLista = new BuscarLista();
List<Join> busca = buscarLista.BuscaLista();

using (StreamWriter sw = File.CreateText(arquivo))
{
    foreach (var item in busca)
    {
        sw.WriteLine($"{item.Cidade}, {item.Estado}");
    }
}
Console.WriteLine("final");
Console.ReadLine();
