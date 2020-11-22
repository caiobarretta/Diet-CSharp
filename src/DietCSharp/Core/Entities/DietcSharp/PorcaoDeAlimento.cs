using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class PorcaoDeAlimento
    {
        public int ID_PorcAlimento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
