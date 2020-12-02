using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public abstract class DefaultRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DietCScharpContext _ctx;
        public DefaultRepository(DietCScharpContext ctx)
        {
            _ctx = ctx;
        }
        public virtual void Add(TEntity entity)
        {
            var db = _ctx.Set<TEntity>();
            db.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            var db = _ctx.Set<TEntity>();
            db.Remove(entity);
        }

        public virtual List<TEntity> Get(int take = 0, int skip = 0)
        {
            List<TEntity> list = new List<TEntity>();
            var db = _ctx.Set<TEntity>();
            list = db.Take(take)
                .Skip(skip)
                .AsNoTracking()
                .ToList();
            return list;
        }

        public virtual TEntity Get(int id)
        {
            TEntity entity = null;
            var db = _ctx.Set<TEntity>();
            entity = db.Where(x => x.ID == id).FirstOrDefault();
            return entity;
        }

        public virtual TEntity Get(TEntity entity)
        {
            TEntity entityReturn = null;
            _ctx.Entry(entity).Reload();
            var db = _ctx.Set<TEntity>();
            entityReturn = db.Find(entity);
            return entityReturn;
        }

        public List<TEntity> Search(TEntity entity, string search)
        {
            List<TEntity> list = new List<TEntity>();
            _ctx.Entry(entity).Reload();
            var db = _ctx.Set<TEntity>();
            list = db.Where(x => x.Nome.Contains(search) || x.Descricao.Contains(search))
                .AsNoTracking()
                .ToList();
            return list;
        }

        public virtual void Update(TEntity entity)
        {
            var db = _ctx.Set<TEntity>();
            db.Update(entity);
        }

    }
}
