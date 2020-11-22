using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Dietum
    {
        public Dietum()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int ID_Dieta { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
