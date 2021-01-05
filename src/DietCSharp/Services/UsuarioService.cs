using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Infrastructure;
using Infrastructure.Repository;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.Repository;

namespace Services
{
    public class UsuarioService : DefaultService<Usuario>, IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilRepository;
        public UsuarioService(IUnitOfWork unitOfWork) : base(unitOfWork.UsuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _usuarioRepository = unitOfWork.UsuarioRepository;
            _perfilRepository = unitOfWork.PerfilRepository;
            DataSeeder.SeedUsers();
        }
        public bool IsUsuario(string usuario, string senha, out int CodigoUsuario)
        {
            return _usuarioRepository.IsUsuario(usuario, senha, out CodigoUsuario);
        }

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
