using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Repository
{
    public interface IDietaRepository : IRepository<Dietum>
    {
    }
}
