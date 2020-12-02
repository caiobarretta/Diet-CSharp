using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service;
using Infrastructure.Repository;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DiasdaSemanaService : DefaultService<DiasdaSemana>, IDiasdaSemanaService
    {
        public DiasdaSemanaService() : base(new DiasdaSemanaRepository())
        {
        }

        public void AssociarDiasDaSemanaRefeicoes(List<int> listIdDiasdaSemana, int iD_PorcAlimento) => new DiasdaSemanaRepository().AssociarDiasDaSemanaRefeicoes(listIdDiasdaSemana, iD_PorcAlimento);
    }
}
