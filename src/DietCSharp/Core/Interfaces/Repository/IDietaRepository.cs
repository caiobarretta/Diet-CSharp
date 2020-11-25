using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Repository
{
    interface IDietaRepository : IRepository<Dietum>
    {
    }
}
