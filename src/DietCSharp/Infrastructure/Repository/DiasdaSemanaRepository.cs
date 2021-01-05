using Core.Entities.DietcSharp;
using Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class DiasdaSemanaRepository : DefaultRepository<DiasdaSemana>, IDiasdaSemanaRepository
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
                    ctx.Rel_Porc_Dia.Add(new Rel_Porc_Dium()
                    {
                        ID_DiaSemana = IdDiasdaSemana,
                        ID_PorcAlimento = iD_PorcAlimento
                    });
                    ctx.SaveChanges();
                }
            }
        }
    }
}
