using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class DiaDaSemana : Base.Entity
    {
        public DiaDaSemana()
        {
            PorcaoDeAlimentoDiasdaSemanas = new HashSet<PorcaoDeAlimentoDiasdaSemana>();
        }


        public virtual ICollection<PorcaoDeAlimentoDiasdaSemana> PorcaoDeAlimentoDiasdaSemanas { get; set; }
    }
}
