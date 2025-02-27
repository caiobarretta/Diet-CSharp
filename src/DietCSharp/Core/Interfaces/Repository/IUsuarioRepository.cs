﻿using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        bool IsUsuario(string usuario, string senha, out int CodigoUsuario);
    }
}
