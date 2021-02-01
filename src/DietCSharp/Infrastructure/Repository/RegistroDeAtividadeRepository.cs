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
    public class RegistroDeAtividadeRepository : DefaultRepository<RegistroDeAtividade>, IRegistroDeAtividadeRepository
    {
        public RegistroDeAtividadeRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public void AssociarPorcaoRegistroDeAlimentos(List<int> lstIdPorcaoDeAlimento, int id)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var idPorcaoDeAlimento in lstIdPorcaoDeAlimento)
                {
                    ctx.PorcaoDeAlimentoRegistroDeAtividades.Add(new PorcaoDeAlimentoRegistroDeAtividade()
                    {
                        ID_PorcAlimento = idPorcaoDeAlimento,
                        ID_RegistroDeAtividade = id
                    });
                    ctx.SaveChanges();
                }
            }
        }

        public List<PorcaoDeAlimento> RetornaProcaoDeAlimentoPeloRegistroDeAtividade(int id)
        {
            using (var ctx = new DietCScharpContext())
            {
                var lst = (from reg in ctx.RegistroDeAtividades
                           join regPorc in ctx.PorcaoDeAlimentoRegistroDeAtividades on reg.ID equals regPorc.ID_RegistroDeAtividade
                           join proc in ctx.PorcaoDeAlimentos on regPorc.ID_PorcAlimento equals proc.ID
                           where reg.ID == id
                           select proc).ToList();
                return lst;
            }
        }
    }
}
