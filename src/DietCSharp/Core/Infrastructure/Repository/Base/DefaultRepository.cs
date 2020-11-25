using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repository.Base
{
    public abstract class DefaultRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DietCScharpContext _ctx;
        protected readonly DbSet<TEntity> _db;
        public DefaultRepository(DietCScharpContext ctx)
        {
            _ctx = ctx;
            _db = _ctx.Set<TEntity>();
        }

        public virtual void AddAsync(TEntity entity)
        {
            _db.Add(entity);
            _ctx.SaveChanges();
        }

        public virtual void DeleteAsync(TEntity entity)
        {
            _db.Remove(entity);
            _ctx.SaveChanges();
        }

        public virtual List<TEntity> Get(int take = 0, int skip = 0)
        {
            var list = _db.Take(take)
                .Skip(skip)
                .ToList();
            return list;
        }

        public abstract TEntity Get(int id);

        public abstract TEntity Get(TEntity entity);

        public List<TEntity> Search(string search)
        {
            return _db.Where(x => x.Nome.Contains(search) || x.Descricao.Contains(search)).ToList();
        }

        public virtual void UpdateAsync(TEntity entity)
        {
            _db.Update(entity);
            _ctx.SaveChangesAsync();
        }
    }
}
