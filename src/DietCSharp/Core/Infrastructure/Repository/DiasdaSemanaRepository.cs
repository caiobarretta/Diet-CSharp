using Core.Entities.DietcSharp;
using Core.Infrastructure.Repository.Base;
using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Infrastructure.Repository
{
    public class DiasdaSemanaRepository : DefaultRepository<DiasdaSemana>, IDiasdaSemanaRepository
    {
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

        public override DiasdaSemana Get(int id)
        {
            DiasdaSemana diasdaSemana = null;
            using (var ctx = new DietCScharpContext())
                diasdaSemana = ctx.DiasdaSemanas.Where(x => x.ID_DiaSemana == id).FirstOrDefault();
            return diasdaSemana;
        }

        public override DiasdaSemana Get(DiasdaSemana entity)
        {
            throw new NotImplementedException();
        }
    }
}
