using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimento : Entity
    {
        public PorcaoDeAlimento()
        {
            Rel_Porc_Dia = new HashSet<Rel_Porc_Dium>();
            Rel_Porc_Dieta = new HashSet<Rel_Porc_Dietum>();
            Rel_Ref_Porcs = new HashSet<Rel_Ref_Porc>();
        }

        public virtual ICollection<Rel_Porc_Dium> Rel_Porc_Dia { get; set; }
        public virtual ICollection<Rel_Porc_Dietum> Rel_Porc_Dieta { get; set; }
        public virtual ICollection<Rel_Ref_Porc> Rel_Ref_Porcs { get; set; }
    }
}
