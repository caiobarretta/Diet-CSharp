using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IRegistroDeAtividadeRepository : IRepository<RegistroDeAtividade>
    {
        List<PorcaoDeAlimento> RetornaProcaoDeAlimentoPeloRegistroDeAtividade(int id);

        void AssociarPorcaoRegistroDeAlimentos(List<int> ids, int id);
    }
}
