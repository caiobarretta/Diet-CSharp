using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Generic
{
    public interface IAlter<TEntity>
    {
        void AddAsync(TEntity entity);
        void UpdateAsync(TEntity entity);
        void DeleteAsync(TEntity entity);
    }
}
