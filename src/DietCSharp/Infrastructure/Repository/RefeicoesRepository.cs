using Core.Entities.DietcSharp;
using Core.Interfaces.Repository;
using Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RefeicoesRepository : DefaultRepository<Refeicao>, IRefeicoesRepository
    {
        public RefeicoesRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public List<Refeicao> RetornaRefeicoesPeloIdDaProcaoDeAlimento(int id)
        {
            using (var ctx = new DietCScharpContext())
            {
                var refeicoes = (from refeicao in ctx.Refeicaos
                                 join refPorc in ctx.RefeicaoPorcaoDeAlimentos on refeicao.ID equals refPorc.ID_Refeicao
                                 join porc in ctx.PorcaoDeAlimentos on refPorc.ID_PorcAlimento equals porc.ID
                                 where porc.ID == id select refeicao).ToList();
                return refeicoes;
            }
        }
    }
}
