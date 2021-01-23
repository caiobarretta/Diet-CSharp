using Core.Entities.DietcSharp;
using Core.Interfaces;
using Core.Interfaces.Repository;
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
    public class DiaDaSemanaService : DefaultService<DiaDaSemana>, IDiasdaSemanaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DiaDaSemanaService(IUnitOfWork unitOfWork) : base(unitOfWork.DiasdaSemanaRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public void AssociarDiasDaSemanaRefeicoes(List<int> listIdDiasdaSemana, int iD_PorcAlimento)
        {
            _unitOfWork.DiasdaSemanaRepository.AssociarDiasDaSemanaRefeicoes(listIdDiasdaSemana, iD_PorcAlimento);
        }
    }
}
