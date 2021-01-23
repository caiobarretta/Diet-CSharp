using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimentoDiasdaSemana
    {
        public int ID { get; set; }
        public int ID_DiaSemana { get; set; }
        public int ID_Porc_Dia { get; set; }

        public virtual PorcaoDeAlimento IDNavigation { get; set; }
        public virtual DiaDaSemana ID_DiaSemanaNavigation { get; set; }
    }
}
