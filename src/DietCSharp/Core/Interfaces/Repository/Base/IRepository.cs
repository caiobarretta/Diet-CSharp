using Core.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Repository.Base
{
    public interface IRepository<TEntity> : IRead<TEntity>, IAlter<TEntity>
    {
    }
}
