using Core.Entities.DietcSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    public static class DbInitializerExtesion
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perfil>().HasData(
                new Perfil() { ID_Perfil = 1, Nome = "Nutricionista", Descricao = "Nutricionista"},
                new Perfil() { ID_Perfil = 2, Nome = "Paciente", Descricao = "Paciente" }
                );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { Nome = "Nutri", Descricao = "Nutricionista", Senha = "1234", ID_Perfil = 1}
                );

        }
    }
}
