using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimentoRegistroDeAtividade
    {
        public int ID { get; set; }
        public int ID_PorcAlimento { get; set; }
        public int ID_RegistroDeAtividade { get; set; }

        public virtual PorcaoDeAlimento ID_PorcAlimentoNavigation { get; set; }
        public virtual RefeicaoPorcaoDeAlimento ID_RegistroDeAtividadeNavigation { get; set; }
    }
}
