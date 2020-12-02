using Core.Entities.DietcSharp;
using Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PerfilRepository : DefaultRepository<Perfil>, IPerfilRepository
    {

    }
}
