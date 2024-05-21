using BenchmarkDotNet.Running;
using Teste_Console;
using Teste_Console.Services;

BenchmarkRunner.Run<BuscarLista>(new Config());

