using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class RegistroDeAtividade : Base.Entity
    {
        public DateTime Registro { get; set; }
        public string Sentimento { get; set; }
    }
}
