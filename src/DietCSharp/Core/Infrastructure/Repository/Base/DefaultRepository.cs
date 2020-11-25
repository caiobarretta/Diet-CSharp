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
        public virtual void Add(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Add(entity);
                ctx.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Remove(entity);
                ctx.SaveChanges();
            }

        }

        public virtual List<TEntity> Get(int take = 0, int skip = 0)
        {
            List<TEntity> list = new List<TEntity>();
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                list = db.Take(take)
                    .Skip(skip)
                    .ToList();
            }
            return list;
        }

        public abstract TEntity Get(int id);

        public abstract TEntity Get(TEntity entity);

        public List<TEntity> Search(string search)
        {
            List<TEntity> list = new List<TEntity>();
            using (var ctx = new DietCScharpContext())
            {
                ctx.SaveChanges();
                var db = ctx.Set<TEntity>();
                list = db.Where(x => x.Nome.Contains(search) || x.Descricao.Contains(search)).ToList();
            }
            return list;
        }

        public virtual void Update(TEntity entity)
        {
            using (var ctx = new DietCScharpContext())
            {
                var db = ctx.Set<TEntity>();
                db.Update(entity);
                ctx.SaveChanges();
            }
        }
    }
}
