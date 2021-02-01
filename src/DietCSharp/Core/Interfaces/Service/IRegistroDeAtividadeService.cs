using Core.Entities.DietcSharp;
using Core.Interfaces.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IRegistroDeAtividadeService : IService<RegistroDeAtividade>
    {
        List<PorcaoDeAlimento> RetornaProcaoDeAlimentoPeloRegistroDeAtividade(int id);
    }
}
