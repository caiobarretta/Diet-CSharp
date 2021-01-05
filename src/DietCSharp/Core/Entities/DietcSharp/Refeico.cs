using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Refeico : Entity
    {
        public Refeico()
        {
            Rel_Ref_Porcs = new HashSet<Rel_Ref_Porc>();
        }

        public virtual ICollection<Rel_Ref_Porc> Rel_Ref_Porcs { get; set; }
    }
}
