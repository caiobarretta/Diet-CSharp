using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository;
using Core.Interfaces.Service;
using Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class DietaService : DefaultService<Dietum>, IDietaService
    {
        public DietaService() : base(new DietaRepository(new DietCScharpContext()))
        {
        }
    }
}
