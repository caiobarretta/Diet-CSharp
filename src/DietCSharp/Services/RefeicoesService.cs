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
    public class RefeicoesService : DefaultService<Refeico>, IRefeicoesService
    {
        public RefeicoesService() : base(new RefeicoesRepository())
        {

        }
    }
}
