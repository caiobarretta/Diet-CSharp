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
    public class DietaRepository : DefaultRepository<Dietum>, IDietaRepository
    {
        public override Dietum Get(int id)
        {
            throw new NotImplementedException();
        }

        public override Dietum Get(Dietum entity)
        {
            throw new NotImplementedException();
        }

    }
}
