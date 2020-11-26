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
        public static void SeedUsers()
        {
            using (var ctx = new DietCScharpContext())
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
                        Nome = "Nutricionista",
                        Descricao = "Nutricionista",
                        Senha = "1234",
                        ID_Perfil = 1
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

                var diasDaSemana = ctx.DiasdaSemanas.ToList();
                if (diasDaSemana.Count <= 0)
                {
                    var listDiaDaSemana = new List<DiasdaSemana>()
                    {
                        new DiasdaSemana() { Nome = "Domingo", Descricao = "Domingo"},
                        new DiasdaSemana() { Nome = "Segunda-Feira", Descricao = "Segunda-Feira"},
                        new DiasdaSemana() { Nome = "Terça-Feira", Descricao = "Terça-Feira"},
                        new DiasdaSemana() { Nome = "Quarta-Feira", Descricao = "Quarta-Feira"},
                        new DiasdaSemana() { Nome = "Quinta-Feira", Descricao = "Quinta-Feira"},
                        new DiasdaSemana() { Nome = "Sexta-Feira", Descricao = "Sexta-Feira"},
                        new DiasdaSemana() { Nome = "Sábado", Descricao = "Sábado"},
                    };

                    foreach (var diasdaSemana in listDiaDaSemana)
                    {
                        ctx.Add(diasdaSemana);
                        ctx.SaveChanges();
                    }
                    
                }

            }

        }
    }
}
