using Core.Entities.DietcSharp;
using Core.Interfaces.Repository;
using Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PorcaoDeAlimentoRepository : DefaultRepository<PorcaoDeAlimento>, IPorcaoDeAlimentoRepository
    {
        public PorcaoDeAlimentoRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public void AssociarPorcaoAlimentoDieta(List<int> listIdProcaoAlimento, int idDieta)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var idPorcaoAlimento in listIdProcaoAlimento)
                {
                    ctx.PorcaoDeAlimentoDieta.Add(new PorcaoDeAlimentoDietum()
                    {
                        ID_Dieta = idDieta,
                        ID_PorcAlimento = idPorcaoAlimento
                    });
                    ctx.SaveChanges();
                }
            }
        }

        public void AssociarPorcaoRefeicoes(List<int> listIdRefeicao, int idPorcaoDeAlimento)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var idRefeicao in listIdRefeicao)
                {
                    ctx.RefeicaoPorcaoDeAlimentos.Add(new RefeicaoPorcaoDeAlimento()
                    {
                        ID_PorcAlimento = idPorcaoDeAlimento,
                        ID_Refeicao = idRefeicao
                    });
                    ctx.SaveChanges();
                }

            }
        }

        public override PorcaoDeAlimento Get(int id)
        {
            PorcaoDeAlimento porcaoDeAlimento = null;
            using (var ctx = new DietCScharpContext())
            {
                porcaoDeAlimento = ctx.PorcaoDeAlimentos
                    .Where(x => x.ID == id)
                    .Include(x => x.PorcaoDeAlimentoDiasdaSemanas)
                    .Include(x => x.RefeicaoPorcaoDeAlimentos)
                    .FirstOrDefault();
            }
            return porcaoDeAlimento;
        }

        public override PorcaoDeAlimento Get(PorcaoDeAlimento entity)
        {
            throw new NotImplementedException();
        }

    }
}
