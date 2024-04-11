using Newtonsoft.Json;
using Teste_Console.Context;
using Teste_Console.Models;

var context = new DataContext();

var cidades = context.Cidades.ToList();

List<string> minhaLista = new List<string>();
minhaLista.Add("Dado 1");
minhaLista.Add("Dado 2");
minhaLista.Add("Dado 3");
foreach (var produto in cidades)
{
	Console.WriteLine($"Cidades: {produto.Cidades}");
}

var arq2 = @"C:\Users\italo pessan\Desktop\Projeto\arquivo2.txt";

string jsonCidades = JsonConvert.SerializeObject(cidades);
File.WriteAllText(arq2, jsonCidades);

//using (StreamWriter sw = new StreamWriter(arq2))
//{
//	foreach (var item in cidades)
//	{
//		sw.WriteLine(item);
//	}
//}



//string[] lines = File.ReadAllLines(arq1);

//foreach (string line in lines)
//{
//    Console.WriteLine(line);
//}

Console.ReadLine();
