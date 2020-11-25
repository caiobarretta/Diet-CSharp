using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repository
{
    public class UsuarioRepository : DefaultRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DietCScharpContext ctx) : base(ctx) => DataSeeder.SeedUsers(ctx);

        public override Usuario Get(int id) => base._ctx.Usuarios.Where(x => x.ID_Usuario == id).FirstOrDefault();

        public override Usuario Get(Usuario entity)
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
    }
}
