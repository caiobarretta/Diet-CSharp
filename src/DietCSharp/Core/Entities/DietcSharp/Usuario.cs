﻿using Core.Entities.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class Usuario : Entity
    {
        public int ID_Usuario { get; set; }
        public string Usuario1 { get; set; }
        public string Senha { get; set; }
        public int ID_Perfil { get; set; }
        //public string Descricao { get; set; }
        //public string Nome { get; set; }
        public int? ID_Dieta { get; set; }

        public virtual Dietum ID_DietaNavigation { get; set; }
        public virtual Perfil ID_PerfilNavigation { get; set; }
    }
}