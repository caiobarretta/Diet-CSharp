using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Dietum : Base.Entity
    {
        public Dietum()
        {
            PorcaoDeAlimentoDieta = new HashSet<PorcaoDeAlimentoDietum>();
            Usuarios = new HashSet<Usuario>();
        }


        public virtual ICollection<PorcaoDeAlimentoDietum> PorcaoDeAlimentoDieta { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
