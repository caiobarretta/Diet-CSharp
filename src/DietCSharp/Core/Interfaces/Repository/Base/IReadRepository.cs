using Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IReadRepository<TEntity> where TEntity : Entity
    {
        List<TEntity> Get(int take = 0, int skip = 0);
        TEntity Get(int id);
        TEntity Get(TEntity entity);
        List<TEntity> Search(string search);
    }
}
