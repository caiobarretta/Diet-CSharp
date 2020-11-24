using Core.Entities.DietcSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    public class DataSeeder
    {
        public static void SeedUsers(DietCScharpContext ctx)
        {
            if (!ctx.Perfils.Any())
            {
                var perfies = new List<Perfil>
                {
                new Perfil() {ID_Perfil = 1, Nome = "Nutricionista", Descricao = "Nutricionista"},
                new Perfil() {ID_Perfil = 2, Nome = "Paciente", Descricao = "Paciente" }
                };
                ctx.AddRange(perfies);
                ctx.SaveChanges();
            }

            if (!ctx.Usuarios.Any())
            {
                //var perfilNutricionista = ctx.Perfils.Where(x => x.Nome == "Nutricionista").FirstOrDefault();
                var usuarioNutricionista = new Usuario()
                {
                    Nome = "Nutri",
                    Descricao = "Nutricionista",
                    Senha = "1234",
                    ID_Perfil = 1
                };
                ctx.Add(usuarioNutricionista);
                ctx.SaveChanges();
            }
        }
    }
}
