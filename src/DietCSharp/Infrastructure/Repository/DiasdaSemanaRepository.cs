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

        public void AssociarDiasDaSemanaRefeicoes(List<int> listIdDiasdaSemana, int iD_PorcAlimento)
        {
            using (var ctx = new DietCScharpContext())
            {
                foreach (var IdDiasdaSemana in listIdDiasdaSemana)
                {
                    ctx.PorcaoDeAlimentoDiasdaSemanas.Add(new PorcaoDeAlimentoDiasdaSemana()
                    {
                        ID_DiaSemana = IdDiasdaSemana,
                        ID_Porc_Dia = iD_PorcAlimento
                    });
                    ctx.SaveChanges();
                }
            }
        }
    }
}
