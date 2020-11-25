using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repository
{
    public class PorcaoDeAlimentoRepository : DefaultRepository<PorcaoDeAlimento>, IPorcaoDeAlimentoRepository
    {
        public void AssociarPorcaoRefeicoes(List<int> listIdRefeicao, int idPorcaoDeAlimento)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var idRefeicao in listIdRefeicao)
                {
                    ctx.Rel_Ref_Porcs.Add(new Rel_Ref_Porc()
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
            throw new NotImplementedException();
        }

        public override PorcaoDeAlimento Get(PorcaoDeAlimento entity)
        {
            throw new NotImplementedException();
        }

    }
}
