using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Generic
{
    public interface IRead<TEntity>
    {
        IEnumerable<TEntity> GetAsync();
        TEntity GetAsync(int id);
        TEntity GetAsync(TEntity entity);
        TEntity GetAsync(Object obj);
    }
}
