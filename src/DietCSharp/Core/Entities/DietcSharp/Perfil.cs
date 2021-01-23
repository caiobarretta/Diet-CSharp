using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Perfil : Base.Entity
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
