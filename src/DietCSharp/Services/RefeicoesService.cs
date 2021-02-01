using Core.Entities.DietcSharp;
using Infrastructure.Repository;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Services
{
    public class RefeicoesService : DefaultService<Refeicao>, IRefeicoesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RefeicoesService(IUnitOfWork unitOfWork) : base(unitOfWork.RefeicoesRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Refeicao> RetornaRefeicoesPeloIdDaProcaoDeAlimento(int id) => _unitOfWork.RefeicoesRepository.RetornaRefeicoesPeloIdDaProcaoDeAlimento(id);
    }
}
