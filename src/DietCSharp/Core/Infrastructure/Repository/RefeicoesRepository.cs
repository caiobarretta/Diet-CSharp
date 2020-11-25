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
    public class RefeicoesRepository : DefaultRepository<Refeico>, IRefeicoesRepository
    {

        public override Refeico Get(int id)
        {
            Refeico refeicao = new Refeico();
            using (var ctx = new DietCScharpContext())
                 refeicao = ctx.Refeicoes.Where(x => x.ID_Refeicao == id).FirstOrDefault();
            return refeicao;
        }

        public override Refeico Get(Refeico entity)
        {
            throw new NotImplementedException();
        }

    }
}
