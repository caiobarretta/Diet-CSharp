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
        public bool IsUsuario(string usuario, string senha, out int CodigoUsuario)
        {
            CodigoUsuario = 0;
            using (var ctx = new DietCScharpContext())
            {
                var user = ctx.Usuarios.Where(x => x.Usuario1 == usuario && x.Senha == senha).FirstOrDefault();
                if (user != null)
                {
                    CodigoUsuario = user.ID;
                    return true;
                }
            }
            return false;
        }
    }
}
