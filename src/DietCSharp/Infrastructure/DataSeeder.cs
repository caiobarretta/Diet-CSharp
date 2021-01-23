using Core.Entities.DietcSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
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
                        Descricao = "Nutricionista",
                        Ativo = true
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
                        ID_Perfil = 1,
                        Ativo = true
                    });
                    ctx.SaveChanges();
                }


                var perfilPaciente = ctx.Perfils.Where(x => x.Nome == "Paciente").FirstOrDefault();
                if (perfilPaciente == null)
                {
                    ctx.Add(new Perfil()
                    {
                        Nome = "Paciente",
                        Descricao = "Paciente",
                        Ativo = true
                    });
                    ctx.SaveChanges();
                }

                var diasDaSemana = ctx.DiaDaSemanas.ToList();
                if (diasDaSemana.Count <= 0)
                {
                    var listDiaDaSemana = new List<DiaDaSemana>()
                    {
                        new DiaDaSemana() { Nome = "Domingo", Descricao = "Domingo", Ativo = true},
                        new DiaDaSemana() { Nome = "Segunda-Feira", Descricao = "Segunda-Feira", Ativo = true},
                        new DiaDaSemana() { Nome = "Terça-Feira", Descricao = "Terça-Feira", Ativo = true},
                        new DiaDaSemana() { Nome = "Quarta-Feira", Descricao = "Quarta-Feira", Ativo = true},
                        new DiaDaSemana() { Nome = "Quinta-Feira", Descricao = "Quinta-Feira", Ativo = true},
                        new DiaDaSemana() { Nome = "Sexta-Feira", Descricao = "Sexta-Feira", Ativo = true},
                        new DiaDaSemana() { Nome = "Sábado", Descricao = "Sábado", Ativo = true},
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
