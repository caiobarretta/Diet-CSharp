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
    public class RefeicoesRepository : DefaultRepository<Refeico>, IRefeicoesRepository
    {
        public RefeicoesRepository(DietCScharpContext ctx) : base(ctx)
        {
        }
    }
}
