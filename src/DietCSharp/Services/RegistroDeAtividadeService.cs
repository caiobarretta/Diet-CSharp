using Core.Entities.DietcSharp;
using Core.Interfaces;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegistroDeAtividadeService : DefaultService<RegistroDeAtividade>, IRegistroDeAtividadeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegistroDeAtividadeService(IUnitOfWork unitOfWork) : base(unitOfWork.RegistroDeAtividadeRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public List<PorcaoDeAlimento> RetornaProcaoDeAlimentoPeloRegistroDeAtividade(int id) => _unitOfWork.RegistroDeAtividadeRepository.RetornaProcaoDeAlimentoPeloRegistroDeAtividade(id);

        public void AssociarPorcaoRegistroDeAlimentos(List<int> lstIdPorcaoDeAlimento, int id) => _unitOfWork.RegistroDeAtividadeRepository.AssociarPorcaoRegistroDeAlimentos(lstIdPorcaoDeAlimento, id);
    }
}
