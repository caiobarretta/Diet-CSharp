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
        public RefeicoesRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public override Refeico Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Refeico Get(Refeico entity)
        {
            throw new NotImplementedException();
        }

    }
}
