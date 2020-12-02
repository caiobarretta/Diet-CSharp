using Core.Entities.DietcSharp;
using Infrastructure.Repository;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces.Repository;
using Core.Interfaces;

namespace Services
{
    public class PorcaoDeAlimentoService : DefaultService<PorcaoDeAlimento>, IPorcaoDeAlimentoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PorcaoDeAlimentoService(IUnitOfWork unitOfWork) : base(unitOfWork.PorcaoDeAlimentoRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public void AssociarPorcaoRefeicoes(List<int> listIdRefeicao, int idPorcaoDeAlimento) => _unitOfWork.PorcaoDeAlimentoRepository.AssociarPorcaoRefeicoes(listIdRefeicao, idPorcaoDeAlimento);

        public void AssociarPorcaoAlimentoDieta(List<int> listIdProcaoAlimento, int idDieta) => _unitOfWork.PorcaoDeAlimentoRepository.AssociarPorcaoAlimentoDieta(listIdProcaoAlimento, idDieta);
    }
}
