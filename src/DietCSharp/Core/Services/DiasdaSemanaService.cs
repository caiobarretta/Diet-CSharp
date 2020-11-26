using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service;
using Core.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class DiasdaSemanaService : DefaultService<DiasdaSemana>, IDiasdaSemanaService
    {
        public DiasdaSemanaService() : base(new DiasdaSemanaRepository())
        {
        }

        public void AssociarDiasDaSemanaRefeicoes(List<int> listIdDiasdaSemana, int iD_PorcAlimento) => new DiasdaSemanaRepository().AssociarDiasDaSemanaRefeicoes(listIdDiasdaSemana, iD_PorcAlimento);
    }
}
