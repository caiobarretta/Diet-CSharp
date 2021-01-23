using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Refeicao : Base.Entity
    {
        public Refeicao()
        {
            RefeicaoPorcaoDeAlimentos = new HashSet<RefeicaoPorcaoDeAlimento>();
        }

        public virtual ICollection<RefeicaoPorcaoDeAlimento> RefeicaoPorcaoDeAlimentos { get; set; }
    }
}
