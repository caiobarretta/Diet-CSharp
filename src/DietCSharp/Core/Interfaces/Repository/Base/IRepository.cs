using Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Repository.Base
{
    public interface IRepository<TEntity> : IReadRepository<TEntity>, IAlterRepository<TEntity> where TEntity : Entity
    {
    }
}
