using Core.Infrastructure;
using Core.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public bool IsLogin(string nome, string senha, out int codigoUsuario)
        {
            return _usuarioRepository.IsUsuario(nome, senha, out codigoUsuario);
        }
    }
}
