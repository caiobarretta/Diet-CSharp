using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Rel_Ref_Porc
    {
        public int ID_Refeicao { get; set; }
        public int ID_PorcAlimento { get; set; }

        public virtual PorcaoDeAlimento ID_PorcAlimentoNavigation { get; set; }
        public virtual Refeico ID_RefeicaoNavigation { get; set; }
    }
}
