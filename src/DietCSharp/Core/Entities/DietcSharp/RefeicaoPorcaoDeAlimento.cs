using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class RefeicaoPorcaoDeAlimento
    {
        public RefeicaoPorcaoDeAlimento()
        {
            PorcaoDeAlimentoRegistroDeAtividades = new HashSet<PorcaoDeAlimentoRegistroDeAtividade>();
        }

        public int ID { get; set; }
        public int ID_Refeicao { get; set; }
        public int ID_PorcAlimento { get; set; }

        public virtual PorcaoDeAlimento ID_PorcAlimentoNavigation { get; set; }
        public virtual Refeicao ID_RefeicaoNavigation { get; set; }
        public virtual ICollection<PorcaoDeAlimentoRegistroDeAtividade> PorcaoDeAlimentoRegistroDeAtividades { get; set; }
    }
}
