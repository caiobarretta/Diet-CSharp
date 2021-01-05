using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Dietum : Entity
    {
        public Dietum()
        {
            Rel_Porc_Dieta = new HashSet<Rel_Porc_Dietum>();
            Usuarios = new HashSet<Usuario>();
        }

        public virtual ICollection<Rel_Porc_Dietum> Rel_Porc_Dieta { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
