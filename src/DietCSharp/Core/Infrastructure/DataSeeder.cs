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
            var perfilNutricionista = ctx.Perfils.Where(x => x.Nome == "Nutricionista").FirstOrDefault();
            if (perfilNutricionista == null)
            {
                ctx.Add(new Perfil()
                {
                    Nome = "Nutricionista",
                    Descricao = "Nutricionista"
                });
                ctx.SaveChanges();
            }

            var nutricionistaPadrao = ctx.Usuarios.Where(x => x.Nome == "Nutricionista").FirstOrDefault();
            if (nutricionistaPadrao == null)
            {
                ctx.Add(new Usuario()
                {
                    Usuario1 = "Nutri",
                    Nome = "Nutri",
                    Descricao = "Nutricionista",
                    Senha = "1234",
                    ID_Perfil = perfilNutricionista.ID_Perfil
                });
                ctx.SaveChanges();
            }


            var perfilPaciente = ctx.Perfils.Where(x => x.Nome == "Paciente").FirstOrDefault();
            if (perfilPaciente == null)
            {
                ctx.Add(new Perfil()
                {
                    Nome = "Paciente",
                    Descricao = "Paciente"
                });
                ctx.SaveChanges();
            }

            

        }
    }
}
