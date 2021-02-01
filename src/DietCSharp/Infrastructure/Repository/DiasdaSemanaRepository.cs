using Core.Entities.DietcSharp;
using Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class DiasdaSemanaRepository : DefaultRepository<DiaDaSemana>, IDiasdaSemanaRepository
    {
        public DiasdaSemanaRepository(DietCScharpContext ctx) : base(ctx)
        {
        }

        public void AssociarDiasDaSemanaRefeicoes(List<int> listIdDiasdaSemana, int ID_PorcaoAlimento)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var IdDiasdaSemana in listIdDiasdaSemana)
                {
                    ctx.PorcaoDeAlimentoDiasdaSemanas.Add(new PorcaoDeAlimentoDiasdaSemana()
                    {
                        ID_DiaSemana = IdDiasdaSemana,
                        ID_PorcaoAlimento = ID_PorcaoAlimento
                    });
                    ctx.SaveChanges();
                }
            }
        }

        public List<DiaDaSemana> RetornarDiaDaSemanaPeloIdDaPorcaoDeAlimento(int id)
        {
            using (var ctx = new DietCScharpContext())
            {
                var lstDiaDaSemana = (from dia in ctx.DiaDaSemanas
                                      join diaPorc in ctx.PorcaoDeAlimentoDiasdaSemanas on dia.ID equals diaPorc.ID_DiaSemana
                                      join porc in ctx.PorcaoDeAlimentos on diaPorc.ID_PorcaoAlimento equals porc.ID
                                      where porc.ID == id
                                      select dia
                                      ).ToList();
                return lstDiaDaSemana;
            }
        }
    }
}
