using Teste_Console.Context;
using Teste_Console.Models;

namespace Teste_Console.Services
{
    public class BuscarLista
    {
        DataContext context = new DataContext();
        public List<Join> BuscaLista()
        {
            var innerJoin = from c in context.Cidades
                            join e in context.Estados on c.Id equals e.Id
                            select new Join
                            {
                                Cidade = c.Cidades,
                                Estado = e.Estado
                            };
            List<Join> consulta = innerJoin.ToList();
            return consulta;
        }
    }
}
