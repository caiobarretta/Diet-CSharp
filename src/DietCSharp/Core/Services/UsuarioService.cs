using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Infrastructure;
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
    public class UsuarioService : DefaultService<Usuario>, IUsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly PerfilRepository _perfilRepository;
        public UsuarioService() : base(new UsuarioRepository(new DietCScharpContext()))
        {
            var ctx = new DietCScharpContext();
            _usuarioRepository = new UsuarioRepository(ctx);
            _perfilRepository = new PerfilRepository(ctx);
        }
        public bool IsUsuario(string nome, string senha, out int CodigoUsuario) => _usuarioRepository.IsUsuario(nome, senha, out CodigoUsuario);

        public TipoUsuario GetTipoUsuarioById(int id)
        {
            var usuario = _usuarioRepository.Get(id);

            var perfil = _perfilRepository.Get(usuario.ID_Perfil);

            if (perfil == null)
                throw new Exception("Ocorreu um erro ao carregar os perfils do usuário.");

            if ("Nutricionista".ToUpper().Equals(perfil.Nome.ToUpper()))
                return TipoUsuario.Nutricionista;

            if ("Paciente".ToUpper().Equals(perfil.Nome.ToUpper()))
                return TipoUsuario.Paciente;

            else
                throw new NotImplementedException("Tipo de usuário não implementado.");
        }

    }
}
