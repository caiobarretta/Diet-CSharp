using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimentoDietum
    {
        public int ID { get; set; }
        public int ID_PorcAlimento { get; set; }
        public int ID_Dieta { get; set; }

        public virtual Dietum ID_DietaNavigation { get; set; }
        public virtual PorcaoDeAlimento ID_PorcAlimentoNavigation { get; set; }
    }
}
