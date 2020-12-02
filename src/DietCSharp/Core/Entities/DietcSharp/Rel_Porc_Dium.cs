using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Rel_Porc_Dium
    {
        public int ID_PorcAlimento { get; set; }
        public int ID_DiaSemana { get; set; }
        public int ID { get; set; }

        public virtual DiasdaSemana ID_DiaSemanaNavigation { get; set; }
        public virtual PorcaoDeAlimento ID_PorcAlimentoNavigation { get; set; }
    }
}
