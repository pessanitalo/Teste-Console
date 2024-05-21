using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Teste_Console.Context;
using Teste_Console.Models;

namespace Teste_Console.Services
{
    [MemoryDiagnoser]
    public class BuscarLista
    {
        DataContext context = new DataContext();

        //var listaAsync = await conection.QueryAsync<Cidade>(query);
        //[Benchmark]
        //public void BuscaLista()
        //{
        //    var innerJoin = from c in context.Cidades
        //                    join e in context.Estados on c.Id equals e.Id
        //                    select new Join
        //                    {
        //                        Cidade = c.Cidades,
        //                        Estado = e.Estado
        //                    };
        //    List<Join> consulta = innerJoin.ToList();
        //}

        //[Benchmark]
        //public void listaNormal()
        //{
        //    context.Cidades.ToList();
        //}

        //[Benchmark]
        //public async Task listaAsync()
        //{
        //    await context.Cidades.ToListAsync();
        //}

        [Benchmark]
        public void listaDapper()
        {
            using (IDbConnection db = new SqlConnection("Server=localhost,1433;Database=emprestimodb;User Id=sa;Password=Numsey#2021;TrustServerCertificate=True"))
            {
                string sqlQuery = @"SELECT Cidades, Sigla from [teste-praticodb].[dbo].[Cidades]";
                IEnumerable<Cidade> users = db.Query<Cidade>(sqlQuery).ToList();

            }
        }

    }
}
