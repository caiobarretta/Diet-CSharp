using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
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
            Dietum dietum = null;
            using (var ctx = new DietCScharpContext())
            {
                dietum = ctx.Dieta
                    .Where(x => x.ID_Dieta == id)
                    .Include(x => x.Rel_Porc_Dieta)
                    .FirstOrDefault();
            }
            return dietum;
        }

        public override Dietum Get(Dietum entity)
        {
            throw new NotImplementedException();
        }

    }
}
