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
    public class PorcaoDeAlimentoService : DefaultService<PorcaoDeAlimento>, IPorcaoDeAlimentoService
    {
        public PorcaoDeAlimentoService() : base(new PorcaoDeAlimentoRepository())
        {
        }

        public void AssociarPorcaoRefeicoes(List<int> listIdRefeicao, int idPorcaoDeAlimento) => new PorcaoDeAlimentoRepository().AssociarPorcaoRefeicoes(listIdRefeicao, idPorcaoDeAlimento);
    }
}
