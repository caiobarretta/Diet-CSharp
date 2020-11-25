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
        public PorcaoDeAlimentoRepository(DietCScharpContext ctx) : base(ctx)
        {
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
