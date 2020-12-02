using Core.Entities.Base;
using Core.Interfaces.Repository.Base;
using Core.Interfaces.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
    public class DefaultService<TEntity> : IService<TEntity> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> _repo;
        
        public DefaultService(IRepository<TEntity> repo) => _repo = repo;
        public void Add(TEntity entity) => _repo.Add(entity);

        public void Delete(TEntity entity) => _repo.Delete(entity);

        public List<TEntity> Get(int take = 0, int skip = 0) => _repo.Get(take, skip);

        public TEntity Get(int id) => _repo.Get(id);

        public TEntity Get(TEntity entity) => _repo.Get(entity);

        public List<TEntity> Search(string search) => _repo.Search(search);

        public void Update(TEntity entity) => _repo.Update(entity);
    }
}
