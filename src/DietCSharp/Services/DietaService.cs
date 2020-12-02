using Core.Entities.DietcSharp;
using Infrastructure.Repository;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DietaService : DefaultService<Dietum>, IDietaService
    {
        public DietaService() : base(new DietaRepository())
        {
        }
    }
}
