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
    public class DietaRepository : DefaultRepository<Dietum>, IDietaRepository
    {
        public DietaRepository(DietCScharpContext ctx) : base(ctx)
        {
        }
    }
}
