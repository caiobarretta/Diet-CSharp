﻿using Core.Entities.DietcSharp;
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
    public class PerfilRepository : DefaultRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public override Perfil Get(int id) => base._ctx.Perfils.Where(x => x.ID_Perfil == id).FirstOrDefault();

        public override Perfil Get(Perfil entity)
        {
            throw new NotImplementedException();
        }

    }
}