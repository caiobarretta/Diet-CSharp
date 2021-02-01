using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IPorcaoDeAlimentoRepository : IRepository<PorcaoDeAlimento>
    {
        void AssociarPorcaoRefeicoes(List<int> listIdRefeicao, int idPorcaoDeAlimento);
        void AssociarPorcaoAlimentoDieta(List<int> listIdProcaoAlimento, int iD_Dieta);
        List<PorcaoDeAlimento> RetornaPorcaoDeAlimentoPeloIdDaDieta(int id);
    }
}
