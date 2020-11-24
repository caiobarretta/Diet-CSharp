using Core.Entities.DietcSharp;
using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository()
        {
            using (var ctx = new DietCScharpContext())
            {
                DataSeeder.SeedUsers(ctx);
            }
        }

        public void AddAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Usuario GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario GetAsync(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsUsuario(string nome, string senha, out int CodigoUsuario)
        {
            CodigoUsuario = 0;
            using (var ctx = new DietCScharpContext())
            {
                var user = ctx.Usuarios.Where(x => x.Nome == nome && x.Senha == senha).FirstOrDefault();
                if (user != null)
                {
                    CodigoUsuario = user.ID_Usuario;
                    return true;
                }
            }
            return false;
        }

        public void UpdateAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
