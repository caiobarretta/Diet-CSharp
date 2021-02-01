using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimento : Base.Entity
    {
        public PorcaoDeAlimento()
        {
            PorcaoDeAlimentoDiasdaSemanas = new HashSet<PorcaoDeAlimentoDiasdaSemana>();
            PorcaoDeAlimentoDieta = new HashSet<PorcaoDeAlimentoDietum>();
            PorcaoDeAlimentoRegistroDeAtividades = new HashSet<PorcaoDeAlimentoRegistroDeAtividade>();
            RefeicaoPorcaoDeAlimentos = new HashSet<RefeicaoPorcaoDeAlimento>();
        }


        public virtual ICollection<PorcaoDeAlimentoDiasdaSemana> PorcaoDeAlimentoDiasdaSemanas { get; set; }
        public virtual ICollection<PorcaoDeAlimentoDietum> PorcaoDeAlimentoDieta { get; set; }
        public virtual ICollection<PorcaoDeAlimentoRegistroDeAtividade> PorcaoDeAlimentoRegistroDeAtividades { get; set; }
        public virtual ICollection<RefeicaoPorcaoDeAlimento> RefeicaoPorcaoDeAlimentos { get; set; }
    }
}
