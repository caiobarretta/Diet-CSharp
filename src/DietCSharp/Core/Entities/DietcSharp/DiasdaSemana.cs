using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class DiasdaSemana : Entity
    {
        public DiasdaSemana()
        {
            Rel_Porc_Dia = new HashSet<Rel_Porc_Dium>();
        }
        public virtual ICollection<Rel_Porc_Dium> Rel_Porc_Dia { get; set; }
    }
}
