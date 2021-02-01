using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDiasdaSemanaRepository DiasdaSemanaRepository { get; }
        IDietaRepository DietaRepository { get; }
        IPerfilRepository PerfilRepository { get; }
        IPorcaoDeAlimentoRepository PorcaoDeAlimentoRepository { get; }
        IRefeicoesRepository RefeicoesRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        IRegistroDeAtividadeRepository RegistroDeAtividadeRepository { get; }
        void Commit();
    }
}
