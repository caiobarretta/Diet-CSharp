using Core.Entities.Base;
using Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service.Base
{
    public interface IService<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        
    }
}
